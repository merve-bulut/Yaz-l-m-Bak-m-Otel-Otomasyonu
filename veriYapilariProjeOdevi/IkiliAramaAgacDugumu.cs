using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class IkiliAramaAgacDugumu
    {
        public Otel veri; //Otel türünde oluşturulan veri nesnesi
        public IkiliAramaAgacDugumu sol; //İkili arama ağacının sol referansı
        public IkiliAramaAgacDugumu sag; //İkili arama ağacının sağ referansı
        public LinkedList personelList; //Linked List türündeki personel nesnesi
        public LinkedList yorumList; //Linked List türündeki yorum nesnesi
        public IkiliAramaAgacDugumu() //Parent için oluşturulan kurucu metot
        {
        }


        public IkiliAramaAgacDugumu(Otel veri) //Düğümler için oluşturulan kurucu metot
        {
            yorumList = new LinkedList(); 
            personelList = new LinkedList();
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}
