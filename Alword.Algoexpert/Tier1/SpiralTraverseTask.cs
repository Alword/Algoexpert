using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier1
{
    public class SpiralTraverseTask
    {
        public static List<int> SpiralTraverse(int[,] array)
        {
            int n1 = 0;
            int n = array.GetLength(0);
            int m1 = 0;
            int m = array.GetLength(1);
            int total = m * n;
            List<int> result = new List<int>(total);

            m -= 1;
            n -= 1;
            while (result.Count < total)
            {
                for (int j = m1; j <= m; j++)
                {
                    result.Add(array[n1, j]);
                }
                for (int i = n1 + 1; i <= n; i++)
                {
                    result.Add(array[i, m]);
                }
                for (int j = m - 1; j >= m1; j--)
                {
                    if (n1 == n) break;
                    result.Add(array[n, j]);
                }
                for (int i = n - 1; i > n1; i--)
                {
                    if (m1 == m) break;
                    result.Add(array[i, m1]);
                }
                n1++;
                m1++;
                n--;
                m--;
            }
            return result;
        }
    }
}
