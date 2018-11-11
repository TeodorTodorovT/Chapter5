using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
            Console.WriteLine("Please enter coefficients a,b and c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double d = (b * b) - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / 2 * a;
                double x2 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("There are 2 roots for the equation x1= {0} and x2= {1}", x1, x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("There is 1 root for the equation x= {0}", x);
            }
            else
            {
                Console.WriteLine("There are no real roots for the equation");
            }
            Console.ReadLine();
        }
    }
}
