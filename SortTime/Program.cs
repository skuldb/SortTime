using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace SortTime
{
    class Program
    {

        static void Main(string[] args)
        {
           /* int[] tabsort1;
            int totalSize = 30;
            TabGen tabGen = new TabGen();
            tabsort1 = new int[totalSize];

            TabGen.RandomTab(tabsort1);
            for (int i = 0; i < totalSize; i++)
            {
                Console.WriteLine(tabsort1[i]);

            }
            Console.ReadLine();

              HeapSort heapSort = new HeapSort(totalSize);
              heapSort.DoHeapSort(tabsort1);
             
            for (int i = 0; i < totalSize; i++)
            {
                Console.WriteLine(tabsort1[i]);

            }
            Console.ReadLine();*/

            Thread watek = new Thread(Czasy, 100000000);

            watek.Start(); 

        }
                        
         static void Czasy()
         {

             TabGen tabGen = new TabGen();
                             
             int[] tabsort1;
             double time = 0;
             double avg = 0;

             int totalSize = 0;
             int tryNum = 0;
             string powt, tryNumStr, totalSizeStr, timeStr;
         
             do
             {
                 Console.WriteLine("Podaj wielkość tablicy do sortowania:");
                 
                 totalSizeStr = Console.ReadLine();
                 try
                 {
                     totalSize = Convert.ToInt32(totalSizeStr);
                 }

                 catch (Exception e)
                 {
                     Console.WriteLine("Podaj ilość większą od 0!!");
                 }
             } while (totalSize < 1);

             do
             {
                 Console.WriteLine("Podaj ilość prób:");
                 
                 tryNumStr = Console.ReadLine();

                 try
                 {
                    tryNum = Convert.ToInt32(tryNumStr);
                 }
                 catch (Exception e)
                 {
                     Console.WriteLine("Podaj ilość większą od 0!!");
                 }

                     
             } while (tryNum < 1);       
                 
                 
                 
              do
              {

                  Console.WriteLine("Czy generować tablice losową bez powtórzeń?(T/N");
                  powt = Console.ReadLine();

                  powt = powt.ToLower();

              } while (powt != "n" && powt != "t");

              System.Diagnostics.Stopwatch clock = new System.Diagnostics.Stopwatch();

              tabsort1 = new int[totalSize];
             // tabsort2 = new int[totalSize];
           //   tabsort3 = new int[totalSize];

              BubbleSort bubbleSort = new BubbleSort();
              QuickSort quickSort = new QuickSort();
              InsertSort insertSort = new InsertSort();
              MergeSort mergeSort = new MergeSort();
              HeapSort heapSort = new HeapSort(totalSize);



             //################################################################################//
             //                                 Insert sort                                    //
             //################################################################################//
             Console.WriteLine("Insert Sort:");
             Console.WriteLine("------------");
             Console.Write("Tablica posortowana:          ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.SortedTab(tabsort1);
                 clock.Start();

                 insertSort.DoInsertSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum)/1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica odwrotnie posortowana:");

             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.ConverslySortedTab(tabsort1);
                 clock.Start();

                 insertSort.DoInsertSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica Losowa:               ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.RandomTab(tabsort1);
                 clock.Start();

                 insertSort.DoInsertSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

           
             if(powt == "t")
             {
                             Console.Write("Tablica Losowa bez powtórzeń: ");
                                             
                         for (int i = 0; i < tryNum; i++)
                         {
                             TabGen.RandomTab(tabsort1);
                             clock.Start();

                             insertSort.DoInsertSort(tabsort1);

                             clock.Stop();
                             timeStr = clock.ElapsedMilliseconds.ToString();
                             time = Convert.ToInt32(timeStr);
                             clock.Reset();
                             avg = avg + time;
                             Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
                         }
                         avg = (avg / tryNum) / 1000;

                         Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
                         Console.WriteLine("");
                         avg = 0;
             }
             //################################################################################//
             //                                 Quick Sort                                     //
             //################################################################################//
             Console.WriteLine("Quick Sort:");
             Console.WriteLine("------------");
             Console.Write("Tablica posortowana:          ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.SortedTab(tabsort1);
                 clock.Start();

                 quickSort.DoQuicksort(tabsort1,0,totalSize-1);
                 

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica odwrotnie posortowana:");

             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.ConverslySortedTab(tabsort1);
                 clock.Start();

                 quickSort.DoQuicksort(tabsort1, 0, totalSize - 1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica Losowa:               ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.RandomTab(tabsort1);
                 clock.Start();

                 quickSort.DoQuicksort(tabsort1, 0, totalSize - 1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;


             if (powt == "t")
             {
                 Console.Write("Tablica Losowa bez powtórzeń: ");
                                
                 for (int i = 0; i < tryNum; i++)
                 {
                     TabGen.RandomTab(tabsort1);
                     clock.Start();

                     quickSort.DoQuicksort(tabsort1, 0, totalSize - 1);

                     clock.Stop();
                     timeStr = clock.ElapsedMilliseconds.ToString();
                     time = Convert.ToInt32(timeStr);
                     clock.Reset();
                     avg = avg + time;
                     Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
                 }
                 avg = (avg / tryNum) / 1000;

                 Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
                 Console.WriteLine("");
                 avg = 0;
             }


             //################################################################################//
             //                                 Merge Sort                                     //
             //################################################################################//
             Console.WriteLine("Merge Sort:");
             Console.WriteLine("------------");
             Console.Write("Tablica posortowana:          ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.SortedTab(tabsort1);
                 clock.Start();

                 mergeSort.DoMergeSort(tabsort1);
               

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica odwrotnie posortowana:");

             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.ConverslySortedTab(tabsort1);
                 clock.Start();

                 mergeSort.DoMergeSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica Losowa:               ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.RandomTab(tabsort1);
                 clock.Start();

                 mergeSort.DoMergeSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;


             if (powt == "t")
             {
                 Console.Write("Tablica Losowa bez powtórzeń: ");
                                
                 for (int i = 0; i < tryNum; i++)
                 {
                     TabGen.RandomTab(tabsort1);
                     clock.Start();

                     mergeSort.DoMergeSort(tabsort1);

                     clock.Stop();
                     timeStr = clock.ElapsedMilliseconds.ToString();
                     time = Convert.ToInt32(timeStr);
                     clock.Reset();
                     avg = avg + time;
                     Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
                 }
                 avg = (avg / tryNum) / 1000;

                 Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
                 Console.WriteLine("");
                 avg = 0;
             }
             //################################################################################//
             //                                 Heap Sort                                     //
             //################################################################################//
             Console.WriteLine("Heap Sort:");
             Console.WriteLine("------------");
             Console.Write("Tablica posortowana:          ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.SortedTab(tabsort1);
                 clock.Start();

                 heapSort.DoHeapSort(tabsort1);


                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica odwrotnie posortowana:");

             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.ConverslySortedTab(tabsort1);
                 clock.Start();

                 heapSort.DoHeapSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica Losowa:               ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.RandomTab(tabsort1);
                 clock.Start();

                 heapSort.DoHeapSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;


             if (powt == "t")
             {
                 Console.Write("Tablica Losowa bez powtórzeń: ");

                 for (int i = 0; i < tryNum; i++)
                 {
                     TabGen.RandomTab(tabsort1);
                     clock.Start();

                     heapSort.DoHeapSort(tabsort1);

                     clock.Stop();
                     timeStr = clock.ElapsedMilliseconds.ToString();
                     time = Convert.ToInt32(timeStr);
                     clock.Reset();
                     avg = avg + time;
                     Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
                 }
                 avg = (avg / tryNum) / 1000;

                 Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
                 Console.WriteLine("");
                 avg = 0;
             }
             //################################################################################//
             //                                 bubble Sort                                     //
             //################################################################################//
             Console.WriteLine("Bubble Sort:");
             Console.WriteLine("------------");
             Console.Write("Tablica posortowana:          ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.SortedTab(tabsort1);
                 clock.Start();

                 bubbleSort.DoBubbleSort(tabsort1);
                 

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica odwrotnie posortowana:");

             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.ConverslySortedTab(tabsort1);
                 clock.Start();

                 bubbleSort.DoBubbleSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;

             Console.Write("Tablica Losowa:               ");
                            
             for (int i = 0; i < tryNum; i++)
             {
                 TabGen.RandomTab(tabsort1);
                 clock.Start();

                 bubbleSort.DoBubbleSort(tabsort1);

                 clock.Stop();
                 timeStr = clock.ElapsedMilliseconds.ToString();
                 time = Convert.ToInt32(timeStr);
                 clock.Reset();
                 avg = avg + time;
                 Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
             }
             avg = (avg / tryNum) / 1000;

             Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
             Console.WriteLine("");
             avg = 0;


             if (powt == "t")
             {
                 Console.Write("Tablica Losowa bez powtórzeń: ");

                 for (int i = 0; i < tryNum; i++)
                 {
                     TabGen.RandomTab(tabsort1);
                     clock.Start();

                     bubbleSort.DoBubbleSort(tabsort1);

                     clock.Stop();
                     timeStr = clock.ElapsedMilliseconds.ToString();
                     time = Convert.ToInt32(timeStr);
                     clock.Reset();
                     avg = avg + time;
                     Console.Write("    " + String.Format("{0:N4}", time / 1000) + " s");
                 }
                 avg = (avg / tryNum) / 1000;

                 Console.WriteLine("    czas średni: " + String.Format("{0:N4}", avg) + " s");
                 Console.WriteLine("");
                 avg = 0;
             }
             
             Console.ReadLine();


            
       }
    }
}

