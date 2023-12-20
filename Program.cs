using System;

namespace CalculatorApp
{
    class Addition
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Subtraction
    {
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
    }

    class Multiplication
    {
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    class Division
    {
        public static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Error: Division by zero!");
                return double.NaN; 
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            double num1 = 10;
            double num2 = 5;

           
            double sum = Addition.Add(num1, num2);
            Console.WriteLine($"Додавання: {num1} + {num2} = {sum}");

            
            double difference = Subtraction.Subtract(num1, num2);
            Console.WriteLine($"Віднімання: {num1} - {num2} = {difference}");

            
            double product = Multiplication.Multiply(num1, num2);
            Console.WriteLine($"Множення: {num1} * {num2} = {product}");

            
            double quotient = Division.Divide(num1, num2);
            Console.WriteLine($"Ділення: {num1} / {num2} = {quotient}");

            Console.ReadKey();
        }
    }
}
