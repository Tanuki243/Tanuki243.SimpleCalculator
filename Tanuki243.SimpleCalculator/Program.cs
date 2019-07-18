using System;

namespace Tanuki243.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            UserInput userInput = new UserInput();
            
            string repeat;

            do
            {
            // Read User Input
            decimal number1 = userInput.userInputDecimal("Enter a number: ");
            string operation = userInput.userInputString("Enter the Math Operator: ");
            decimal number2 = userInput.userInputDecimal("Enter a number: ");

            // Call operation to calculate result
            decimal result = mathOperation.Rechnen(number1, number2, operation);

            Console.WriteLine("Result: " + result);

            //Ask User if there should be another Calculation
            Console.WriteLine("Do You want to do another Calculation? Type J for more and N to close the Calculator");
            repeat = Console.ReadLine();

            } while (repeat.Contains("J") == true);

            // Close Console
            Console.ReadLine();
        }
    }
}
