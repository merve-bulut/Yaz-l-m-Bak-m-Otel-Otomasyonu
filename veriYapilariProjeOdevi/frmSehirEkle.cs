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
    public partial class frmSehirEkle : Form
    {
        string connection;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmSehirEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {
                MessageBox.Show("Bir Şehir Seçiniz.");
            }
            else
            {
                SqlConnection bag = new SqlConnection(connection);
                try
                {
                    bag.Open();
                    int id = 0;
                    string komut = @"SELECT * FROM sehirler WHERE isim =@p";
                    cmd = new SqlCommand(komut, bag);
                    SqlParameter prm = new SqlParameter("p", comboBox1.Text);
                    cmd.Parameters.Add(prm);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = Int32.Parse(dr["id"].ToString());
                    }
                    komut = @"INSERT INTO ilceler (id,isim) VALUES('" + id + "','" + textBox2.Text + "' )";
                    cmd = new SqlCommand(komut, bag);
                    int sonuc = cmd.ExecuteNonQuery();
                    bag.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void frmSehirEkle_Load(object sender, EventArgs e)
        {
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\OtelDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection bag = new SqlConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT * FROM sehirler";
                cmd = new SqlCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    comboBox1.Items.Add(dr["isim"]);
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
