using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class SelectionSortTask
    {
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                swap(i, min, array);
            }
            return array;
        }

        private static void swap(int i, int j, int[] array)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
