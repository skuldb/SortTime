using System;
using System.Collections.Generic;
using System.Text;

namespace SortTime
{
    class MergeSort
    {

        public int[] DoMergeSort(int[] a)
        {
            if (a.Length == 1)
                return a;
            int middle = a.Length / 2;
            int[] left = new int[middle];
            for (int i = 0; i < middle; i++)
            {
                left[i] = a[i];
            }
            int[] right = new int[a.Length - middle];
            for (int i = 0; i < a.Length - middle; i++)
            {
                right[i] = a[i + middle];
            }
            left = DoMergeSort(left);
            right = DoMergeSort(right);

            int leftptr = 0;
            int rightptr = 0;

            int[] sorted = new int[a.Length];
            for (int k = 0; k < a.Length; k++)
            {
                if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
                {
                    sorted[k] = left[leftptr];
                    leftptr++;
                }
                else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
                {
                    sorted[k] = right[rightptr];
                    rightptr++;
                }
            }
            return sorted;
        }
    }
}


