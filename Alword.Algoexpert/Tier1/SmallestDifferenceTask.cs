using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class SmallestDifferenceTask
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int one = 0;
            int two = 0;
            var dif = Math.Abs(arrayTwo[0] - arrayOne[0]);
            var difone = one;
            var diftwo = two;

            while (one < arrayOne.Length && two < arrayTwo.Length)
            {
                var newDif = Math.Abs(arrayOne[one] - arrayTwo[two]);
                if (newDif < dif)
                {
                    dif = newDif;
                    difone = one;
                    diftwo = two;
                }
                if (arrayOne[one] < arrayTwo[two])
                {
                    one++;
                }
                else
                {
                    two++;
                }
            }

            return new int[] { arrayOne[difone], arrayTwo[diftwo] };
        }
    }
}
