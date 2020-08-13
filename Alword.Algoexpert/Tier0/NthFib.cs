using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class NthFib
    {
        public static int GetNthFib(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;

            int first = 0;
            int second = 1;
            // 3
            for (int i = 1; i < n; i++)
            {
                var f = first;
                first += second;
                second = f;
            }
            return first;
        }
    }
}
