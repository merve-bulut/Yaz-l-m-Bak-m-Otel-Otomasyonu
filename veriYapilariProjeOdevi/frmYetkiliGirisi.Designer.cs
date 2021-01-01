namespace veriYapilariProjeOdevi
{
    partial class frmYetkiliGirisi
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
            this.btnOtelEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnPerEkle = new System.Windows.Forms.Button();
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtelEkle
            // 
            this.btnOtelEkle.Location = new System.Drawing.Point(44, 39);
            this.btnOtelEkle.Name = "btnOtelEkle";
            this.btnOtelEkle.Size = new System.Drawing.Size(113, 35);
            this.btnOtelEkle.TabIndex = 0;
            this.btnOtelEkle.Text = "YENİ OTEL EKLE";
            this.btnOtelEkle.UseVisualStyleBackColor = true;
            this.btnOtelEkle.Click += new System.EventHandler(this.btnOtelEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(44, 107);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(113, 55);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "OTEL BİLGİ GÜNCELLE / SİL";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnPerEkle
            // 
            this.btnPerEkle.Location = new System.Drawing.Point(44, 195);
            this.btnPerEkle.Name = "btnPerEkle";
            this.btnPerEkle.Size = new System.Drawing.Size(113, 45);
            this.btnPerEkle.TabIndex = 2;
            this.btnPerEkle.Text = "PERSONEL EKLE";
            this.btnPerEkle.UseVisualStyleBackColor = true;
            this.btnPerEkle.Click += new System.EventHandler(this.btnPerEkle_Click);
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.Location = new System.Drawing.Point(44, 370);
            this.btnSehirEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(113, 42);
            this.btnSehirEkle.TabIndex = 3;
            this.btnSehirEkle.Text = "Şehir Ekle";
            this.btnSehirEkle.UseVisualStyleBackColor = true;
            this.btnSehirEkle.Click += new System.EventHandler(this.btnSehirEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "PERSONEL GÜNCELLE / SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmYetkiliGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSehirEkle);
            this.Controls.Add(this.btnPerEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnOtelEkle);
            this.Name = "frmYetkiliGirisi";
            this.Text = "frmYetkiliGirisi";
            this.Load += new System.EventHandler(this.frmYetkiliGirisi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtelEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnPerEkle;
        private System.Windows.Forms.Button btnSehirEkle;
        private System.Windows.Forms.Button button1;
    }
}