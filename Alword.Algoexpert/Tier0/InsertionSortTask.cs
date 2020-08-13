using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class InsertionSortTask
    {
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        var temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return array;
        }
    }
}
