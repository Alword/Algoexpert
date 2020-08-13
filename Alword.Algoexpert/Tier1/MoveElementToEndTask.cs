using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class MoveElementToEndTask
    {
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            int left = 0;
            int right = array.Count - 1;
            while (left < right)
            {
                while (array[right] == toMove && right > left)
                    right--;
                while (array[left] != toMove && right > left)
                    left++;

                var temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
            return array;
        }
    }
}
