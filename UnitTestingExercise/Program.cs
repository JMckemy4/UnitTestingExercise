using System;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int difference = calculator.Subtract(10, 5);
            Console.WriteLine($"Subtraction Result: {difference}");

            int product = calculator.Multiply(2, 3);
            Console.WriteLine($"Multiplication Result: {product}");

            double quotient = calculator.Divide(10, 2);
            Console.WriteLine($"Division Result: {quotient}");
        }
    }
}
