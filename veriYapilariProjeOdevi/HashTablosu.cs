using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilariProjeOdevi
{
    public class HashTablosu
    {
        Otel ot;
        int TABLO_BOYUTU = 81;
        HashDugum[] tablo;

        public HashTablosu() //Hash Tablosuna veri ataması yapmak için kullanılacak Hash Tablosu kurucu metodu
        {
            tablo = new HashDugum[TABLO_BOYUTU];
            for (int i = 0; i < TABLO_BOYUTU; i++)
                tablo[i] = null;
        }

        string connection;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public void OtelEkle(int sehir,int ilce, Otel deger)
        {
            connection = @"Data Source =C:\Users\merve_l7t2av4\Desktop\veriYapilari\Yeni klasör\otel.db;version=3";
            
            ot = new Otel();
            HashDugum TempParent = new HashDugum(sehir,ilce, ot);
            int hash = (sehir % TABLO_BOYUTU);
            if (tablo[hash] == null)
                tablo[hash] = new HashDugum(sehir,ilce, deger);
            else
            {
                HashDugum eklenecek = tablo[hash];
                while (eklenecek.Sehir != sehir && eklenecek.Ilce != ilce)
                {
                    if (eklenecek.Sol == null)
                        eklenecek = eklenecek.Sol;
                    else
                        eklenecek = eklenecek.Sag;
                }

                if (eklenecek.Sehir == sehir && eklenecek.Ilce == ilce)
                    eklenecek.Deger = deger;
                else if (TempParent.Sol == null)
                    eklenecek.Sol = new HashDugum(sehir,ilce, deger);
                else
                    eklenecek.Sag = new HashDugum(sehir,ilce, deger);
            }
        }
    }
}
