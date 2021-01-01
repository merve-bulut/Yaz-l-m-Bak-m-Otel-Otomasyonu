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
    public partial class frmOtelDeger : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public frmOtelDeger()
        {
            InitializeComponent();
        }
        IkiliAramaAgaci aramaAgaci;

        private void frmOtelDeger_Load(object sender, EventArgs e)
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
                    cmbOtelDeger.Items.Add(dr["otelismi"]);
                }
                dr.Close();
                bag.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (txtYorum.Text == null || (!rdnBir.Checked && !rdnIkı.Checked && !rdnUc.Checked && !rdnDort.Checked && !rdnBes.Checked) )
            {
                MessageBox.Show("Lütfen Yorum Giriniz.");
            }
            else
            {
                SQLiteConnection bag = new SQLiteConnection(connection);
                int puan = 0,id=0;
                try
                {
                    bag.Open();
                    string komut = @"SELECT id FROM otelbilgi WHERE otelismi=@p";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm = new SQLiteParameter("p", cmbOtelDeger.Text);
                    cmd.Parameters.Add(prm);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                        id = Int32.Parse(dr["id"].ToString());
                    komut = @"SELECT puan FROM degerlendirme WHERE otelid=@p";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm1 = new SQLiteParameter("p", id.ToString());
                    cmd.Parameters.Add(prm1);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                        puan = Int32.Parse(dr["puan"].ToString());
                    bag.Close();
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                if (rdnBir.Checked == true)
                {
                    puan += 1;
                } else if(rdnIkı.Checked == true)
                {
                    puan += 2;
                } else if(rdnUc.Checked == true)
                {
                    puan += 3;
                } else if(rdnDort.Checked == true)
                {
                    puan += 4;
                } else if(rdnBes.Checked == true)
                {
                    puan += 5;
                }
                try
                {
                    bag.Open();
                    string komut = @"UPDATE degerlendirme SET puan = '" + puan.ToString() + "' WHERE otelid="+id.ToString() ;
                    cmd = new SQLiteCommand(komut, bag);
                    cmd.ExecuteNonQuery();
                    bag.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void cmbOtelDeger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
