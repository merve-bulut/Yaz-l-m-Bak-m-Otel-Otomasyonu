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
    public partial class frmPerListele : Form
    {
        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public frmPerListele()
        {
            InitializeComponent();
        }

        private void frmPerListele_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
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
                    comboBox1.Items.Add(dr["otelismi"]);
                }
                dr.Close();
                komut = @"SELECT isim FROM departman";
                cmd = new SQLiteCommand(komut, bag);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["isim"]);
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
            dataGridView1.Rows.Clear();
            comboBox2.Text = null;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {
                MessageBox.Show("Otel Seçiniz.");
            } else
            {
                dataGridView1.Rows.Clear();
                SQLiteConnection bag = new SQLiteConnection(connection);
                try
                {
                    bag.Open();
                    string komut = @"SELECT ad,soyad,puan FROM Personel WHERE otelid=@p1 AND departmanid=@p2 ORDER BY puan DESC";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm1 = new SQLiteParameter("p1", (comboBox1.SelectedIndex + 1).ToString());
                    SQLiteParameter prm2 = new SQLiteParameter("p2", (comboBox2.SelectedIndex + 1).ToString());
                    cmd.Parameters.Add(prm1);
                    cmd.Parameters.Add(prm2);
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        string[] row = new string[] { dr["ad"] + " " + dr["soyad"], dr["puan"].ToString() };
                        dataGridView1.Rows.Add(row);
                    }
                    dr.Close();
                    bag.Close();
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            int[,] dizi = new int[count,2];
            for (int i=0;i<count;i++)
            {
                dizi[i, 0] = i;
                SQLiteConnection bag = new SQLiteConnection(connection);
                try
                {
                    bag.Open();
                    string komut = @"SELECT puan FROM Personel WHERE otelid=@p1 AND departmanid=@p2";
                    cmd = new SQLiteCommand(komut, bag);
                    SQLiteParameter prm1 = new SQLiteParameter("p1", (comboBox1.SelectedIndex + 1).ToString());
                    SQLiteParameter prm2 = new SQLiteParameter("p2", (comboBox2.SelectedIndex + 1).ToString());
                    cmd.Parameters.Add(prm1);
                    cmd.Parameters.Add(prm2);
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        dizi[i, 1] = Int32.Parse(dr["puan"].ToString());
                    }
                    dr.Close();
                    bag.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
            for (int i = 0; i < count; i++)
            {
                for(int j = 0; j < count-1; j++)
                {
                    
                }
            }
        }
    }
}
