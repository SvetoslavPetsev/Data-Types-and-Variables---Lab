using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            decimal k = (decimal)m / 1000;
            Console.WriteLine($"{k:F2}");
        }
    }
}
