using Alword.Algoexpert.Tier0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests
{
    public class ValidSubsquenceTest
    {
        [Fact]
        public void ValidSequence()
        {
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 5, 1, 22, 23, 6, -1, 8, 10 };
            Assert.False(ValidSubsequence.IsValidSubsequence(array, sequence));
        }
    }
}
