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
    public partial class IstasyonEkle : Form
    {
        HttpClient client;
        public IstasyonEkle()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4296/api/station/");
            InitializeComponent();
        }

        private void IstasyonEkle_Load(object sender, EventArgs e)
        {

           
           
        }

        private async void addStation_Click(object sender, EventArgs e)
        {
            if (stationName.Text == "" || Pressure.Text == "" || heat.Text == "" || status.Text == "" || maintenanceStaffId.Text == "" || productionLineId.Text == "")
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                Station station = new Station();
                station.StationName = stationName.Text;
                station.Pressure = Convert.ToDecimal(Pressure.Text);
                station.Temperature = Convert.ToDecimal(heat.Text);
                station.Status = status.Text;
                station.MaintenanceStaffId = Int32.Parse(maintenanceStaffId.Text);
                station.LineId = Int32.Parse(productionLineId.Text);
                var response = await client.PostAsJsonAsync("addstation", station);
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
