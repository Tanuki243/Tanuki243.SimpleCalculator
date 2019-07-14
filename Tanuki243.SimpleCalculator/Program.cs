using System;

namespace Tanuki243.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechenoperation ro = new Rechenoperation();
            UserInput userInput = new UserInput();
            
            Console.Write("Enter Double: ");
            
            // Read User Input
            double zahl1 = userInput.userInputDouble();
            string operation = userInput.userInputString();
            double zahl2 = userInput.userInputDouble();

            // Call operation to calculate result
            double ergebnis = ro.Rechnen(zahl1, zahl2, operation);

            Console.WriteLine("Ergebnis " + ergebnis);

            // Close Console
            Console.ReadLine();
        }
    }
}
