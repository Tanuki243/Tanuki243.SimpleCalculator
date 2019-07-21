using System;

namespace Tanuki243.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            UserInput userInput = new UserInput();
            RepeatCalculation repeatCalculation = new RepeatCalculation();
            
            bool repeat;
            
            do
            {
                // Read User Input
                decimal number1 = userInput.userInputDecimal("Enter a number: ");
                string operation = userInput.userInputMathOperator("Enter the Math Operator: ");
                decimal number2 = userInput.userInputDecimal("Enter a number: ");

                // Call operation to calculate result
                decimal result = mathOperation.Rechnen(number1, number2, operation);

                Console.WriteLine("Result: " + result);

                //Ask User if there should be another Calculation
                repeat = repeatCalculation.repeatCalculation();
            } while (repeat == true);

            // Close Console
            Console.ReadLine();
        }
    }
}
