using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class LongestPeakTask
    {
        public static int LongestPeak(int[] array)
        {
            int i = 0;
            int max = 0;
            while (i < array.Length - 1)
            {
                int current = 0;
                while (i < array.Length - 1 && array[i] < array[i + 1])
                {
                    i++;
                    current++;
                    if (i < array.Length - 1 && array[i] > array[i + 1])
                    {
                        while (i < array.Length - 1 && array[i] > array[i + 1])
                        {
                            i++;
                            current++;
                        }
                        if (max < current)
                        {
                            max = current + 1;
                            i--;
                        }
                        break;
                    }
                }
                i++;
            }

            return max;
        }
    }
}
