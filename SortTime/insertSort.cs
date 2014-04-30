using System;
using System.Collections.Generic;
using System.Text;

namespace SortTime
{
    class InsertSort
    {

       
            public int[] DoInsertSort(int[] tab)
            {
                for (int i = 1; i < tab.Length; i++)
                {
                    int key = tab[i];
                    int j = i - 1;
                    while (j >= 0 && tab[j] > key)
                    {
                        tab[j + 1] = tab[j];
                        j--;
                    }
                    tab[j + 1] = key;
                }
                return tab;
            }
        


    }
}
