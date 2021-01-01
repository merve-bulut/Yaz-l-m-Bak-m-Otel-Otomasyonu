namespace veriYapilariProjeOdevi
{
    partial class frmIl_IlceyeGore
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
            this.btnPuan = new System.Windows.Forms.Button();
            this.btnOtelPuan = new System.Windows.Forms.Button();
            this.lstBxOteller = new System.Windows.Forms.ListBox();
            this.cmbGorilce = new System.Windows.Forms.ComboBox();
            this.cmbGorSehir = new System.Windows.Forms.ComboBox();
            this.btnSehreGore = new System.Windows.Forms.Button();
            this.grpSehir = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSehir.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPuan
            // 
            this.btnPuan.Location = new System.Drawing.Point(146, 138);
            this.btnPuan.Name = "btnPuan";
            this.btnPuan.Size = new System.Drawing.Size(136, 53);
            this.btnPuan.TabIndex = 0;
            this.btnPuan.Text = "PUANA GÖRE LİSTELE";
            this.btnPuan.UseVisualStyleBackColor = true;
            this.btnPuan.Click += new System.EventHandler(this.btnPuan_Click);
            // 
            // btnOtelPuan
            // 
            this.btnOtelPuan.Location = new System.Drawing.Point(127, 456);
            this.btnOtelPuan.Name = "btnOtelPuan";
            this.btnOtelPuan.Size = new System.Drawing.Size(174, 40);
            this.btnOtelPuan.TabIndex = 2;
            this.btnOtelPuan.Text = "OTELİ DEĞERLENDİR";
            this.btnOtelPuan.UseVisualStyleBackColor = true;
            this.btnOtelPuan.Click += new System.EventHandler(this.btnOtelPuan_Click);
            // 
            // lstBxOteller
            // 
            this.lstBxOteller.FormattingEnabled = true;
            this.lstBxOteller.Location = new System.Drawing.Point(109, 214);
            this.lstBxOteller.Name = "lstBxOteller";
            this.lstBxOteller.Size = new System.Drawing.Size(210, 225);
            this.lstBxOteller.TabIndex = 3;
            // 
            // cmbGorilce
            // 
            this.cmbGorilce.FormattingEnabled = true;
            this.cmbGorilce.Location = new System.Drawing.Point(155, 52);
            this.cmbGorilce.Name = "cmbGorilce";
            this.cmbGorilce.Size = new System.Drawing.Size(121, 21);
            this.cmbGorilce.TabIndex = 7;
            // 
            // cmbGorSehir
            // 
            this.cmbGorSehir.FormattingEnabled = true;
            this.cmbGorSehir.Location = new System.Drawing.Point(6, 52);
            this.cmbGorSehir.Name = "cmbGorSehir";
            this.cmbGorSehir.Size = new System.Drawing.Size(121, 21);
            this.cmbGorSehir.TabIndex = 6;
            this.cmbGorSehir.SelectedIndexChanged += new System.EventHandler(this.cmbGorSehir_SelectedIndexChanged);
            // 
            // btnSehreGore
            // 
            this.btnSehreGore.Location = new System.Drawing.Point(300, 35);
            this.btnSehreGore.Name = "btnSehreGore";
            this.btnSehreGore.Size = new System.Drawing.Size(109, 38);
            this.btnSehreGore.TabIndex = 5;
            this.btnSehreGore.Text = "GÖRÜNTÜLE";
            this.btnSehreGore.UseVisualStyleBackColor = true;
            this.btnSehreGore.Click += new System.EventHandler(this.btnSehreGore_Click);
            // 
            // grpSehir
            // 
            this.grpSehir.Controls.Add(this.label2);
            this.grpSehir.Controls.Add(this.label1);
            this.grpSehir.Controls.Add(this.btnSehreGore);
            this.grpSehir.Controls.Add(this.cmbGorilce);
            this.grpSehir.Controls.Add(this.cmbGorSehir);
            this.grpSehir.Location = new System.Drawing.Point(25, 27);
            this.grpSehir.Name = "grpSehir";
            this.grpSehir.Size = new System.Drawing.Size(415, 90);
            this.grpSehir.TabIndex = 8;
            this.grpSehir.TabStop = false;
            this.grpSehir.Text = "İL VE İLÇEYE GÖRE ARAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "İLÇE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "İL";
            // 
            // frmIl_IlceyeGore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 508);
            this.Controls.Add(this.grpSehir);
            this.Controls.Add(this.lstBxOteller);
            this.Controls.Add(this.btnOtelPuan);
            this.Controls.Add(this.btnPuan);
            this.Name = "frmIl_IlceyeGore";
            this.Text = "frmIl_IlceyeGore";
            this.Load += new System.EventHandler(this.frmIl_IlceyeGore_Load);
            this.grpSehir.ResumeLayout(false);
            this.grpSehir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPuan;
        private System.Windows.Forms.Button btnOtelPuan;
        private System.Windows.Forms.ListBox lstBxOteller;
        private System.Windows.Forms.ComboBox cmbGorilce;
        private System.Windows.Forms.ComboBox cmbGorSehir;
        private System.Windows.Forms.Button btnSehreGore;
        private System.Windows.Forms.GroupBox grpSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}