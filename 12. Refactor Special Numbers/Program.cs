using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int sum = 0;
            bool specialNumber;
            for (int i = 1; i <= numberInput; i++)
            {
                int number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                specialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, specialNumber);
                sum = 0;
                i = number;
            }
        }
    }
}
