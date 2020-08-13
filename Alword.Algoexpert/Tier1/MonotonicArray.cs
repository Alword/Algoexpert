using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class MonotonicArray
    {
        public static bool IsMonotonic(int[] array)
        {
            if (array.Length < 2)
                return true;

            bool isIncreasing = false;
            int k = -1;
            do
            {
                k += 1;
                isIncreasing = IsIncreasing(array[k], array[k + 1]);
            }
            while (k + 1 < array.Length - 1 && array[k] - array[k + 1] == 0);

            for (int i = k; i < array.Length - 1; i++)
            {
                if (array[i] - array[i + 1] == 0)
                    continue;

                if (isIncreasing != IsIncreasing(array[i], array[i + 1]))
                    return false;
            }
            return true;
        }

        private static bool IsIncreasing(int a, int b)
        {
            return b - a >= 0;
        }
    }
}
