using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class UretimYoluGuncelle : Form
    {
        HttpClient client;
        string valueofLine = UretimYolu.SetValueForLine;
        public UretimYoluGuncelle()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4296/api/productionline/");
            InitializeComponent();
        }

        private async void updateLine_Click(object sender, EventArgs e)
        {
            if (lineName.Text == "")
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                ProductionLine line = new ProductionLine();
                line.LineName = lineName.Text;
                var response = await client.PutAsJsonAsync($"updateproductionLine/{valueofLine}", line);
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
        }

        private async void UretimYoluGuncelle_Load(object sender, EventArgs e)
        {
            ProductionLine line = await client.GetFromJsonAsync<ProductionLine>($"getproductionLinebyid/{valueofLine}");
            lineName.Text = line.LineName;
        }
    }
}
