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
    public partial class Form5 : Form
    {
        private List<Button> buttons; // tüm classta butonlara erişmek için list belirledik
        private Form2 mainForm = null;
        public Form5(Form callingForm)
        {
            mainForm = callingForm as Form2;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            buttons = new List<Button>(); // list
            Random rnd = new Random();
            foreach (var button in this.Controls.OfType<Button>()) // tüm butonları listeye ekliyoruz
            {
                this.buttons.Add(button);
            }
            foreach(var btn in this.buttons.OrderBy(x => rnd.Next()).Take(rnd.Next(0, 23)))
            {
                if (btn.Text == "OK") continue;
                btn.Enabled = false;
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false; 
            }
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.mainForm.SeatNo.Text = this.label1.Text;
            this.Close();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var b = (sender as Button);
            b.BackColor = Color.Green;
            b.ForeColor = Color.White;
            this.label1.Text = b.Text;
            this.label1.Enabled = false;
            foreach (var btn in this.buttons)
            {
                if (btn == sender || btn.Text == "OK") continue;
                btn.Enabled = false;
            }
        }
    }
}
