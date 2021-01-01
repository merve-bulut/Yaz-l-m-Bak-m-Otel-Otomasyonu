using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilariProjeOdevi
{
    public partial class frmYetkiliGirisi : Form
    {
        public frmYetkiliGirisi()
        {
            InitializeComponent();
        }

        private void btnOtelEkle_Click(object sender, EventArgs e)
        {
            frmOtelEkle ekle = new frmOtelEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmGuncelle gunc = new frmGuncelle();
            gunc.Show();
            this.Hide();
        }

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            frmPerBilgiGirisi p = new frmPerBilgiGirisi();
            p.Show();
            this.Hide();
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            frmSehirEkle p = new frmSehirEkle();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPerGuncelle frm = new frmPerGuncelle();
            frm.Show();
            this.Hide();
        }

        private void frmYetkiliGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
