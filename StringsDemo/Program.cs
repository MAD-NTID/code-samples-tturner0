using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "something";
            Console.WriteLine(word);
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            Console.WriteLine(wordArray.ToString());
            word[0] = 'g';
            word[word.Length - 1] = 's';
            Console.WriteLine(word);
        }
    }
}
