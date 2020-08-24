using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class MaxSubsetSumNoAdjacentTask
    {
        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            if (array.Length == 0)
                return 0;
            if (array.Length == 1)
                return array[0];

            int first = array[0];
            int second = Math.Max(array[0], array[1]);
            for (int i = 2; i < array.Length; ++i)
            {
                var temp = Math.Max(array[i] + first, second);
                first = second;
                second = temp;
            }
            return second;
        }
    }
}
