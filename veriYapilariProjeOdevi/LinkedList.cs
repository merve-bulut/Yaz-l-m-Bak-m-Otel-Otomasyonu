using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class LinkedList : List
    {
        public override void PersonelEkle(Personel per)
        {
            Node tmpHead = new Node
            {
                Bilgi = per
            };

            if (Head == null)
            {
                Head = tmpHead;
            }

            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }

            Size++;
        }
        public override Node MaxPuanliPersonel()
        {
            throw new NotImplementedException();
        }


        public override string PersonelListele()
        {
            throw new NotImplementedException();
        }

        public override void PersonelSil()
        {
            throw new NotImplementedException();
        }
    }
}
