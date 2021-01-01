using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class HashDugum
    {
        private int sehir; //Hashing işlemi için kullanılacak anahtar değeri
        private int ilce; //Hashing işlemi için kullanılacak anahtar değeri
        private Otel deger; //Otel türündeki Değer nesnesi
        private HashDugum sag; //Heap için oluşturulan sağ referans
        private HashDugum sol; //Heap için oluşturulan sol referans

        public Otel Deger  //Otel değer ataması
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Sehir  //Anahtar değer ataması
        {
            get { return sehir; }
            set { sehir = value; }
        }
        public int Ilce
        {
            get { return ilce; }
            set { ilce = value; }
        }
        public HashDugum Sag //Sağ referansı değer ataması
        {
            get { return sag; }
            set { sag = value; }
        }

        public HashDugum Sol //Sol referansın değer ataması
        {
            get { return sol; }
            set { sol = value; }
        }
        
        public HashDugum(int sehir,int ilce, Otel deger) //Hash Düğüm ataması 
        {
            this.sehir = sehir;
            this.ilce = ilce;
            this.deger = deger;
            this.sag = null;
            this.sol = null;
        }
    }
}
