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
    public partial class KullaniciGuncelle : Form
    {
        HttpClient client;
        string valueofUser = Kullanici.SetValueForUser;
        public KullaniciGuncelle()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4296/api/user/");
            InitializeComponent();
        }

        private async void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            
            User user = await client.GetFromJsonAsync<User>($"getuserbyid/{valueofUser}");
            textBox1.Text = user.Mail;
            textBox2.Text = user.Password;
            textBox3.Text = user.Name;
            textBox4.Text = user.Surname;
        }

        private async void update_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
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
                var response = await client.PutAsJsonAsync($"updateuser/{valueofUser}", user);
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
           
        }
    }
    }

