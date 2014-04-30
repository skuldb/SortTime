using System;
using System.Collections.Generic;
using System.Text;

namespace SortTime
{
    class HeapSort
    {

        private static int heapSize, tempSize;

        public HeapSort(int size)
        {
            heapSize = size - 1;
            tempSize = heapSize;
        }
       



        public int[] DoHeapSort(int[] tab)
        {
            BuildHeap(tab);
            for(int i = heapSize; i>=0; i--)
            {
                swap(tab, 0, i);
                heapSize--;
                Heapify(tab, 0);
            }
            heapSize = tempSize;
            return tab;
        }

        private static void BuildHeap(int[] tab)
        {
           

            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(tab, i);
            }
        }

        private static void Heapify(int[] tab, int i)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int largest = 0;
           
            if (l <= heapSize && tab[l] > tab[i])           
                largest = l;
            else
                largest = i;

            if (r <= heapSize && tab[r] > tab[largest])
                   largest = r;

            if (largest != i)
            {
                swap(tab, i, largest);
                Heapify(tab, largest);

            }
           
        }
        private static void swap(int[] tab, int a, int b)
        {
            int temp = tab[a];
                tab[a] = tab[b];
                tab[b] = temp;
        }

    }
}
