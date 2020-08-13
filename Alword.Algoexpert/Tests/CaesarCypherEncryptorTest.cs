using Alword.Algoexpert.Tier0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.Algoexpert.Tests
{
    public class CaesarCypherEncryptorTest
    {
        [Theory]
        [InlineData("xyz", 2, "zab")]
        public void TwoShift(string str, int key, string expected)
        {
            var shift = CaesarCipherEncryptorTask.CaesarCypherEncryptor(str, key);
            Assert.Equal(expected, shift);
        }
    }
}
