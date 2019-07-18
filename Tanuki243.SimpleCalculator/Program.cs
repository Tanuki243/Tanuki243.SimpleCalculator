using System;

namespace Tanuki243.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            UserInput userInput = new UserInput();
            
            // Read User Input
            decimal number1 = userInput.userInputDouble("Enter a number: ");
            string operation = userInput.userInputString("Enter the Math Operator: ");
            decimal number2 = userInput.userInputDouble("Enter a number: ");

            // Call operation to calculate result
            decimal result = mathOperation.Rechnen(number1, number2, operation);

            Console.WriteLine("Result: " + result);

            // Close Console
            Console.ReadLine();
        }
    }
}
