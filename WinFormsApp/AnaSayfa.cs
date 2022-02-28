using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void KullaniciIslemleri_Click(object sender, EventArgs e)
        {
            Kullanici user = new Kullanici();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void IstasyonIslemleri_Click(object sender, EventArgs e)
        {
            Istasyon istasyon = new Istasyon();
            this.Hide();
            istasyon.ShowDialog();
            this.Show();
        }

        private void UretimYolu_Click(object sender, EventArgs e)
        {
            UretimYolu uretimYolu = new UretimYolu();
            this.Hide();
            uretimYolu.ShowDialog();
            this.Show();
        }
    }
}
