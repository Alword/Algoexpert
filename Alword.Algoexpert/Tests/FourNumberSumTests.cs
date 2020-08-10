using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests
{
    public class FourNumberSumTests
    {
        [Fact]
        public void TestSum()
        {
            var array = new int[] { 7, 6, 4, -1, 1, 2 };
            var targetSum = 16;
            var results = FourNumberSum.Solve(array, targetSum);
        }
    }
}
