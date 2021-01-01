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
    public partial class frmPerGuncelle : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public frmPerGuncelle()
        {
            InitializeComponent();
        }

        private void btnPersonelGunc_Click(object sender, EventArgs e)
        {
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                string komut = @"UPDATE Personel SET tc=@p1,ad=@p2,soyad=@p3,telefon=@p4,adres=@p5,eposta=@p6,departmanid=@p7,pozisyonid=@p8";
                cmd = new SQLiteCommand(komut, bag);
                SQLiteParameter prm1 = new SQLiteParameter("p1", txtGuncTC.Text);
                SQLiteParameter prm2 = new SQLiteParameter("p2", TxtGuncAd.Text);
                SQLiteParameter prm3 = new SQLiteParameter("p3", TxtGuncSoyad.Text);
                SQLiteParameter prm4 = new SQLiteParameter("p4", txtGuncTel.Text);
                SQLiteParameter prm5 = new SQLiteParameter("p5", txtGuncAdres.Text);
                SQLiteParameter prm6 = new SQLiteParameter("p6", txtGuncEPosta.Text);
                SQLiteParameter prm7 = new SQLiteParameter("p7", (cmbGuncDepartman.SelectedIndex+1).ToString());
                SQLiteParameter prm8 = new SQLiteParameter("p8", (cmbGuncPoz.SelectedIndex+1).ToString());
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                cmd.Parameters.Add(prm3);
                cmd.Parameters.Add(prm4);
                cmd.Parameters.Add(prm5);
                cmd.Parameters.Add(prm6);
                cmd.Parameters.Add(prm7);
                cmd.Parameters.Add(prm8);
                int sonuc = 0;
                sonuc = cmd.ExecuteNonQuery();
                if (sonuc == 1)
                    MessageBox.Show("Basari Ile Güncellendi");
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void frmPerGuncelle_Load(object sender, EventArgs e)
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
                    cmbPerGuncOtel.Items.Add(dr["otelismi"]);
                }
                dr.Close();
                komut = @"SELECT isim FROM departman";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cmbGuncDepartman.Items.Add(dr["isim"]);
                }
                dr.Close();
                komut = @"SELECT psnisim FROM pozisyon";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cmbGuncPoz.Items.Add(dr["psnisim"]);
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void cmbPerGuncOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtGuncAd.Text = null;
            txtGuncAdres.Text = null;
            txtGuncEPosta.Text = null;
            TxtGuncSoyad.Text = null;
            txtGuncTC.Text = null;
            txtGuncTel.Text = null;
            cmbGuncPer.Text = null;
            cmbGuncPer.Items.Clear();
            cmbGuncPer.SelectedIndex = -1;
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                int otelid = 0;
                otelid = cmbPerGuncOtel.SelectedIndex + 1;
                string komut = @"SELECT ad FROM personel WHERE otelid =@p";
                cmd = new SQLiteCommand(komut, bag);
                SQLiteParameter prm = new SQLiteParameter("p", otelid.ToString());
                cmd.Parameters.Add(prm);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbGuncPer.Items.Add(dr["ad"]);
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void cmbGuncPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtGuncAd.Text = null;
            txtGuncAdres.Text = null;
            txtGuncEPosta.Text = null;
            TxtGuncSoyad.Text = null;
            txtGuncTC.Text = null;
            txtGuncTel.Text = null;
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                int perid = 0;
                perid = cmbPerGuncOtel.SelectedIndex + 1;
                string komut = @"SELECT * FROM Personel WHERE otelid=@p1 AND ad=@p2";
                cmd = new SQLiteCommand(komut, bag);
                SQLiteParameter prm1 = new SQLiteParameter("p1", (cmbPerGuncOtel.SelectedIndex + 1).ToString());
                SQLiteParameter prm2 = new SQLiteParameter("p2", cmbGuncPer.Text);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    TxtGuncAd.Text = dr["ad"].ToString();
                    txtGuncAdres.Text = dr["adres"].ToString();
                    txtGuncEPosta.Text = dr["eposta"].ToString();
                    TxtGuncSoyad.Text = dr["soyad"].ToString();
                    txtGuncTC.Text = dr["tc"].ToString();
                    txtGuncTel.Text = dr["telefon"].ToString();
                    cmbGuncDepartman.SelectedIndex = Int32.Parse(dr["departmanid"].ToString()) - 1;
                    cmbGuncPoz.SelectedIndex = Int32.Parse(dr["pozisyonid"].ToString()) - 1;
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                int sonuc = 0;
                bag.Open();
                string komut = @"DELETE FROM Personel WHERE tc=" + txtGuncTC.Text;
                cmd = new SQLiteCommand(komut, bag);
                sonuc = cmd.ExecuteNonQuery();
                if(sonuc == 1)
                {
                    TxtGuncAd.Text = null;
                    txtGuncAdres.Text = null;
                    txtGuncEPosta.Text = null;
                    TxtGuncSoyad.Text = null;
                    txtGuncTC.Text = null;
                    txtGuncTel.Text = null;
                    cmbGuncPer.Items.Clear();
                    cmbGuncPer.SelectedIndex = -1;
                }
                bag.Close();
                cmbPerGuncOtel.Text = null;
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmPerListele frm = new frmPerListele();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!rdnBir.Checked && !rdnIkı.Checked && !rdnUc.Checked && !rdnDort.Checked && !rdnBes.Checked)
            {
                MessageBox.Show("Puan Seçmelisiniz");
            } else
            {
                int puan = 0;
                SQLiteConnection bag = new SQLiteConnection(connection);
                try
                {
                    bag.Open();
                    string komut = @"SELECT puan FROM personel WHERE tc=" + txtGuncTC.Text;
                    cmd = new SQLiteCommand(komut, bag);
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        puan = Int32.Parse(dr["puan"].ToString());
                    }
                    dr.Close();
                    bag.Close();

                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                if (rdnBir.Checked == true)
                {
                    puan += 1;
                }
                else if (rdnIkı.Checked == true)
                {
                    puan += 2;
                }
                else if (rdnUc.Checked == true)
                {
                    puan += 3;
                }
                else if (rdnDort.Checked == true)
                {
                    puan += 4;
                }
                else if (rdnBes.Checked == true)
                {
                    puan += 5;
                }
                try
                {
                    int sonuc = 0;
                    bag.Open();
                    string komut = @"UPDATE Personel SET puan=" + puan.ToString() + " WHERE tc=" + txtGuncTC.Text;
                    cmd = new SQLiteCommand(komut, bag);
                    sonuc = cmd.ExecuteNonQuery();
                    if (sonuc == 1)
                        MessageBox.Show(TxtGuncAd.Text + " Adli Personelin Toplam Puanı : " + puan.ToString());
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }
    }
}
