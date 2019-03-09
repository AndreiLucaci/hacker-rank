using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace HackerRank.Prcatice.Algoritms.Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-birthday-bar/problem
    /// Lily has a chocolate bar that she wants to share it with Ron for his birthday. 
    /// Each of the squares has an integer on it. She decides to share a contiguous segment of the bar selected such
    ///  that the length of the segment matches Ron's birth month and the sum of the integers on the squares is equal
    ///  to his birth day. You must determine how many ways she can divide the chocolate.
    /// Consider the chocolate bar as an array of squares, s=[2,2,1,3,2] . She wants to find segments summing to Ron's
    ///  birth day, d=4 with a length equalling his birth month, m=2 . In this case, there are two segments meeting her
    ///  criteria: [2,2] and [1,3].
    /// </summary>
    public class BirthDayChocolate : BaseSolution
    {
        public override void Solution()
        {
            Example1(ChocolateChunksLinq);
            Example2(ChocolateChunksLinq);
            Example3(ChocolateChunksMath);
            Example4(ChocolateChunksMath);
        }

        private void Example1(Func<int[], int, int, int> func)
        {
            var input = new[] { 1, 2, 1, 3, 2 };
            var m = 2;
            var d = 3;
            var expectedOutput = 2;
            var result = func(input, d, m);

            Assert.AreEqual(expectedOutput, result, "Case [1]: The expected output is not correct.");
        }

        private void Example2(Func<int[], int, int, int> func)
        {
            var input = new[] { 1, 1, 1, 1, 1, 1 };
            var m = 2;
            var d = 3;
            var expectedOutput = 0;
            var result = func(input, d, m);

            Assert.AreEqual(expectedOutput, result, "Case [2]: The expected output is not correct.");
        }

        private void Example3(Func<int[], int, int, int> func)
        {
            var input = new[] { 4 };
            var m = 1;
            var d = 4;
            var expectedOutput = 1;
            var result = func(input, d, m);

            Assert.AreEqual(expectedOutput, result, "Case [3]: The expected output is not correct.");
        }

        private void Example4(Func<int[], int, int, int> func)
        {
            var input = new[]
            {
                3, 5, 4, 1, 2, 5, 3, 4, 3, 2, 1, 1, 2, 4, 2, 3, 4, 5, 3, 1, 2, 5, 4, 5, 4, 1, 1, 5, 3, 1, 4, 5, 2, 3, 2,
                5, 2, 5, 2, 2, 1, 5, 3, 2, 5, 1, 2, 4, 3, 1, 5, 1, 3, 3, 5
            };

            var d = 18;
            var m = 6;
            var expectedOutput = 10;
            var result = func(input, d, m);

            Assert.AreEqual(expectedOutput, result, "Case [4]: The expected output is not correct.");
        }

        /// <summary>
        /// Complexity ~ O(nm)
        /// </summary>
        private static int ChocolateChunksLinq(IReadOnlyCollection<int> arr, int d, int m)
        {
            var count = 0;
            var start = -1;

            while (start++ + m < arr.Count)
            {
                if (arr.Skip(start).Take(m).ToList().Sum() == d) count++;
            }

            return count;
        }

        /// <summary>
        /// Complexity ~ O(nm)
        /// </summary>
        private static int ChocolateChunksMath(IReadOnlyList<int> arr, int d, int m)
        {
            if (arr.Count == m) return arr.Sum() == d ? 1 : 0;

            var count = 0;

            for (int i = 0, sum = 0; i < arr.Count - m + 1; sum = 0, i++)
            {
                for (var j = i; j < i + m; sum += arr[j++]) { }

                if (sum == d) count++;
            }

            return count;
        }
    }
}
