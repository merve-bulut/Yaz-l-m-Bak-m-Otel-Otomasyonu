using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class Otel
    {
        public string Ad { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set;}
        public string EPosta { get; set; }
        public string OdaSayisi { get; set; }
        public string OdaTipi { get; set; }
        public int OtelPuani { get; set; }
        LinkedList perList = new LinkedList();
    }
}
