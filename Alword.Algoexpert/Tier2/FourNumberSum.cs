using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert
{
    public class FourNumberSum
    {
        public static List<int[]> Solve(int[] array, int targetSum)
        {
            Array.Sort<int>(array,
                    new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    ));
            List<int[]> results = new List<int[]>();
            Dictionary<int, List<int[]>> diffsPairs = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < array.Length;)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    var dif = targetSum - array[i] - array[j];
                    if (diffsPairs.ContainsKey(dif))
                    {
                        var pairs = diffsPairs[dif];
                        foreach (var pair in pairs)
                        {
                            var result = new int[pair.Length + 2];
                            pair.CopyTo(result, 0);
                            result[2] = array[i];
                            result[3] = array[j];
                            results.Add(result);
                        }
                    }
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    var dif = array[i] + array[j];
                    if (diffsPairs.ContainsKey(dif))
                    {
                        diffsPairs[dif].Add(new int[] { array[j], array[i] });
                    }
                    else
                    {
                        diffsPairs.Add(dif, new List<int[]> { new int[] { array[j], array[i] } });
                    }
                }
                i++;
            }
            return results;
        }
    }
}
