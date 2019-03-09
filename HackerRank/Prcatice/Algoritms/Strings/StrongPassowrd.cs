using System;
using System.Linq;
using NUnit.Framework;

namespace HackerRank.Prcatice.Algoritms.Strings
{
    public class StrongPassword : BaseSolution
    {
        private const string Numbers = "0123456789";
        private const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialCharacters = "!@#$%^&*()-+";
        private const int MinNumberOfChatacters = 6;

        private static int MinChars(string str)
        {
            var nr = 0;

            if (!str.Any(Numbers.Contains)) nr++;
            if (!str.Any(LowerCase.Contains)) nr++;
            if (!str.Any(UpperCase.Contains)) nr++;
            if (!str.Any(SpecialCharacters.Contains)) nr++;

            return Math.Max(nr, MinNumberOfChatacters - str.Length);
        }

        public override void Solution()
        {
            var input1 = "Ab1";
            var expectedOutput1 = 3;

            var input2 = "#HackerRank";
            var expectedOutput2 = 1;

            var input3 = "zss";
            var expectedOutput3 = 3;

            var input4 = "4700";
            var expectedOutput4 = 3;

            var result1 = MinChars(input1);
            var result2 = MinChars(input2);
            var result3 = MinChars(input3);
            var result4 = MinChars(input4);

            Assert.AreEqual(expectedOutput1, result1, "Case[1]: The expected output is not correct.");
            Assert.AreEqual(expectedOutput2, result2, "Case[2]: The expected output is not correct.");
            Assert.AreEqual(expectedOutput3, result3, "Case[3]: The expected output is not correct.");
            Assert.AreEqual(expectedOutput4, result4, "Case[4]: The expected output is not correct.");
        }
    }
}