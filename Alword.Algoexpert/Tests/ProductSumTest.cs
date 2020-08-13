using Alword.Algoexpert.Tier0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests
{
    public class ProductSumTest
    {
        [Fact]
        public static void TestSum()
        {
            List<object> test = new List<object>(){
                5,2,
                new List<object>(){ 7, -1 },
                3,
                new List<object>()
                {
                    6,
                    new List<object>()
                    { -13, 8 },
                    4,
                },
            };
            Assert.Equal(12, ProductSumTask.ProductSum(test));
        }
    }
}
