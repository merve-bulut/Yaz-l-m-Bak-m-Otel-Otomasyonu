using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public abstract class ListYorum
    {
        public Node Head; //Node türünde oluşturulan Head referansı
        public int Size = 0; // Linked Listin boyutunu tutan Size değişkeni
        public abstract void Goruntule(); //Yorumları görüntüleme metodu
    }
}
