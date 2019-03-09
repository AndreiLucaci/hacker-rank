using System.Collections.Generic;
using HackerRank.Prcatice.Algoritms.Strings;

namespace HackerRank
{
    public class ProblemInitializer
    {
        public static Dictionary<string, ISolution> Problems = new Dictionary<string, ISolution>
        {
            [Pratice.Algoritms.Strings.StrongPassowrd] = new StrongPassword()
        };
    }

    public class Pratice
    {
        public class Algoritms
        {
            public class Strings
            {
                public const string StrongPassowrd = nameof(StrongPassowrd);
            }
        }
    }
}
