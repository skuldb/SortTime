using System;
using System.Collections.Generic;
using System.Text;

namespace SortTime
{
    class TabGen
    {

      //  private List<int> existList;
        private static Random random;
     private static  List<int>   existList = new List<int>();
       

        public static int[] SortedTab(int[] tabsort)
        {
            for(int i= 0; i<tabsort.Length;i++)
            {
                tabsort[i] = i;
            }
            return tabsort;
        }



       public static int[] ConverslySortedTab(int[] tabsort)
        {

           for(int i=0; i<tabsort.Length;i++)
           {
               tabsort[i] = tabsort.Length - i;
           }
           return tabsort;

        }



        public static  int[] RandomTab(int[] tab)
       {
           int size = tab.Length;
           random = new Random(Environment.TickCount);

           for (int i = 0; i < tab.Length; i++)
           {
               tab[i] = random.Next(1, size+1);
           }
           return tab;
       }



         public static int[] RandomTabNot(int[] tab)
       {
            int size = tab.Length;
            random = new Random(Environment.TickCount);

           GenerateNextNumber(size);
            for(int i=0; i<tab.Length; i++)
            {
                tab[i] = existList[i];
            }
            return tab;
       }
       public static List<int> GenerateNextNumber(int size )
       {
          
           random = new Random(Environment.TickCount);
           int next = 0;
           while (existList.Count < size) 
            {
                next = random.Next(1, size*10);
                if(existList.Contains(next)) 
                    continue;
                else    
                    existList.Add(next);
            }
           return existList;

             
       }


        
    }
}
