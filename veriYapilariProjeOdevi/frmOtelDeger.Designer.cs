namespace veriYapilariProjeOdevi
{
    partial class frmOtelDeger
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
            this.cmbOtelDeger = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnBes = new System.Windows.Forms.RadioButton();
            this.rdnDort = new System.Windows.Forms.RadioButton();
            this.rdnUc = new System.Windows.Forms.RadioButton();
            this.rdnIkı = new System.Windows.Forms.RadioButton();
            this.rdnBir = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOtelDeger
            // 
            this.cmbOtelDeger.FormattingEnabled = true;
            this.cmbOtelDeger.Location = new System.Drawing.Point(468, 75);
            this.cmbOtelDeger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOtelDeger.Name = "cmbOtelDeger";
            this.cmbOtelDeger.Size = new System.Drawing.Size(277, 24);
            this.cmbOtelDeger.TabIndex = 0;
            this.cmbOtelDeger.SelectedIndexChanged += new System.EventHandler(this.cmbOtelDeger_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEĞERLENDİRMEK İSTEDİĞİNİZ OTELİ  SEÇİNİZ :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnBes);
            this.groupBox1.Controls.Add(this.rdnDort);
            this.groupBox1.Controls.Add(this.rdnUc);
            this.groupBox1.Controls.Add(this.rdnIkı);
            this.groupBox1.Controls.Add(this.rdnBir);
            this.groupBox1.Location = new System.Drawing.Point(103, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(141, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PUAN VER";
            // 
            // rdnBes
            // 
            this.rdnBes.AutoSize = true;
            this.rdnBes.Location = new System.Drawing.Point(25, 151);
            this.rdnBes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdnBes.Name = "rdnBes";
            this.rdnBes.Size = new System.Drawing.Size(37, 21);
            this.rdnBes.TabIndex = 9;
            this.rdnBes.TabStop = true;
            this.rdnBes.Text = "5";
            this.rdnBes.UseVisualStyleBackColor = true;
            // 
            // rdnDort
            // 
            this.rdnDort.AutoSize = true;
            this.rdnDort.Location = new System.Drawing.Point(25, 123);
            this.rdnDort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdnDort.Name = "rdnDort";
            this.rdnDort.Size = new System.Drawing.Size(37, 21);
            this.rdnDort.TabIndex = 8;
            this.rdnDort.TabStop = true;
            this.rdnDort.Text = "4";
            this.rdnDort.UseVisualStyleBackColor = true;
            // 
            // rdnUc
            // 
            this.rdnUc.AutoSize = true;
            this.rdnUc.Location = new System.Drawing.Point(25, 94);
            this.rdnUc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdnUc.Name = "rdnUc";
            this.rdnUc.Size = new System.Drawing.Size(37, 21);
            this.rdnUc.TabIndex = 7;
            this.rdnUc.TabStop = true;
            this.rdnUc.Text = "3";
            this.rdnUc.UseVisualStyleBackColor = true;
            // 
            // rdnIkı
            // 
            this.rdnIkı.AutoSize = true;
            this.rdnIkı.Location = new System.Drawing.Point(25, 65);
            this.rdnIkı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdnIkı.Name = "rdnIkı";
            this.rdnIkı.Size = new System.Drawing.Size(37, 21);
            this.rdnIkı.TabIndex = 6;
            this.rdnIkı.TabStop = true;
            this.rdnIkı.Text = "2";
            this.rdnIkı.UseVisualStyleBackColor = true;
            // 
            // rdnBir
            // 
            this.rdnBir.AutoSize = true;
            this.rdnBir.Location = new System.Drawing.Point(25, 37);
            this.rdnBir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdnBir.Name = "rdnBir";
            this.rdnBir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdnBir.Size = new System.Drawing.Size(37, 21);
            this.rdnBir.TabIndex = 5;
            this.rdnBir.TabStop = true;
            this.rdnBir.Text = "1";
            this.rdnBir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYorum);
            this.groupBox2.Location = new System.Drawing.Point(379, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(320, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YORUM YAP";
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(40, 49);
            this.txtYorum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(244, 141);
            this.txtYorum.TabIndex = 0;
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(257, 395);
            this.btnTamamla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(147, 41);
            this.btnTamamla.TabIndex = 4;
            this.btnTamamla.Text = "TAMAMLA";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // frmOtelDeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 469);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOtelDeger);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOtelDeger";
            this.Text = "frmOtelDegerlendirme";
            this.Load += new System.EventHandler(this.frmOtelDeger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOtelDeger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.RadioButton rdnBes;
        private System.Windows.Forms.RadioButton rdnDort;
        private System.Windows.Forms.RadioButton rdnUc;
        private System.Windows.Forms.RadioButton rdnIkı;
        private System.Windows.Forms.RadioButton rdnBir;
        private System.Windows.Forms.Button btnTamamla;
    }
}