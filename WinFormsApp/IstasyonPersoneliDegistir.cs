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
    public partial class IstasyonPersoneliDegistir : Form
    {
        HttpClient client;
        public IstasyonPersoneliDegistir()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4296/api/station/");
            InitializeComponent();
        }

        private void IstasyonPersoneliDegistir_Load(object sender, EventArgs e)
        {

        }

        private async void updateStation1_Click(object sender, EventArgs e)
        {
            if (stationIdText.Text == "" || userIdText.Text == "")
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                var station = await client.PostAsJsonAsync($"updatestationstaff/{stationIdText.Text}/{userIdText.Text}","");
                
                MessageBox.Show(station.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
