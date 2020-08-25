using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Alword.Algoexpert.Tier1
{
    public class NumberOfWaysToMakeChangeTask
    {
        public static int NumberOfWaysToMakeChange(int n, int[] denoms)
        {
            if (n == 0)
                return 1;
            else
                return Change(n, denoms);
        }

        public static int Change(int toChange, int[] denoms, int minId = 0)
        {
            if (minId >= denoms.Length) return 0;

            int count = Change(toChange, denoms, minId + 1);
            int times = 1;
            while (true)
            {
                var additionalChange = toChange - denoms[minId] * times;
                times += 1;
                if (additionalChange > 0)
                    count += Change(additionalChange, denoms, minId + 1);
                else if (additionalChange == 0)
                    count += 1;
                else
                    break;
            }
            return count;
        }

        public static int NumberOfWaysToMakeChangeIterative(int n, int[] denoms)
        {
            int[] ways = new int[n + 1];
            ways[0] = 1;
            foreach (var d in denoms)
            {
                for (int amount = 1; amount < n + 1; amount++)
                {
                    if (d <= amount)
                    {
                        ways[amount] += ways[amount - d];
                    }
                }
            }
            return ways[n];
        }
    }
}
