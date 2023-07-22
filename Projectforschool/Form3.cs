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
    public partial class Form3 : Form
    {
        private Form2 mainForm;
        private string kalkis;
        private string varis;
        private string tarih;
        private string saat;
        private string koltuk;
        public Form3(Form2 original, string kalkis, string varis, string tarih, string saat, string koltuk)
        {
            this.mainForm = original;
            this.kalkis = kalkis;
            this.varis = varis;
            this.tarih = tarih;
            this.saat = saat;
            this.koltuk = koltuk;

            InitializeComponent();
        }
        public string Isim
        {
            get { return this.isim.Text; }
        }
        public string Soyisim
        {
            get { return this.soyisim.Text; }
        }
        public string Email
        {
            get { return this.email.Text; }
        }
        public string Telefon
        {
            get { return this.telefon.Text; }
        }
        public string Yas
        {
            get { return this.groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;  }
        }
        public string Cinsiyet
        {
            get { return this.groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text; }
        }
        private void kaydetbuton_Click(object sender, EventArgs e)
        {
            if(this.Isim == null || this.Soyisim == null || this.Email == null || this.Telefon == null || this.Yas == null || this.Cinsiyet == null)
            {
                MessageBox.Show("Please fill out all the empty inputs.");
            }
            Form4 form4 = new Form4(this.Isim, this.Soyisim, this.Email, this.Telefon, this.Yas, this.Cinsiyet, this.kalkis, this.varis,this.tarih, this.saat, this.koltuk);
            form4.Show();
            this.Close();


        }

        private void iptalbuton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
