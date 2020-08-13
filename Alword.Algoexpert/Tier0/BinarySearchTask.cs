using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class BinarySearchTask
    {
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (!(left > right))
            {
                int index = (left + right) / 2;
                if (target > array[index])
                    left = index + 1;
                else if (target < array[index])
                    right = index - 1;
                else
                    return index;
            }
            return -1;
        }
    }
}
