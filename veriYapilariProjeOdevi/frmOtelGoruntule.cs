using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilariProjeOdevi
{
    public partial class frmOtelGoruntule : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public frmOtelGoruntule()
        {
            InitializeComponent();
        }
        IkiliAramaAgaci aramaAgaci;
        public int sehirid = 0, ilceid = 0;
        private void btnOtelGoruntule_Click(object sender, EventArgs e)
        {
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            { 
                bag.Open();
                
                string komut = @"SELECT * FROM otelbilgi";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    
                    lstBxTumOteller.Items.Add(dr["otelismi"].ToString());

                }
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
             
            
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            connection = @"Data Source =C:\Users\merve_l7t2av4\Desktop\Yeni klasör\otel.db;version=3";
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT * FROM otelbilgi";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                aramaAgaci = new IkiliAramaAgaci();
                while (dr.Read())
                {
                    
                    Otel ot = new Otel();
                    ot.Ad = dr["otelismi"].ToString();
                    aramaAgaci.IsmeGoreOtelEkle(ot);

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            switch (cmbAgacDuzeyi.SelectedIndex)
            {
                case 0:
                    aramaAgaci.PreOrder();
                    break;
                case 1:
                    aramaAgaci.InOrder();
                    break;
                case 2:
                    aramaAgaci.PostOrder();
                    break;
                default:
                    break;
            }
            MessageBox.Show(aramaAgaci.DugumleriYazdir().ToString());
        }

        private void btnAgacDerinligi_Click(object sender, EventArgs e)
        {

        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aramaAgaci.DugumSayisi().ToString());
        }

        private void btnSehreGoreSec_Click(object sender, EventArgs e)
        {
            frmIl_IlceyeGore sehir = new frmIl_IlceyeGore();
            sehir.Show();
            this.Hide();
        }

        private void frmOtelGoruntule_Load(object sender, EventArgs e)
        {
            connection = @"Data Source =C:\Users\merve_l7t2av4\Desktop\veriYapilari\Yeni klasör\otel.db;version=3";
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT * FROM otelbilgi";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aramaAgaci = new IkiliAramaAgaci();
                    Otel ot = new Otel();
                    ot.Ad = dr["otelismi"].ToString();
                    aramaAgaci.IsmeGoreOtelEkle(ot);
                    
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        
    }
}
