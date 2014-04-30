using System;
using System.Collections.Generic;
using System.Text;

namespace SortTime
{
    class QuickSort
    {

        public int[] DoQuicksort(int[] tab, int low, int high)
        {
            int pivot_loc = 0;

            if (low < high)
            {
                pivot_loc = partition(tab, low, high);
                DoQuicksort(tab, low, pivot_loc - 1);
                DoQuicksort(tab, pivot_loc + 1, high);
            }
            return tab;
        
        }



        private int partition(int[] tab, int p, int r)
        {
            int X = tab[r];
            int i = p - 1;

            for (int j = p; j < r; j++)
            {
                if (tab[j] <= X)
                {
                    i++;
                    swap(tab, i, j);
                }
            }
            swap(tab, i + 1, r);
            return i + 1;
        }



        private void swap(int[] tab, int a, int b)
        {
            int temp;
            temp = tab[a];
            tab[a] = tab[b];
            tab[b] = temp;
        }



    }
}
