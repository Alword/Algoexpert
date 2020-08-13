using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class FindThreeLargestNumbersTask
    {
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            List<int> maxs = new List<int>(3) { array[0], array[1], array[2] };
            maxs.Sort();
            int min = maxs[0];
            for (int i = 3; i < array.Length; i++)
            {
                if (array[i] > min)
                {
                    maxs.RemoveAt(0);
                    if (array[i] > maxs[0] || array[i] > maxs[1])
                    {
                        if (array[i] > maxs[1])
                            maxs.Add(array[i]);
                        else
                            maxs.Insert(1, array[i]);
                    }
                    else
                        maxs.Insert(0, array[i]);
                    
                    min = maxs[0];
                }
            }
            return maxs.ToArray();
        }
    }
}
