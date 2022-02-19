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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class KullaniciEkle : Form
    {
        HttpClient client;
        public KullaniciEkle()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4296/api/user/");
            InitializeComponent();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            

        }

        private async void add_Click(object sender, EventArgs e)
        {
       
            if(textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Boş Bırakılamaz");
            }
            else
            {
                User user = new User();
                user.Mail = textBox1.Text;
                user.Password = textBox2.Text;
                user.Name = textBox3.Text;
                user.Surname = textBox4.Text;
                user.RoleID = 2;
                var response = await client.PostAsJsonAsync("adduser", user);
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
           
        }
    }
}
