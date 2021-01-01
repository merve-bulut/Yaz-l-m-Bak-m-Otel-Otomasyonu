namespace veriYapilariProjeOdevi
{
    partial class frmIndex
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYetkiliGirisi = new System.Windows.Forms.Button();
            this.btnMusteriGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYetkiliGirisi
            // 
            this.btnYetkiliGirisi.Location = new System.Drawing.Point(23, 48);
            this.btnYetkiliGirisi.Name = "btnYetkiliGirisi";
            this.btnYetkiliGirisi.Size = new System.Drawing.Size(172, 57);
            this.btnYetkiliGirisi.TabIndex = 1;
            this.btnYetkiliGirisi.Text = "Yetkili Girişi";
            this.btnYetkiliGirisi.UseVisualStyleBackColor = true;
            this.btnYetkiliGirisi.Click += new System.EventHandler(this.btnYetkiliGirisi_Click);
            // 
            // btnMusteriGirisi
            // 
            this.btnMusteriGirisi.Location = new System.Drawing.Point(23, 162);
            this.btnMusteriGirisi.Name = "btnMusteriGirisi";
            this.btnMusteriGirisi.Size = new System.Drawing.Size(172, 58);
            this.btnMusteriGirisi.TabIndex = 2;
            this.btnMusteriGirisi.Text = "Müşteri Girişi";
            this.btnMusteriGirisi.UseVisualStyleBackColor = true;
            this.btnMusteriGirisi.Click += new System.EventHandler(this.btnMusteriGirisi_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 270);
            this.Controls.Add(this.btnMusteriGirisi);
            this.Controls.Add(this.btnYetkiliGirisi);
            this.Name = "frmIndex";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYetkiliGirisi;
        private System.Windows.Forms.Button btnMusteriGirisi;
    }
}

