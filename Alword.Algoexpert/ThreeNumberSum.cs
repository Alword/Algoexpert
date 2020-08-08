using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert
{
    public class ThreeNumberSum
    {
        //O(n^2) time | O(n) space
        public static List<int[]> Solve(int[] array, int targetSum)
        {
            Array.Sort(array);
            List<int[]> results = new List<int[]>();
            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;
                while (left < right)
                {
                    int sum = array[i] + array[left] + array[right];
                    if (sum == targetSum)
                    {
                        int[] result = new int[] { i, left, right };
                        results.Add(result);
                    }
                    else if (sum < targetSum)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return results;
        }
    }
}
