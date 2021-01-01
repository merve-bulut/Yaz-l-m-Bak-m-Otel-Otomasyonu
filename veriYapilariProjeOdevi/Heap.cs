using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapilariProjeOdevi
{
    public class Heap
    {
        private HeapDugumu[] heapArray; //Heap türündeki Heap dizisi
        private int maxSize; //Heap dizisine eklenecek boyutu tutan maxSize değişkeni
        private int currentSize; // Heap'in içinde bulunan eleman sayısını gösteren currentSize değişkeni
        Otel o = new Otel(); //Otel türündeki o nesnesi
        public Heap(int maxHeapSize) //Heap dizisine max değer ataması yapan kurucu metot
        {
            maxSize = maxHeapSize;
            heapArray = new HeapDugumu[maxSize];
            currentSize = 0;

        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Ekle(Otel otel)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(otel);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].Deger.OtelPuani < bottom.Deger.OtelPuani)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax() // Remove maximum value HeapDugumu
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].Deger.OtelPuani < heapArray[rightChild].Deger.OtelPuani)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.Deger.OtelPuani >= heapArray[largerChild].Deger.OtelPuani)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
    }
}
