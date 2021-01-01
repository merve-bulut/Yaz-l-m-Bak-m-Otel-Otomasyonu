namespace veriYapilariProjeOdevi
{
    partial class frmPerGuncelle
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
            this.cmbPerGuncOtel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnPersonelGunc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdnBes = new System.Windows.Forms.RadioButton();
            this.rdnDort = new System.Windows.Forms.RadioButton();
            this.rdnUc = new System.Windows.Forms.RadioButton();
            this.rdnIkı = new System.Windows.Forms.RadioButton();
            this.rdnBir = new System.Windows.Forms.RadioButton();
            this.cmbGuncDepartman = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuncEPosta = new System.Windows.Forms.TextBox();
            this.txtGuncAdres = new System.Windows.Forms.TextBox();
            this.txtGuncTel = new System.Windows.Forms.TextBox();
            this.TxtGuncSoyad = new System.Windows.Forms.TextBox();
            this.TxtGuncAd = new System.Windows.Forms.TextBox();
            this.txtGuncTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGuncPer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGuncPoz = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPerGuncOtel
            // 
            this.cmbPerGuncOtel.FormattingEnabled = true;
            this.cmbPerGuncOtel.Location = new System.Drawing.Point(221, 24);
            this.cmbPerGuncOtel.Name = "cmbPerGuncOtel";
            this.cmbPerGuncOtel.Size = new System.Drawing.Size(288, 21);
            this.cmbPerGuncOtel.TabIndex = 35;
            this.cmbPerGuncOtel.SelectedIndexChanged += new System.EventHandler(this.cmbPerGuncOtel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "OTEL SEÇİNİZ :";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(600, 37);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(143, 30);
            this.btnGeriDon.TabIndex = 33;
            this.btnGeriDon.Text = "PERSONEL LİSTELE";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnPersonelGunc
            // 
            this.btnPersonelGunc.Location = new System.Drawing.Point(354, 381);
            this.btnPersonelGunc.Name = "btnPersonelGunc";
            this.btnPersonelGunc.Size = new System.Drawing.Size(155, 39);
            this.btnPersonelGunc.TabIndex = 32;
            this.btnPersonelGunc.Text = "GÜNCELLE";
            this.btnPersonelGunc.UseVisualStyleBackColor = true;
            this.btnPersonelGunc.Click += new System.EventHandler(this.btnPersonelGunc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cmbGuncPoz);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbGuncDepartman);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(380, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 261);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERSONEL OTEL BİLGİLERİ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.rdnBes);
            this.groupBox3.Controls.Add(this.rdnDort);
            this.groupBox3.Controls.Add(this.rdnUc);
            this.groupBox3.Controls.Add(this.rdnIkı);
            this.groupBox3.Controls.Add(this.rdnBir);
            this.groupBox3.Location = new System.Drawing.Point(29, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PERSONEL PUANI";
            // 
            // rdnBes
            // 
            this.rdnBes.AutoSize = true;
            this.rdnBes.Location = new System.Drawing.Point(15, 119);
            this.rdnBes.Name = "rdnBes";
            this.rdnBes.Size = new System.Drawing.Size(31, 17);
            this.rdnBes.TabIndex = 4;
            this.rdnBes.TabStop = true;
            this.rdnBes.Text = "5";
            this.rdnBes.UseVisualStyleBackColor = true;
            // 
            // rdnDort
            // 
            this.rdnDort.AutoSize = true;
            this.rdnDort.Location = new System.Drawing.Point(15, 96);
            this.rdnDort.Name = "rdnDort";
            this.rdnDort.Size = new System.Drawing.Size(31, 17);
            this.rdnDort.TabIndex = 3;
            this.rdnDort.TabStop = true;
            this.rdnDort.Text = "4";
            this.rdnDort.UseVisualStyleBackColor = true;
            // 
            // rdnUc
            // 
            this.rdnUc.AutoSize = true;
            this.rdnUc.Location = new System.Drawing.Point(15, 72);
            this.rdnUc.Name = "rdnUc";
            this.rdnUc.Size = new System.Drawing.Size(31, 17);
            this.rdnUc.TabIndex = 2;
            this.rdnUc.TabStop = true;
            this.rdnUc.Text = "3";
            this.rdnUc.UseVisualStyleBackColor = true;
            // 
            // rdnIkı
            // 
            this.rdnIkı.AutoSize = true;
            this.rdnIkı.Location = new System.Drawing.Point(15, 49);
            this.rdnIkı.Name = "rdnIkı";
            this.rdnIkı.Size = new System.Drawing.Size(31, 17);
            this.rdnIkı.TabIndex = 1;
            this.rdnIkı.TabStop = true;
            this.rdnIkı.Text = "2";
            this.rdnIkı.UseVisualStyleBackColor = true;
            // 
            // rdnBir
            // 
            this.rdnBir.AutoSize = true;
            this.rdnBir.Location = new System.Drawing.Point(15, 26);
            this.rdnBir.Name = "rdnBir";
            this.rdnBir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdnBir.Size = new System.Drawing.Size(31, 17);
            this.rdnBir.TabIndex = 0;
            this.rdnBir.TabStop = true;
            this.rdnBir.Text = "1";
            this.rdnBir.UseVisualStyleBackColor = true;
            // 
            // cmbGuncDepartman
            // 
            this.cmbGuncDepartman.FormattingEnabled = true;
            this.cmbGuncDepartman.Location = new System.Drawing.Point(140, 19);
            this.cmbGuncDepartman.Name = "cmbGuncDepartman";
            this.cmbGuncDepartman.Size = new System.Drawing.Size(121, 21);
            this.cmbGuncDepartman.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "DEPARTMAN";
            // 
            // txtGuncEPosta
            // 
            this.txtGuncEPosta.Location = new System.Drawing.Point(161, 329);
            this.txtGuncEPosta.Name = "txtGuncEPosta";
            this.txtGuncEPosta.Size = new System.Drawing.Size(123, 20);
            this.txtGuncEPosta.TabIndex = 29;
            // 
            // txtGuncAdres
            // 
            this.txtGuncAdres.Location = new System.Drawing.Point(161, 284);
            this.txtGuncAdres.Name = "txtGuncAdres";
            this.txtGuncAdres.Size = new System.Drawing.Size(123, 20);
            this.txtGuncAdres.TabIndex = 28;
            // 
            // txtGuncTel
            // 
            this.txtGuncTel.Location = new System.Drawing.Point(161, 244);
            this.txtGuncTel.Name = "txtGuncTel";
            this.txtGuncTel.Size = new System.Drawing.Size(123, 20);
            this.txtGuncTel.TabIndex = 27;
            // 
            // TxtGuncSoyad
            // 
            this.TxtGuncSoyad.Location = new System.Drawing.Point(161, 213);
            this.TxtGuncSoyad.Name = "TxtGuncSoyad";
            this.TxtGuncSoyad.Size = new System.Drawing.Size(123, 20);
            this.TxtGuncSoyad.TabIndex = 26;
            // 
            // TxtGuncAd
            // 
            this.TxtGuncAd.Location = new System.Drawing.Point(161, 176);
            this.TxtGuncAd.Name = "TxtGuncAd";
            this.TxtGuncAd.Size = new System.Drawing.Size(123, 20);
            this.TxtGuncAd.TabIndex = 25;
            // 
            // txtGuncTC
            // 
            this.txtGuncTC.Location = new System.Drawing.Point(161, 136);
            this.txtGuncTC.Name = "txtGuncTC";
            this.txtGuncTC.Size = new System.Drawing.Size(123, 20);
            this.txtGuncTC.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "E POSTA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ADRES :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "TELEFON :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "AD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "TC :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(20, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 261);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL KİŞİSEL BİLGİLER";
            // 
            // cmbGuncPer
            // 
            this.cmbGuncPer.FormattingEnabled = true;
            this.cmbGuncPer.Location = new System.Drawing.Point(221, 65);
            this.cmbGuncPer.Name = "cmbGuncPer";
            this.cmbGuncPer.Size = new System.Drawing.Size(288, 21);
            this.cmbGuncPer.TabIndex = 36;
            this.cmbGuncPer.SelectedIndexChanged += new System.EventHandler(this.cmbGuncPer_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "PERSONEL SEÇİNİZ :\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "POZISYON";
            // 
            // cmbGuncPoz
            // 
            this.cmbGuncPoz.FormattingEnabled = true;
            this.cmbGuncPoz.Location = new System.Drawing.Point(140, 47);
            this.cmbGuncPoz.Name = "cmbGuncPoz";
            this.cmbGuncPoz.Size = new System.Drawing.Size(121, 21);
            this.cmbGuncPoz.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Puan Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPerGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbGuncPer);
            this.Controls.Add(this.cmbPerGuncOtel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnPersonelGunc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtGuncEPosta);
            this.Controls.Add(this.txtGuncAdres);
            this.Controls.Add(this.txtGuncTel);
            this.Controls.Add(this.TxtGuncSoyad);
            this.Controls.Add(this.TxtGuncAd);
            this.Controls.Add(this.txtGuncTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPerGuncelle";
            this.Text = "frmPerGuncelle";
            this.Load += new System.EventHandler(this.frmPerGuncelle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPerGuncOtel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnPersonelGunc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdnBes;
        private System.Windows.Forms.RadioButton rdnDort;
        private System.Windows.Forms.RadioButton rdnUc;
        private System.Windows.Forms.RadioButton rdnIkı;
        private System.Windows.Forms.RadioButton rdnBir;
        private System.Windows.Forms.ComboBox cmbGuncDepartman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGuncEPosta;
        private System.Windows.Forms.TextBox txtGuncAdres;
        private System.Windows.Forms.TextBox txtGuncTel;
        private System.Windows.Forms.TextBox TxtGuncSoyad;
        private System.Windows.Forms.TextBox TxtGuncAd;
        private System.Windows.Forms.TextBox txtGuncTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGuncPer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbGuncPoz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}