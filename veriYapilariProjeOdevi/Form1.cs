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
    public partial class frmIndex : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        
        public frmIndex()
        {
            InitializeComponent();
        }
        IkiliAramaAgaci agac = new IkiliAramaAgaci();
        LinkedList list = new LinkedList();

        private void btnYetkiliGirisi_Click(object sender, EventArgs e)
        {
            frmYetkiliGirisi yet = new frmYetkiliGirisi();
            yet.Show();
            this.Hide();
        }

        private void frmIndex_Load(object sender, EventArgs e)
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
                    Otel o = new Otel();
                    o.Ad = dr["otelismi"].ToString();
                    o.Il = dr["sehir"].ToString();
                    o.Ilce = dr["ilce"].ToString();
                    o.Adres = dr["adres"].ToString();
                    o.Telefon = dr["telefon"].ToString();
                    o.EPosta = dr["eposta"].ToString();
                    o.OdaSayisi = dr["odasayisi"].ToString();
                    agac.IsmeGoreOtelEkle(o);
                }  
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


            try
            {
                string komut = @"SELECT * FROM personel";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Personel pe = new Personel();
                    pe.TC = dr["tc"].ToString();
                    pe.Ad = dr["ad"].ToString();
                    pe.Soyad = dr["soyad"].ToString();
                    pe.Telefon = dr["telefon"].ToString();
                    pe.Adres = dr["adres"].ToString();
                    pe.EPosta = dr["eposta"].ToString();
                    //pe.Departman = Int32.Parse(dr["departman"].ToString());
                    //pe.Pozisyon = cmbPozisyon.Text;
                    //personel puan eklenecek
                    list.PersonelEkle(pe);
                    //otel id'si ve personel id'si aynı olmalı bu id'ye göre personel listesi otele eklenmeli.
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            frmOtelGoruntule fr = new frmOtelGoruntule();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOtelDeger fr = new frmOtelDeger();
            fr.Show();
            this.Hide();
        }
    }
}
