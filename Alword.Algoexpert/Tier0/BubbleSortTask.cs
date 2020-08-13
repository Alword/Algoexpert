using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class BubbleSortTask
    {
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    int k = j + 1;
                    if (array[j] > array[k])
                    {
                        isSorted = false;
                        (array[j], array[k]) = (array[k], array[j]);
                    }
                }
                if (isSorted)
                    break;
            }
            return array;
        }
    }
}
