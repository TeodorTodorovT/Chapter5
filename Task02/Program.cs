using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            bool SignA = a > 0;
            bool SignB = b > 0;
            bool SignC = c > 0;


            if (SignA ^ SignB ^ SignC) Console.WriteLine("The sign is \"+\"");
            else Console.WriteLine("The sign is \"-\"");



            Console.ReadLine();

        }
    }
}
