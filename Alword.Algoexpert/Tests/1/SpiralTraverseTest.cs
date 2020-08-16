using Alword.Algoexpert.Tier1;
using System;
using System.Linq;
using Xunit;

namespace Alword.Algoexpert.Tests._1
{
    public class SpiralTraverseTest
    {
        [Fact]
        public void QuickTest()
        {
            int[,] array = new int[,] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7 } };
            int[] expected = Enumerable.Range(1, 16).ToArray();
            Assert.Equal(expected, SpiralTraverseTask.SpiralTraverse(array));
        }
        [Fact]
        public void SingleElemTest()
        {
            int[,] array = new int[,] { { 1 }};
            int[] expected = Enumerable.Range(1, 1).ToArray();
            Assert.Equal(expected, SpiralTraverseTask.SpiralTraverse(array));
        }
    }
}
