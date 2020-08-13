using Alword.Algoexpert.Tier0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests
{
    public class BinarySearchTest
    {
        [Fact]
        public static void TestSearchEven()
        {
            var array = new int[] { 1, 5, 23, 111 };
            var target = 111;
            var index = 3;
            Assert.Equal(index, BinarySearchTask.BinarySearch(array, target));
        }

        [Fact]
        public static void TestSearchOdd()
        {
            var array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            var target = 33;
            var index = 3;
            Assert.Equal(index, BinarySearchTask.BinarySearch(array, target));
        }
    }
}
