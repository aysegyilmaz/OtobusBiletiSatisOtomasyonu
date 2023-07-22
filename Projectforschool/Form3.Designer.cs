namespace Projectforschool
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb0 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbkadın = new System.Windows.Forms.RadioButton();
            this.rdberkek = new System.Windows.Forms.RadioButton();
            this.iptalbuton = new System.Windows.Forms.Button();
            this.kaydetbuton = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(90, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(517, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(466, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            // 
            // isim
            // 
            this.isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isim.Location = new System.Drawing.Point(177, 169);
            this.isim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(168, 30);
            this.isim.TabIndex = 3;
            // 
            // soyisim
            // 
            this.soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.soyisim.Location = new System.Drawing.Point(626, 167);
            this.soyisim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(168, 30);
            this.soyisim.TabIndex = 4;
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.telefon.Location = new System.Drawing.Point(626, 251);
            this.telefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(168, 30);
            this.telefon.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rdb0);
            this.groupBox1.Controls.Add(this.rdb5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(64, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(281, 113);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Age";
            // 
            // rdb0
            // 
            this.rdb0.AutoSize = true;
            this.rdb0.Checked = true;
            this.rdb0.Location = new System.Drawing.Point(0, 31);
            this.rdb0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb0.Name = "rdb0";
            this.rdb0.Size = new System.Drawing.Size(62, 29);
            this.rdb0.TabIndex = 11;
            this.rdb0.TabStop = true;
            this.rdb0.Text = "0-7";
            this.rdb0.UseVisualStyleBackColor = true;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(0, 64);
            this.rdb5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(56, 29);
            this.rdb5.TabIndex = 9;
            this.rdb5.Text = "7+";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rdbkadın);
            this.groupBox2.Controls.Add(this.rdberkek);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(513, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(281, 113);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rdbkadın
            // 
            this.rdbkadın.AutoSize = true;
            this.rdbkadın.Checked = true;
            this.rdbkadın.Location = new System.Drawing.Point(0, 30);
            this.rdbkadın.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbkadın.Name = "rdbkadın";
            this.rdbkadın.Size = new System.Drawing.Size(102, 29);
            this.rdbkadın.TabIndex = 11;
            this.rdbkadın.TabStop = true;
            this.rdbkadın.Text = "Woman";
            this.rdbkadın.UseVisualStyleBackColor = true;
            // 
            // rdberkek
            // 
            this.rdberkek.AutoSize = true;
            this.rdberkek.Location = new System.Drawing.Point(0, 64);
            this.rdberkek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdberkek.Name = "rdberkek";
            this.rdberkek.Size = new System.Drawing.Size(72, 29);
            this.rdberkek.TabIndex = 9;
            this.rdberkek.Text = "Man";
            this.rdberkek.UseVisualStyleBackColor = true;
            // 
            // iptalbuton
            // 
            this.iptalbuton.BackColor = System.Drawing.Color.OrangeRed;
            this.iptalbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iptalbuton.Location = new System.Drawing.Point(680, 495);
            this.iptalbuton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptalbuton.Name = "iptalbuton";
            this.iptalbuton.Size = new System.Drawing.Size(133, 48);
            this.iptalbuton.TabIndex = 13;
            this.iptalbuton.Text = "Cancel";
            this.iptalbuton.UseVisualStyleBackColor = false;
            this.iptalbuton.Click += new System.EventHandler(this.iptalbuton_Click);
            // 
            // kaydetbuton
            // 
            this.kaydetbuton.BackColor = System.Drawing.Color.LimeGreen;
            this.kaydetbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kaydetbuton.Location = new System.Drawing.Point(92, 495);
            this.kaydetbuton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kaydetbuton.Name = "kaydetbuton";
            this.kaydetbuton.Size = new System.Drawing.Size(133, 48);
            this.kaydetbuton.TabIndex = 14;
            this.kaydetbuton.Text = "Save";
            this.kaydetbuton.UseVisualStyleBackColor = false;
            this.kaydetbuton.Click += new System.EventHandler(this.kaydetbuton_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email.Location = new System.Drawing.Point(177, 249);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 30);
            this.email.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-mail address:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 671);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kaydetbuton);
            this.Controls.Add(this.iptalbuton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Kayıt Formu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb0;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbkadın;
        private System.Windows.Forms.RadioButton rdberkek;
        private System.Windows.Forms.Button iptalbuton;
        private System.Windows.Forms.Button kaydetbuton;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
    }
}