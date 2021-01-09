using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veriYapilariProjeOdevi
{
    public partial class frmOtelEkle : Form
    {
        string connection;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmOtelEkle()
        {
            InitializeComponent();
        }
        

        private void btnOtelEkle_Click(object sender, EventArgs e)
        {
            if (sehirListe.Text == null || ilceListe.Text == null)
            {
                MessageBox.Show("Sehir ve İlçe'yi Seçiniz");
            }
            else
            {
                
                SqlConnection bag = new SqlConnection(connection);
                try
                {
                    bag.Open();
                    string komut = @"INSERT INTO otelbilgi (otelismi,sehir,ilce,adres,telefon,eposta,odasayisi) VALUES('" + txtOtelAd.Text + "','" + sehirListe.Text + "','" + ilceListe.Text + "','" + txtAdres.Text + "','" + txtTelefon.Text + "','" + txtEPosta.Text + "','" + txtOdaSayisi.Text + "')";
                    cmd = new SqlCommand(komut, bag);
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmPerBilgiGirisi g = new frmPerBilgiGirisi();
            g.Show();
            this.Hide();
        }

        private void frmOtelEkle_Load(object sender, EventArgs e)
        {
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\OtelDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection bag = new SqlConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT * FROM sehirler";
                cmd = new SqlCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sehirListe.Items.Add(dr["isim"]);
                }
                dr.Close();
                bag.Close();
              
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void sehirListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceListe.Items.Clear();
            SqlConnection bag = new SqlConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT isim FROM ilceler WHERE id=@p";
                cmd = new SqlCommand(komut, bag);
                SqlParameter prm = new SqlParameter("p", sehirListe.SelectedIndex + 1);
                cmd.Parameters.Add(prm);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ilceListe.Items.Add(dr["isim"]);
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
