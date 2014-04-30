using System;
using System.Collections.Generic;
using System.Text;

namespace SortTime
{
    class BubbleSort
    {

        public int[] DoBubbleSort(int[]tab)
        {
        int temp = 0;

        for (int write = 0; write < tab.Length; write++)
        {
            for (int sort = 0; sort < tab.Length - 1; sort++)
            {
                if (tab[sort] > tab[sort + 1])
                {
                    temp = tab[sort + 1];
                    tab[sort + 1] = tab[sort];
                    tab[sort] = temp;
                }
            }
        }
        return tab;
        }
       


    }
}
