using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that finds the greatest of given 5 numbers.
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int e = int.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine("{0} is the biggest number.", a);
            Console.ReadLine();

        }
    }
}
