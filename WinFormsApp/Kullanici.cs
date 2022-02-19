using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Kullanici : Form
    {
        HttpClient client;
        KullaniciEkle kullaniciEkle;
        public static string SetValueForUser="";
        public Kullanici()
        {
            client = new HttpClient();
            kullaniciEkle = new KullaniciEkle();
            client.BaseAddress = new Uri("http://localhost:4296/api/user/");
            
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[2].Name = "Ad";
            dataGridView1.Columns[3].Name = "Soyad";
            dataGridView1.Columns[4].Name = "Eklenme Tarihi";
            dataGridView1.Columns[5].Name = "Güncellenme Tarihi";

        }

        private void geridon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.ShowDialog();
            

        }
        private async void getall_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            List<User> users = await client.GetFromJsonAsync<List<User>>("getusers");

            for (int i = 0; i < users.Count; i++)
            {
                i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = users[i].Id;
                dataGridView1.Rows[i].Cells[1].Value = users[i].Mail;
                dataGridView1.Rows[i].Cells[2].Value = users[i].Name;
                dataGridView1.Rows[i].Cells[3].Value = users[i].Surname;
                dataGridView1.Rows[i].Cells[4].Value = users[i].CreatedDate;
                dataGridView1.Rows[i].Cells[5].Value = users[i].ModifiedDate;
            }
        }
        private async void getbyid_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            User user = await client.GetFromJsonAsync<User>($"getuserbyid/{id_text.Text}");


                int i = dataGridView1.Rows.Add();
                
                dataGridView1.Rows[i].Cells[0].Value = user.Id;
                dataGridView1.Rows[i].Cells[1].Value = user.Mail;
                dataGridView1.Rows[i].Cells[2].Value = user.Name;
                dataGridView1.Rows[i].Cells[3].Value = user.Surname;
                dataGridView1.Rows[i].Cells[4].Value = user.CreatedDate;
                dataGridView1.Rows[i].Cells[5].Value = user.ModifiedDate;
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            kullaniciEkle.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (updateUserId.Text == "") { MessageBox.Show("Id Alanı Boş bırakılamaz"); }
            SetValueForUser = updateUserId.Text;
            KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle();
            kullaniciGuncelle.ShowDialog();
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            if (deleteUser.Text == "") { MessageBox.Show("Boş Bırakılamaz Id Alanı"); } else
            {
                DialogResult dialogResult = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Silmek", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    User user = await client.GetFromJsonAsync<User>($"getuserbyid/{deleteUser.Text}");
                    user.IsDeleted = true;
                    var response = await client.GetAsync($"deleteuser/{deleteUser.Text}");
                    MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

        }

        private void Kullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
