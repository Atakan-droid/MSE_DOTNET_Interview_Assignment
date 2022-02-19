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
    public partial class IstasyonGuncelle : Form
    {
        HttpClient client;
        string valueofUser = Istasyon.SetValueForStation;
        public IstasyonGuncelle()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4296/api/station/");
            InitializeComponent();
        }

        private async void IstasyonGuncelle_Load(object sender, EventArgs e)
        {
            Station station = await client.GetFromJsonAsync<Station>($"getstationbyid/{valueofUser}");
            stationName.Text = station.StationName;
            pressure.Text = station.Pressure.ToString();
            heat.Text = station.Temperature.ToString();
            status.Text = station.Status;
            maintenanceStaffId.Text = station.MaintenanceStaffId.ToString();
            productionLineId.Text = station.LineId.ToString();
        }

        private async void updateStation_Click(object sender, EventArgs e)
        {
            if (stationName.Text == "" || pressure.Text == "" || heat.Text == "" || status.Text == "" || maintenanceStaffId.Text == "" || productionLineId.Text == "")
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                Station station = new Station();
                station.StationName = stationName.Text;
                station.Pressure = Convert.ToDecimal(pressure.Text);
                station.Temperature = Convert.ToDecimal(heat.Text);
                station.Status = status.Text;
                station.MaintenanceStaffId = Int32.Parse(maintenanceStaffId.Text);
                station.LineId = Int32.Parse(productionLineId.Text);
                var response = await client.PostAsJsonAsync("updatestation", station);
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
