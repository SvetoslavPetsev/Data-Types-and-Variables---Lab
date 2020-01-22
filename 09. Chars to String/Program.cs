using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            for (int i = 0; i < 3; i++)
            {
                char input = char.Parse(Console.ReadLine());
                text += input;
            }
            Console.WriteLine(text);
        }
    }
}
