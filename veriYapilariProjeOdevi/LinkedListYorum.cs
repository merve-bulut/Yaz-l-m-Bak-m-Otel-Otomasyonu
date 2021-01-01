using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class LinkedListYorum : ListYorum
    {
        public override void Goruntule()
        {
            Node tmpHead = new Node
            {
               // Bilgi = per
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
    }
}
