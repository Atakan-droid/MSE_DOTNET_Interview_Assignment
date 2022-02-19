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
    public partial class UretimYoluEkle : Form
    {
        HttpClient client;
        public UretimYoluEkle()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4296/api/productionline/");
            InitializeComponent();
        }

        private async void addLine_Click(object sender, EventArgs e)
        {
            if (lineName.Text == "")
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                ProductionLine line = new ProductionLine();
                var response = await client.PostAsJsonAsync("addproductionLine", line);
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
