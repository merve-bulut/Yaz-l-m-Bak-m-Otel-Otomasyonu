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
    public partial class frmSehirEkle : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
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
                SQLiteConnection bag = new SQLiteConnection(connection);
                try
                {
                    bag.Open();
                    int id = 0;
                    string komut = @"SELECT * FROM sehirler WHERE isim =@p";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm = new SQLiteParameter("p", comboBox1.Text);
                    cmd.Parameters.Add(prm);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = Int32.Parse(dr["id"].ToString());
                    }
                    komut = @"INSERT INTO ilceler (id,isim) VALUES('" + id + "','" + textBox2.Text + "' )";
                    cmd = new SQLiteCommand(komut, bag);
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
            connection = @"Data Source =C:\Users\merve_l7t2av4\Desktop\Yeni klasör\otel.db;version=3";
            SQLiteConnection bag = new SQLiteConnection(connection);
            try
            {
                bag.Open();
                string komut = @"SELECT * FROM sehirler";
                cmd = new SQLiteCommand(komut, bag);
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
