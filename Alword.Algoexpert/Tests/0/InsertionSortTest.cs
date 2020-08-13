using Alword.Algoexpert.Tier0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests
{
    public class InsertionSortTest
    {
        [Fact]
        public static void InsertionSort()
        {
            var array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            var expected = new int[] { 8, 5, 2, 9, 5, 6, 3 };
            Array.Sort(expected);
            var result = InsertionSortTask.InsertionSort(array);
            Assert.Equal(expected, array);
        }
    }
}
