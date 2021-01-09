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
    public partial class frmOtelDeger : Form
    {
        string connection;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmOtelDeger()
        {
            InitializeComponent();
        }
        IkiliAramaAgaci aramaAgaci;

        private void frmOtelDeger_Load(object sender, EventArgs e)
        {
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\OtelDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection bag = new SqlConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT otelismi FROM otelbilgi ORDER BY otelismi";
                cmd = new SqlCommand(komut, bag);
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
                SqlConnection bag = new SqlConnection(connection);
                int puan = 0,id=0;
                try
                {
                    bag.Open();
                    string komut = @"SELECT id FROM otelbilgi WHERE otelismi=@p";
                    cmd = new SqlCommand(komut, bag);
                    SqlParameter prm = new SqlParameter("p", cmbOtelDeger.Text);
                    cmd.Parameters.Add(prm);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                        id = Int32.Parse(dr["id"].ToString());
                    komut = @"SELECT puan FROM degerlendirme WHERE otelid=@p";
                    cmd = new SqlCommand(komut, bag);
                    SqlParameter prm1 = new SqlParameter("p", id.ToString());
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
                    cmd = new SqlCommand(komut, bag);
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
