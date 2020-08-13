using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class ProductSumTask
    {
        public static int ProductSum(List<object> array)
        {
            // Write your code here.
            int sum = 0;
            int depth = 1;
            sum += Sum(array, depth);
            return sum;
        }

        private static int Sum(List<object> array, int depth)
        {
            int sum = 0;
            foreach (var obj in array)
            {
                if (obj is int value)
                {
                    sum += value;
                }
                else
                {
                    sum += Sum(obj as List<object>, depth + 1);
                }
            }
            return sum * depth;
        }
    }
}
