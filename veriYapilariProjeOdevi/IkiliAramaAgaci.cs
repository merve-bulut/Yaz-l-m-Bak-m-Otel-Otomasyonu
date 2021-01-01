using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilariProjeOdevi
{
    public class IkiliAramaAgaci
    {
        private IkiliAramaAgacDugumu kok; //İkili arama ağacı türünde oluşturulan kök
        private string dugumler; // Düğümleri yazdırmak için string türünde oluşturulan düğümler
        public IkiliAramaAgaci() //Parent düğümünün değerini tutmak için oluşturulan kurucu metot
        {
        }
        public IkiliAramaAgaci(IkiliAramaAgacDugumu kok) //Düğümlerin değerini tutmak için oluşturulan kurucu metot
        {
            this.kok = kok;
        }

        public void IsmeGoreOtelEkle(Otel otel)
        {
            IkiliAramaAgacDugumu tempParent = new IkiliAramaAgacDugumu();
            IkiliAramaAgacDugumu tempSearch = kok;
            IkiliAramaAgacDugumu eklenecekOtel = new IkiliAramaAgacDugumu(otel);
            if (kok == null)
            {
                kok = eklenecekOtel;
            }
            else
            {
                int sonuc = 0;
                while (tempSearch != null)
                {
                    tempParent = tempSearch;
                    sonuc = String.Compare(otel.Ad, tempSearch.veri.Ad);
                    if (Equals(otel.Ad, tempSearch.veri.Ad))
                    {
                        MessageBox.Show("Otel mevcut!");
                    }
                    else
                    {
                        if (sonuc < 0)
                        {
                            tempSearch = tempSearch.sol;
                        }
                        else
                        {
                            tempSearch = tempSearch.sag;
                        }
                    }
                }

                if (sonuc < 0)
                    tempParent.sol = eklenecekOtel;
                else
                    tempParent.sag = eklenecekOtel;
            }
            
        }

        private void Ziyaret(IkiliAramaAgacDugumu dugum)
        {
            dugumler += dugum.veri.Ad + " ";
        }

        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }

        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }

        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }

        public string DugumleriYazdir()
        {
            return dugumler;
        }

        public void PersonelEkle()
        {

        }

        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(IkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
    }
}
