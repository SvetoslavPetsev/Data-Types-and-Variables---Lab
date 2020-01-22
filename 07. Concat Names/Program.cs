using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameA = Console.ReadLine();
            string nameB = Console.ReadLine();
            string deliter = Console.ReadLine();

            Console.WriteLine(nameA + deliter + nameB);
        }
    }
}
