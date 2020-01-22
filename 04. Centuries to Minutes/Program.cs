using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cent = int.Parse(Console.ReadLine());
            decimal oneYearDays = 365.2422m;
            int yeras = cent * 100;
            int days = (int)(yeras * oneYearDays);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{cent} centuries = {yeras} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
