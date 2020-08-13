using Alword.Algoexpert.Tier0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests
{
    public class BubbleSortTest
    {
        [Fact]
        public static void SwapTest()
        {
            int[] array = new int[] { 1, 2, 3, 4 };

            (array[0], array[1]) = (array[1], array[0]);

            Assert.Equal(2, array[0]);
            Assert.Equal(1, array[1]);
        }
        [Fact]
        public static void SortTest()
        {
            int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            int[] sorted = new int[] { 2, 3, 5, 5, 6, 8, 9 };

            BubbleSortTask.BubbleSort(array);

            Assert.Equal(sorted, array);
        }
    }
}
