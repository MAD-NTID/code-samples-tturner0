using System;
using System.Text;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "012wxyz789 hashSign";
            string msWord = "I like to use the Microsoft word!";
            //char[] arr;
            //arr = test.ToCharArray(4,5);
            string something = "";
            something += "a";
            something += "bird";
            
            StringBuilder sb = new StringBuilder();

            sb.Append("a");
            sb.Append("bird");

            Console.WriteLine(sb.ToString());



            char hashSign = '#';
            Console.WriteLine(test.Length);
            Console.WriteLine(test.PadLeft(20, hashSign));

            Console.WriteLine(msWord.Replace("word", "the"));

            Console.WriteLine(msWord.EndsWith("microsoft"));

            string[] wordArr = msWord.Split(" ");
            for(int index = 0; index < wordArr.Length; index++)
                Console.WriteLine(wordArr[index]);

            // for(int index = 0; index < test.Length; index++)
            //     Console.WriteLine(test[index]);

            // for(int index = 0; index <arr.Length; index++)
            // {
            //     Console.Write(arr[index]);
            // }

            int indexOfString = test.IndexOf("g");
            int indexOfChar =test.IndexOf('z');
            Console.WriteLine($"String Index of: {indexOfString}\tChar Index of{indexOfChar}");

            // string exam = "And Lo, the exam is near!";
            // string sub = exam.Substring(8);
            // Console.WriteLine(sub);
            

        }
    }
}
