namespace veriYapilariProjeOdevi
{
    partial class frmOtelGoruntule
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
            this.btnOtelGoruntule = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAgacDuzeyi = new System.Windows.Forms.ComboBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnAgacDerinligi = new System.Windows.Forms.Button();
            this.btnElemanSayisi = new System.Windows.Forms.Button();
            this.lstBxTumOteller = new System.Windows.Forms.ListBox();
            this.btnSehreGoreSec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOtelGoruntule
            // 
            this.btnOtelGoruntule.Location = new System.Drawing.Point(143, 12);
            this.btnOtelGoruntule.Name = "btnOtelGoruntule";
            this.btnOtelGoruntule.Size = new System.Drawing.Size(110, 38);
            this.btnOtelGoruntule.TabIndex = 0;
            this.btnOtelGoruntule.Text = "TÜM OTELLERİ GÖRÜNTÜLE";
            this.btnOtelGoruntule.UseVisualStyleBackColor = true;
            this.btnOtelGoruntule.Click += new System.EventHandler(this.btnOtelGoruntule_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAgacDuzeyi);
            this.groupBox1.Controls.Add(this.btnGoster);
            this.groupBox1.Location = new System.Drawing.Point(12, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AĞAÇ DÜZEYİNE GÖRE LİSTELEME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ağaç Düzeyi :";
            // 
            // cmbAgacDuzeyi
            // 
            this.cmbAgacDuzeyi.FormattingEnabled = true;
            this.cmbAgacDuzeyi.Items.AddRange(new object[] {
            "Preorder",
            "Inorder",
            "Postorder"});
            this.cmbAgacDuzeyi.Location = new System.Drawing.Point(112, 39);
            this.cmbAgacDuzeyi.Name = "cmbAgacDuzeyi";
            this.cmbAgacDuzeyi.Size = new System.Drawing.Size(152, 21);
            this.cmbAgacDuzeyi.TabIndex = 1;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(291, 29);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(109, 38);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnAgacDerinligi
            // 
            this.btnAgacDerinligi.Location = new System.Drawing.Point(57, 318);
            this.btnAgacDerinligi.Name = "btnAgacDerinligi";
            this.btnAgacDerinligi.Size = new System.Drawing.Size(119, 51);
            this.btnAgacDerinligi.TabIndex = 6;
            this.btnAgacDerinligi.Text = "AĞAÇ DERİNLİĞİ";
            this.btnAgacDerinligi.UseVisualStyleBackColor = true;
            this.btnAgacDerinligi.Click += new System.EventHandler(this.btnAgacDerinligi_Click);
            // 
            // btnElemanSayisi
            // 
            this.btnElemanSayisi.Location = new System.Drawing.Point(221, 318);
            this.btnElemanSayisi.Name = "btnElemanSayisi";
            this.btnElemanSayisi.Size = new System.Drawing.Size(119, 51);
            this.btnElemanSayisi.TabIndex = 7;
            this.btnElemanSayisi.Text = "OTEL SAYISI";
            this.btnElemanSayisi.UseVisualStyleBackColor = true;
            this.btnElemanSayisi.Click += new System.EventHandler(this.btnElemanSayisi_Click);
            // 
            // lstBxTumOteller
            // 
            this.lstBxTumOteller.FormattingEnabled = true;
            this.lstBxTumOteller.Location = new System.Drawing.Point(104, 56);
            this.lstBxTumOteller.Name = "lstBxTumOteller";
            this.lstBxTumOteller.Size = new System.Drawing.Size(172, 147);
            this.lstBxTumOteller.TabIndex = 8;
            // 
            // btnSehreGoreSec
            // 
            this.btnSehreGoreSec.Location = new System.Drawing.Point(324, 106);
            this.btnSehreGoreSec.Name = "btnSehreGoreSec";
            this.btnSehreGoreSec.Size = new System.Drawing.Size(75, 37);
            this.btnSehreGoreSec.TabIndex = 9;
            this.btnSehreGoreSec.Text = "ŞEHRE GÖRE SEÇ";
            this.btnSehreGoreSec.UseVisualStyleBackColor = true;
            this.btnSehreGoreSec.Click += new System.EventHandler(this.btnSehreGoreSec_Click);
            // 
            // frmOtelGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 381);
            this.Controls.Add(this.btnSehreGoreSec);
            this.Controls.Add(this.lstBxTumOteller);
            this.Controls.Add(this.btnElemanSayisi);
            this.Controls.Add(this.btnAgacDerinligi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOtelGoruntule);
            this.Name = "frmOtelGoruntule";
            this.Text = "frmOtelGoruntule";
            this.Load += new System.EventHandler(this.frmOtelGoruntule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtelGoruntule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAgacDuzeyi;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnAgacDerinligi;
        private System.Windows.Forms.Button btnElemanSayisi;
        private System.Windows.Forms.ListBox lstBxTumOteller;
        private System.Windows.Forms.Button btnSehreGoreSec;
    }
}