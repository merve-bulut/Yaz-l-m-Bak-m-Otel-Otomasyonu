namespace veriYapilariProjeOdevi
{
    partial class frmGuncelle
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
            this.comboOtelGuncel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOtelBilgi = new System.Windows.Forms.GroupBox();
            this.comboGuncIlce = new System.Windows.Forms.ComboBox();
            this.comboGuncSehir = new System.Windows.Forms.ComboBox();
            this.txtGuncOdaSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuncEPosta = new System.Windows.Forms.TextBox();
            this.txtGuncTelefon = new System.Windows.Forms.TextBox();
            this.txtGuncAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuncAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.grpOtelBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboOtelGuncel
            // 
            this.comboOtelGuncel.FormattingEnabled = true;
            this.comboOtelGuncel.Location = new System.Drawing.Point(293, 32);
            this.comboOtelGuncel.Name = "comboOtelGuncel";
            this.comboOtelGuncel.Size = new System.Drawing.Size(248, 21);
            this.comboOtelGuncel.TabIndex = 0;
            this.comboOtelGuncel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GÜNCELLEMEK İSTEDİĞİNİZ OTELİ SEÇİNİZ";
            // 
            // grpOtelBilgi
            // 
            this.grpOtelBilgi.Controls.Add(this.comboGuncIlce);
            this.grpOtelBilgi.Controls.Add(this.comboGuncSehir);
            this.grpOtelBilgi.Controls.Add(this.txtGuncOdaSayisi);
            this.grpOtelBilgi.Controls.Add(this.label5);
            this.grpOtelBilgi.Controls.Add(this.label6);
            this.grpOtelBilgi.Controls.Add(this.label7);
            this.grpOtelBilgi.Controls.Add(this.txtGuncEPosta);
            this.grpOtelBilgi.Controls.Add(this.txtGuncTelefon);
            this.grpOtelBilgi.Controls.Add(this.txtGuncAdres);
            this.grpOtelBilgi.Controls.Add(this.label4);
            this.grpOtelBilgi.Controls.Add(this.label3);
            this.grpOtelBilgi.Controls.Add(this.label2);
            this.grpOtelBilgi.Controls.Add(this.txtGuncAd);
            this.grpOtelBilgi.Controls.Add(this.label8);
            this.grpOtelBilgi.Location = new System.Drawing.Point(22, 72);
            this.grpOtelBilgi.Name = "grpOtelBilgi";
            this.grpOtelBilgi.Size = new System.Drawing.Size(534, 316);
            this.grpOtelBilgi.TabIndex = 2;
            this.grpOtelBilgi.TabStop = false;
            this.grpOtelBilgi.Text = "OTEL BİLGİLERİ";
            this.grpOtelBilgi.Enter += new System.EventHandler(this.grpOtelBilgi_Enter);
            // 
            // comboGuncIlce
            // 
            this.comboGuncIlce.FormattingEnabled = true;
            this.comboGuncIlce.Location = new System.Drawing.Point(248, 108);
            this.comboGuncIlce.Name = "comboGuncIlce";
            this.comboGuncIlce.Size = new System.Drawing.Size(140, 21);
            this.comboGuncIlce.TabIndex = 30;
            // 
            // comboGuncSehir
            // 
            this.comboGuncSehir.FormattingEnabled = true;
            this.comboGuncSehir.Location = new System.Drawing.Point(248, 72);
            this.comboGuncSehir.Name = "comboGuncSehir";
            this.comboGuncSehir.Size = new System.Drawing.Size(140, 21);
            this.comboGuncSehir.TabIndex = 29;
            this.comboGuncSehir.SelectedIndexChanged += new System.EventHandler(this.comboGuncSehir_SelectedIndexChanged);
            // 
            // txtGuncOdaSayisi
            // 
            this.txtGuncOdaSayisi.Location = new System.Drawing.Point(248, 268);
            this.txtGuncOdaSayisi.Name = "txtGuncOdaSayisi";
            this.txtGuncOdaSayisi.Size = new System.Drawing.Size(140, 20);
            this.txtGuncOdaSayisi.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "ODA SAYISI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "E POSTA :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "TELEFON : ";
            // 
            // txtGuncEPosta
            // 
            this.txtGuncEPosta.Location = new System.Drawing.Point(248, 230);
            this.txtGuncEPosta.Name = "txtGuncEPosta";
            this.txtGuncEPosta.Size = new System.Drawing.Size(140, 20);
            this.txtGuncEPosta.TabIndex = 24;
            // 
            // txtGuncTelefon
            // 
            this.txtGuncTelefon.Location = new System.Drawing.Point(248, 190);
            this.txtGuncTelefon.Name = "txtGuncTelefon";
            this.txtGuncTelefon.Size = new System.Drawing.Size(140, 20);
            this.txtGuncTelefon.TabIndex = 23;
            // 
            // txtGuncAdres
            // 
            this.txtGuncAdres.Location = new System.Drawing.Point(248, 145);
            this.txtGuncAdres.Name = "txtGuncAdres";
            this.txtGuncAdres.Size = new System.Drawing.Size(140, 20);
            this.txtGuncAdres.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ADRES :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "BULUNDUĞU İLÇE : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "BULUNDUĞU İL : ";
            // 
            // txtGuncAd
            // 
            this.txtGuncAd.Location = new System.Drawing.Point(248, 22);
            this.txtGuncAd.Name = "txtGuncAd";
            this.txtGuncAd.Size = new System.Drawing.Size(140, 20);
            this.txtGuncAd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "AD :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(284, 409);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(139, 409);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(116, 23);
            this.silBtn.TabIndex = 4;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // frmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 471);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.grpOtelBilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboOtelGuncel);
            this.Name = "frmGuncelle";
            this.Text = "frmGuncelle";
            this.Load += new System.EventHandler(this.frmGuncelle_Load);
            this.grpOtelBilgi.ResumeLayout(false);
            this.grpOtelBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboOtelGuncel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOtelBilgi;
        private System.Windows.Forms.TextBox txtGuncOdaSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGuncEPosta;
        private System.Windows.Forms.TextBox txtGuncTelefon;
        private System.Windows.Forms.TextBox txtGuncAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuncAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox comboGuncIlce;
        private System.Windows.Forms.ComboBox comboGuncSehir;
        private System.Windows.Forms.Button silBtn;
    }
}