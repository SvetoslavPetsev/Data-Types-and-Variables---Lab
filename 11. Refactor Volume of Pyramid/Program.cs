using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            var V = (lenght * width * hight) / 3;
            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}
