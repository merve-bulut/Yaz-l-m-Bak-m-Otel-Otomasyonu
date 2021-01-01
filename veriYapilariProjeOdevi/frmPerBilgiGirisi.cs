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
    public partial class frmPerBilgiGirisi : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public frmPerBilgiGirisi()
        {
            InitializeComponent();
        }
        

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            if (cmbPerOtel.Text == null)
            {
                MessageBox.Show("Bir Otel Seçiniz.");
            }
            else
            {
                SQLiteConnection bag = new SQLiteConnection(connection);
                try
                {
                    bag.Open();
                    int otelid = 0,departmanid = 0,pozisyonid = 0,puan=0;
                    otelid = cmbPerOtel.SelectedIndex + 1;
                    departmanid = cmbDepartman.SelectedIndex + 1;
                    pozisyonid = cmbPozisyon.SelectedIndex + 1;
                    string komut = @"INSERT INTO Personel (otelid,tc,ad,soyad,telefon,adres,eposta,departmanid,pozisyonid,puan) VALUES('" + otelid.ToString() + "','" + txtTC.Text + "','" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + txtTel.Text + "','" + txtAdres.Text + "','" + txtEPosta.Text + "','" + departmanid.ToString() + "','" + pozisyonid.ToString() + "','" + puan.ToString() + "')";
                    cmd = new SQLiteCommand(komut, bag);
                    int sonuc = cmd.ExecuteNonQuery();
                    bag.Close();
                    if (sonuc != 0)
                        MessageBox.Show("Başarı İle VeriTabanına Kaydedildi.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            //frmYetkiliGirisi f = new frmYetkiliGirisi();
            //f.Show();
            //this.Hide();
        }

        private void frmPerBilgiGirisi_Load(object sender, EventArgs e)
        {
            connection = @"Data Source =C:\Users\merve_l7t2av4\Desktop\veriYapilari\Yeni klasör\otel.db;version=3";
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT otelismi FROM otelbilgi ORDER BY otelismi";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbPerOtel.Items.Add(dr["otelismi"]);
                }
                dr.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void cmbPerOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepartman.Items.Clear();
            cmbPozisyon.Items.Clear();
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT * FROM departman";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbDepartman.Items.Add(dr["isim"]);
                }
                dr.Close();
                komut = @"SELECT * FROM pozisyon";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cmbPozisyon.Items.Add(dr["psnisim"]);
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
