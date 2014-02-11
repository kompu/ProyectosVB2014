using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryTest1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("привет всем");
            double a, b, c, x;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            Functions obje = new Functions();
            double y = obje.Polinom(a, b, c, x);
            Console.WriteLine("y = aX^2 + bX + C " + "y = " + y);
            Console.ReadLine();
        }
    }
}