using Alword.Algoexpert.Tier1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests._1
{
    public class LongestPeakTest
    {
        [Fact]
        public void TestPeak()
        {
            var array = new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            int expected = 6;
            Assert.Equal(expected, LongestPeakTask.LongestPeak(array));
        }
        [Fact]
        public void EmptyTest()
        {
            var array = new int[] { };
            int expected = 0;
            Assert.Equal(expected, LongestPeakTask.LongestPeak(array));
        }

        [Fact]
        public void InlineTest()
        {
            var array = new int[] { 1, 3, 2 };
            int expected = 3;
            Assert.Equal(expected, LongestPeakTask.LongestPeak(array));
        }
    }
}
