using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends \"*\" at the end. Print the result at the console. Use switch statement.
            Console.Write("Enter variable type (0 - int, 1 - double, 2 string): ");
            int intVar = int.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        intVar = int.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable +1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable +* = {0}", stringVar);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong input"); break;

                    

            }
            Console.ReadLine();
        }
    }
}
