using System;
using System.Linq;

namespace Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLongestWord("He told us a very exciting adventure story."));
            Console.WriteLine(FindLongestWord("I love eating toasted cheese and tuna sandwiches."));
        }

        static int FindLongestWord(string str)
        {
            string[] words = str.Split(' ');

            if(words.Length == 1)
            {
                return words[0].Length;
            }

            if(words[0].Length >= words[1].Length)
            {
                var source = words.ToList();
                source.RemoveRange(1, 1);
                return FindLongestWord(String.Join(" ", source));
            }

            if(words[0].Length < words[1].Length)
            {
                var source = new ArraySegment<string>(words, 1, words.Length - 1);
                return FindLongestWord(String.Join(" ", source));
            }

            return str.Length;
        }
    }
}
