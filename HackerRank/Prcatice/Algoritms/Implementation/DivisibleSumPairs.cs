using System.Collections.Generic;
using NUnit.Framework;

namespace HackerRank.Prcatice.Algoritms.Implementation
{
    public class DivisibleSumPairs : BaseSolution
    {
        public override void Solution()
        {
            var input1 = new[] { 1, 2, 3, 4, 5, 6 };
            var k1 = 5;
            var expectedResult1 = 3;
            var result1 = DivisibleSums(input1, k1);

            Assert.AreEqual(expectedResult1, result1, "Case[1]: the output is not correct");

            var input2 = new[] { 1, 3, 2, 6, 1, 2 };
            var k2 = 3;
            var expectedResult2 = 5;
            var result2 = DivisibleSums(input2, k2);

            Assert.AreEqual(expectedResult2, result2, "Case[2]: the output is not correct");
        }

        private static int DivisibleSums(IReadOnlyList<int> arr, int k)
        {
            var counter = 0;

            for (var j = 1; j < arr.Count; j++)
            {
                for (var i = 0; i < j; i++)
                {
                    if ((arr[i] + arr[j]) % k == 0) counter++;
                }
            }

            return counter;
        }
    }
}
