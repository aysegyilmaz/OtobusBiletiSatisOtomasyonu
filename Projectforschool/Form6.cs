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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();;
            this.IsMdiContainer = true;
        }
        string Kullanici;

        string sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici = textBox1.Text;

            sifre = textBox2.Text;

            if (Kullanici == "aysegul" && sifre == "123456")
            {

                this.Hide();
                Form1 frm = new Form1();
                frm.Show();

            }

            else

            {
                {
                    label3.Show();
                }
            }
            Form1 form2 = new Form1();//açılacak form
            form2.MdiParent = this;//bu formu parent olarak veriyoruz.
            form2.Show(); //form 2 açılıyor.

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }
    }

}
