using System;


namespace Alword.Algoexpert.Tier1
{
    public class MinNumberOfCoinsForChangeTask
    {
        public static int MinNumberOfCoinsForChange(int n, int[] denoms)
        {
            int[] counts = new int[n + 1];
            Array.Fill(counts, int.MaxValue - 1);
            counts[0] = 0;

            foreach (var denom in denoms)
            {
                for (int amount = denom; amount < n + 1; ++amount)
                {
                    counts[amount] = Math.Min(counts[amount], counts[amount - denom] + 1);
                }
            }
            return counts[n] == int.MaxValue - 1 ? -1 : counts[n];
        }
    }
}
