using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilariProjeOdevi
{
    public partial class frmIl_IlceyeGore : Form
    {
        string connection;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmIl_IlceyeGore()
        {
            InitializeComponent();
        }
        HashTablosu hashTablo = new HashTablosu();
        Heap heapAgac = new Heap(100);

        private void frmIl_IlceyeGore_Load(object sender, EventArgs e)
        {
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\OtelDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection bag = new SqlConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT isim FROM sehirler";
                cmd = new SqlCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbGorSehir.Items.Add(dr["isim"]);
                }
                dr.Close(); 
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void cmbGorSehir_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection bag = new SqlConnection(connection);
            try
            {
                int sehirid = 0;
                sehirid = cmbGorSehir.SelectedIndex + 1;
                bag.Open();
                string komut = @"SELECT isim FROM ilceler WHERE id=@p";
                cmd = new SqlCommand(komut, bag);
                SqlParameter prm = new SqlParameter("p", sehirid.ToString());
                cmd.Parameters.Add(prm);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbGorilce.Items.Add(dr["isim"]);
                }
                dr.Close();
                bag.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            
        }

        private void btnSehreGore_Click(object sender, EventArgs e)
        {
            if (cmbGorSehir.Text == null)
            {
                MessageBox.Show("Lütfen Şehir Seçiniz.");
            }
            else if (cmbGorilce.Text == null)
            {
                MessageBox.Show("Lütfen İlçe Seçiniz.");
            }
            else
            {
                SqlConnection bag = new SqlConnection(connection);
                lstBxOteller.Items.Clear();
                Otel o = new Otel();
                try
                {
                    bag.Open();
                    string komut = @"SELECT otelismi FROM otelbilgi WHERE sehir=@p1 AND ilce=@p2";
                    cmd = new SqlCommand(komut, bag);
                    SqlParameter prm2 = new SqlParameter("p1", (cmbGorSehir.SelectedIndex + 1).ToString());
                    SqlParameter prm3 = new SqlParameter("p2", (cmbGorilce.SelectedIndex + 1).ToString());
                    cmd.Parameters.Add(prm2);
                    cmd.Parameters.Add(prm3);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lstBxOteller.Items.Add(dr["otelismi"]);
                        o.Ad = dr["otelismi"].ToString();

                        hashTablo.OtelEkle(cmbGorSehir.SelectedIndex+1,cmbGorilce.SelectedIndex+1, o);
                        heapAgac.Ekle(o);
                    }
                 
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                
            }
        }

        private void btnPuan_Click(object sender, EventArgs e)
        {

        }

        private void btnOtelPuan_Click(object sender, EventArgs e)
        {
            frmOtelDeger frm = new frmOtelDeger();
            frm.Show();
            this.Hide();
        }
    }
}
