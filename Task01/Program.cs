using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            if (a>b);
            {
                a = a + b;
                b = a - b;
                a = b - a;
            }
            Console.WriteLine("The first number is {0} and the second number is {1}", a, b);
            Console.ReadLine();
        }
    }
}