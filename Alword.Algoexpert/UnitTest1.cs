using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace Alword.Algoexpert
{

    public class ProgramTest
    {
        private bool compare(List<int[]> triplets1, List<int[]> triplets2)
        {
            if (triplets1.Count != triplets2.Count) return false;
            for (int i = 0; i < triplets1.Count; i++)
            {
                if (!Enumerable.SequenceEqual(triplets1[i], triplets2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        [Fact]
        public void TestCase1()
        {
            List<int[]> expected = new List<int[]>();
            expected.Add(new int[] { -8, 2, 6 });
            expected.Add(new int[] { -8, 3, 5 });
            expected.Add(new int[] { -6, 1, 5 });
            List<int[]> output =
              ThreeNumberSum.Solve(new int[] { 12, 3, 1, 2, -6, 5, -8, 6 }, 0);
            Assert.True(this.compare(output, expected));
        }
    }
}
