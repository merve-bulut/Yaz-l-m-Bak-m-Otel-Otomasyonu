using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class HeapDugumu
    {
        public Otel Deger { get; set; } //Otel türünde oluşturulan değer nesnesi
        public HeapDugumu(Otel o) //Otel değerini atamak için kullanılan kurucu metot
        {
            this.Deger = o;
        }
    }
}
