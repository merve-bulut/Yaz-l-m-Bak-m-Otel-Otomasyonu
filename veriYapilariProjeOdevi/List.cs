using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public abstract class List
    {
        public Node Head; //Node türünde oluşturulan Head referansı
        public int Size = 0; // Linked Listin boyutunu tutan Size değişkeni
        public abstract void PersonelEkle(Personel per); //Personel ekleme metodu
        public abstract void PersonelSil(); //Personel silme metodu
        public abstract Node MaxPuanliPersonel(); //En yüksek puanlı personeli görüntüleme metodu
        public abstract string PersonelListele(); //Personel listeleme metodu
    }
}
