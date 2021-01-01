using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class Node
    {
        public Personel Bilgi; //Personel türünde oluşturulan Bilgi nesnesi
        public Yorum YorumBilgi; //Yorum türünde oluşturulan YorumBilgi nesnesi
        public Node Next; //Node türünde oluşturulan Next referansı
    }
}
