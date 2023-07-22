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
    public partial class Form2 : Form
    {
        public Label SeatNo
        {
            get { return this.label7; }
            set { this.label7 = value; }
        }
        public string Kalkis = "";
        public string Varis = "";
        public string Tarih
        {
            get { return this.dtptarih.Value.ToString("dd-MM-yyyy"); }
        }
        public string Saat = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Saat = (sender as ComboBox).SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(this);
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.combmevcut.SelectedIndex == -1)
            {
                MessageBox.Show("You did not choose departure city.");
                return;
            }
            if(this.combgidilecek.SelectedIndex == -1)
            {
                MessageBox.Show("You did not choose arrival city.");
                return;
            }
            if(!this.dtptarih.Checked)
            {
                MessageBox.Show("You did not choose deprature date.");
                return;
            }
            if(this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You did not choose deprature hour.");
                return;
            }
            if(this.SeatNo.Text == "0")
            {
                MessageBox.Show("You did not choose a seat.");
                return;
            }

            Form3 form3 = new Form3(this, this.Kalkis, this.Varis, this.Tarih,this.Saat,this.SeatNo.Text);
            form3.Show();
            this.Close();

        }

        private void combmevcut_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Kalkis = (sender as ComboBox).SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void combgidilecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Varis = (sender as ComboBox).SelectedItem.ToString();
        }
        
    }
}
