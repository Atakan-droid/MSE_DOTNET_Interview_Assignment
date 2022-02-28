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
    public partial class UretimYolu : Form
    {
        HttpClient client;
        UretimYoluEkle uretimYoluEkle;
        public static string SetValueForLine = "";
        public UretimYolu()
        {
            client = new HttpClient();
            uretimYoluEkle = new UretimYoluEkle();
            client.BaseAddress = new Uri("http://localhost:4296/api/productionline/");

            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Üretim Yolu Adı";
        }

        private async void getall_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            List<ProductionLine> lines = await client.GetFromJsonAsync<List<ProductionLine>>("getproductionLines");

            for (int i = 0; i < lines.Count; i++)
            {
                i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lines[i].Id;
                dataGridView1.Rows[i].Cells[1].Value = lines[i].LineName;
            }
        }

        private async void getbyid_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            ProductionLine line = await client.GetFromJsonAsync<ProductionLine>($"getproductionLinebyid/{getbyidText.Text}");


            int i = dataGridView1.Rows.Add();

            dataGridView1.Rows[i].Cells[0].Value = line.Id;
            dataGridView1.Rows[i].Cells[1].Value = line.LineName;
        }

        private async void deleteLine_Click(object sender, EventArgs e)
        {
            if (deleteIdText.Text == "") { MessageBox.Show("Boş Bırakılamaz Id Alanı"); }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Silmek", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ProductionLine line = await client.GetFromJsonAsync<ProductionLine>($"getproductionLinesbyuser/{deleteIdText.Text}");
                    line.IsDeleted = true;
                    var response = await client.GetAsync($"deleteproductionLine/{deleteIdText.Text}");
                    MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void addLine_Click(object sender, EventArgs e)
        {
            uretimYoluEkle.ShowDialog();
        }

        private void updateLine_Click(object sender, EventArgs e)
        {
            if (updateIdText.Text == "") { MessageBox.Show("Id Alanı Boş bırakılamaz"); }
            SetValueForLine = updateIdText.Text;
            UretimYoluGuncelle uretimYoluGuncelle = new UretimYoluGuncelle();
            uretimYoluGuncelle.ShowDialog();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private async void UretimYolu_Load(object sender, EventArgs e)
        { 
          
        }
    }
}
