using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = SelectOperation();
            double num1 = AskNumber("Enter first number: ");
            double num2 = AskNumber("Enter second number: ");

            double result = PerformCalculation(operation, num1, num2);

            PrintResult(operation, num1, num2, result);
        }

        static int SelectOperation()
        {
            while (true)
            {
                Console.WriteLine("Select Operation:");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.Write("Enter choice (1/2/3/4): ");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please choose a number between 1 and 4.");
                }
            }
        }

        static double AskNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static double PerformCalculation(int operation, double num1, double num2)
        {
            switch (operation)
            {
                case 1:
                    return Add(num1, num2);
                case 2:
                    return Subtract(num1, num2);
                case 3:
                    return Multiply(num1, num2);
                case 4:
                    return Divide(num1, num2);
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            return x / y;
        }

        static void PrintResult(int operation, double num1, double num2, double result)
        {
            string operationSymbol = operation switch
            {
                1 => "+",
                2 => "-",
                3 => "*",
                4 => "/",
                
            };

            Console.WriteLine($"Result: {num1} {operationSymbol} {num2} = {result}");
        }
    }
}