using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace veriYapilariProjeOdevi
{
    public partial class frmGuncelle : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public frmGuncelle()
        {
            InitializeComponent();
        }

        private void frmGuncelle_Load(object sender, EventArgs e)
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
                    comboOtelGuncel.Items.Add(dr["otelismi"]);
                }
                dr.Close();
                komut = @"SELECT isim FROM sehirler";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    comboGuncSehir.Items.Add(dr["isim"]);
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOtelGuncel.Text == null)
            {
                MessageBox.Show("Bir Otel Seçiniz.");
            }
            else
            {
                comboGuncIlce.Items.Clear();
                SQLiteConnection bag = new SQLiteConnection(connection);
                try
                {
                    bag.Open();
                    int ilceid = 0,sehirid = 0;
                    string komut = @"SELECT * FROM otelbilgi WHERE otelismi =@p";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm = new SQLiteParameter("p", comboOtelGuncel.Text);
                    cmd.Parameters.Add(prm);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtGuncAd.Text = dr["otelismi"].ToString();
                        txtGuncAdres.Text = dr["adres"].ToString();
                        txtGuncEPosta.Text = dr["eposta"].ToString();
                        sehirid = Int32.Parse(dr["sehir"].ToString());
                        ilceid = Int32.Parse(dr["ilce"].ToString());
                        txtGuncTelefon.Text = dr["telefon"].ToString();
                        txtGuncOdaSayisi.Text = dr["odasayisi"].ToString();
                    }
                    dr.Close();
                    komut = @"SELECT isim FROM ilceler WHERE id="+sehirid;
                    cmd = new SQLiteCommand(komut, bag);
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        comboGuncIlce.Items.Add(dr["isim"]); 
                    }
                    dr.Close();
                    bag.Close();
                    comboGuncSehir.SelectedIndex = sehirid - 1;
                    comboGuncIlce.SelectedIndex = ilceid - 1;
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc=0;
            if(comboOtelGuncel.Text == null)
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Oteli Seçiniz");
            } else if(txtGuncAd.Text == null || txtGuncAdres.Text == null || txtGuncEPosta.Text == null || txtGuncOdaSayisi.Text == null || txtGuncTelefon.Text == null || comboGuncSehir.Text == null || comboGuncIlce.Text == null)
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.");
            } else
            {
                SQLiteConnection bag = new SQLiteConnection(connection);
                try
                {
                    int sehirid = 0, ilceid = 0;
                    sehirid = comboGuncSehir.SelectedIndex + 1;
                    ilceid = comboGuncIlce.SelectedIndex + 1;
                    bag.Open();
                    string komut = @"UPDATE otelbilgi SET otelismi='" + txtGuncAd.Text + "',sehir='" + sehirid.ToString() + "',ilce='" + ilceid.ToString() + "',adres='" + txtGuncAdres.Text + "',telefon='" + txtGuncTelefon.Text + "',eposta='" + txtGuncEPosta.Text + "',odasayisi='" + txtGuncOdaSayisi.Text +  "' WHERE otelismi=@p";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm = new SQLiteParameter("p", comboOtelGuncel.Text);
                    cmd.Parameters.Add(prm);
                    sonuc = cmd.ExecuteNonQuery();
                    if(sonuc==1)
                    {
                        MessageBox.Show("Otel Başarı İle Güncellendi.");
                        comboOtelGuncel.Items.Clear();
                        comboGuncSehir.Items.Clear();
                        comboGuncIlce.Items.Clear();
                        comboOtelGuncel.Text = null;
                        comboGuncSehir.Text = null;
                        comboGuncIlce.Text = null;
                        comboOtelGuncel.SelectedIndex = -1;
                        comboGuncSehir.SelectedIndex = -1;
                        comboGuncIlce.SelectedIndex = -1;
                        txtGuncAd.Text = null;
                        txtGuncAdres.Text = null;
                        txtGuncEPosta.Text = null;
                        txtGuncOdaSayisi.Text = null;
                        txtGuncTelefon.Text = null;                        
                        frmGuncelle_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Güncellemede Beklenmeyen Bir Hata!!!");
                    }
                    bag.Close();
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void comboGuncSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                comboGuncIlce.Items.Clear();
                comboGuncIlce.Text = null;
                int sehirid = 0;
                sehirid = comboGuncSehir.SelectedIndex + 1;
                bag.Open();
                string komut = @"SELECT isim FROM ilceler WHERE id=@p";
                cmd = new SQLiteCommand(komut, bag);
                SQLiteParameter prm = new SQLiteParameter("p", sehirid.ToString());
                cmd.Parameters.Add(prm);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboGuncIlce.Items.Add(dr["isim"]);
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if(comboOtelGuncel.Text == null)
            {
                MessageBox.Show("Silmek istediğiniz oteli seçiniz.");
            } else
            {
                SQLiteConnection bag = new SQLiteConnection(connection);
                int sonuc = 0;
                try
                {
                    bag.Open();
                    string komut = @"DELETE FROM otelbilgi WHERE otelismi=@p";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm = new SQLiteParameter("p", comboOtelGuncel.Text);
                    cmd.Parameters.Add(prm);
                    sonuc = cmd.ExecuteNonQuery();
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Otel Başarı İle Silindi.");
                        comboOtelGuncel.Items.Clear();
                        comboGuncSehir.Items.Clear();
                        comboGuncIlce.Items.Clear();
                        comboOtelGuncel.Text = null;
                        comboGuncSehir.Text = null;
                        comboGuncIlce.Text = null;
                        comboOtelGuncel.SelectedIndex = -1;
                        comboGuncSehir.SelectedIndex = -1;
                        comboGuncIlce.SelectedIndex = -1;
                        txtGuncAd.Text = null;
                        txtGuncAdres.Text = null;
                        txtGuncEPosta.Text = null;
                        txtGuncOdaSayisi.Text = null;
                        txtGuncTelefon.Text = null;
                        frmGuncelle_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Silinmede Beklenmeyen Bir Hata!!!");
                    }
                    bag.Close();
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void grpOtelBilgi_Enter(object sender, EventArgs e)
        {

        }
    }
}
