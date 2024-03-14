using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage : SimpleCalculator.exe <number1> <number2>");
                return;
            }

            if (!double.TryParse(args[0], out double num1) || !double.TryParse(args[1], out double num2))
            {
                Console.WriteLine("Invalid input. Please provide a valid numbers.");
                return;
            }


            double sum = num1 + num2;
            Console.WriteLine($"Sum of {num1} and {num2} is : {sum}");
        }
    }
}