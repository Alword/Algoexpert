using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class ValidSubsequence
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int start = 0;
            while (array.Count - start >= sequence.Count)
            {
                int j = 0;
                for (int i = start++; i < array.Count; i++)
                {
                    if (array[i] == sequence[j])
                        j++;
                    if (j == sequence.Count)
                        return true;
                    if (j > sequence.Count)
                        break;
                }
                return j == sequence.Count;
            }
            return false;
        }
    }
}
