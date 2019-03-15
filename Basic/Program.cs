using System;

namespace Basic
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
            int maxLength = 0;

            foreach(string word in words)
            {
                if(word.Length > maxLength)
                {
                    maxLength = word.Length;
                }
            }

            return maxLength;
        }
    }
}
