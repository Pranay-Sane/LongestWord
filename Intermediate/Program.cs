using System;
using System.Linq;

namespace Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLongestWord("He told us a very exciting adventure story."));
            Console.WriteLine(FindLongestWord("I love eating toasted cheese and tuna sandwiches."));

        }

        static int FindLongestWord(string str) => str.Split(' ').Aggregate(0, (x, y) => Math.Max(x, y.Length));
    }
}
