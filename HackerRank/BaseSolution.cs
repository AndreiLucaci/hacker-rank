using System;

namespace HackerRank
{
    public abstract class BaseSolution : ISolution
    {
        public abstract void Solution();

        public void Solve()
        {
            Solution();

            Console.WriteLine("Ok");
        }
    }
}
