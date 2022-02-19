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
    public partial class Istasyon : Form
    {
        HttpClient client;
        IstasyonEkle istasyonEkle;
        public static string SetValueForStation = "";
        public Istasyon()
        {
            client = new HttpClient();
            istasyonEkle = new IstasyonEkle();
            client.BaseAddress = new Uri("http://localhost:4296/api/station/");

            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "İstasyon Adı";
            dataGridView1.Columns[2].Name = "Basınç";
            dataGridView1.Columns[3].Name = "Isı";
            dataGridView1.Columns[4].Name = "Durum";
            dataGridView1.Columns[5].Name = "Üretim Yolu Id";
            dataGridView1.Columns[6].Name = "Bakım Çalışanı Id";
        }

        private void Istasyon_Load(object sender, EventArgs e)
        {

        }

        private void geridon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            Station station = await client.GetFromJsonAsync<Station>($"getstationbyid/{getbyidText.Text}");


            int i = dataGridView1.Rows.Add();

            dataGridView1.Rows[i].Cells[0].Value = station.Id;
            dataGridView1.Rows[i].Cells[1].Value = station.StationName;
            dataGridView1.Rows[i].Cells[2].Value = station.Pressure;
            dataGridView1.Rows[i].Cells[3].Value = station.Temperature;
            dataGridView1.Rows[i].Cells[4].Value = station.Status;
            dataGridView1.Rows[i].Cells[5].Value = station.LineId;
            dataGridView1.Rows[i].Cells[6].Value = station.MaintenanceStaffId;
        }

        private async void getall_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            List<Station> stations = await client.GetFromJsonAsync<List<Station>>("getstations");

            for (int i = 0; i < stations.Count; i++)
            {
                i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = stations[i].Id;
                dataGridView1.Rows[i].Cells[1].Value = stations[i].StationName;
                dataGridView1.Rows[i].Cells[2].Value = stations[i].Pressure;
                dataGridView1.Rows[i].Cells[3].Value = stations[i].Temperature;
                dataGridView1.Rows[i].Cells[4].Value = stations[i].Status;
                dataGridView1.Rows[i].Cells[5].Value = stations[i].LineId;
                dataGridView1.Rows[i].Cells[6].Value = stations[i].MaintenanceStaffId;
            }
        }

        private async void deletestation_Click(object sender, EventArgs e)
        {
            if (deleteId.Text == "") { MessageBox.Show("Boş Bırakılamaz Id Alanı"); }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Silmek", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Station station = await client.GetFromJsonAsync<Station>($"getuserbyid/{deleteId.Text}");
                    station.IsDeleted = true;
                    var response = await client.GetAsync($"deletestation/{deleteId.Text}");
                    MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void addstation_Click(object sender, EventArgs e)
        {
            istasyonEkle.ShowDialog();
        }

        private void updatestation_Click(object sender, EventArgs e)
        {
            if (updateId.Text == "") { MessageBox.Show("Id Alanı Boş bırakılamaz"); }
            SetValueForStation = updateId.Text;
            IstasyonGuncelle istasyonGuncelle = new IstasyonGuncelle();
            istasyonGuncelle.ShowDialog();
        }
    }
}
