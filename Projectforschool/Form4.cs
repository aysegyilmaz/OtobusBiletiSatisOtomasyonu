using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectforschool
{
    public partial class Form4 : Form
    {
        public Form4(string isim, string soyisim, string email, string telefon, string yas, string cinsiyet, string kalkis, string varis, string tarih, string saat, string koltuk)
        {
            InitializeComponent();
            this.label12.Text = isim;
            this.label13.Text = soyisim;
            this.label14.Text = email;
            this.label15.Text = telefon;
            this.label16.Text = yas;
            this.label17.Text = cinsiyet;
            this.label18.Text = kalkis;
            this.label19.Text = varis;
            this.label20.Text = tarih;
            this.label21.Text = saat;
            this.label22.Text = koltuk;
            this.label23.Text = yas == "0-7" ? "50" : "100"; // price

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your ticket has been taken. Have a Good Journey!");
            this.Close();
            Application.Exit();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
