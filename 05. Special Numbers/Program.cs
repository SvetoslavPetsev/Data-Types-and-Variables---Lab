using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int a = i;
                while (a > 10)
                {
                    int b = a % 10;
                    sum += b;
                    a /= 10;
                }
                int newsum = sum + a;
                if (newsum == 5 || newsum == 7 || newsum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
