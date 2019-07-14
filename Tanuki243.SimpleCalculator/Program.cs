using System;

namespace Tanuki243.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechenoperation ro = new Rechenoperation();
            UserInput userInput = new UserInput();
            
            // Read User Input
            double zahl1 = userInput.userInputDouble("Geben Sie eine Zahl ein: ");
            string operation = userInput.userInputString("Geben Sie eine Rechenoperation ein: ");
            double zahl2 = userInput.userInputDouble("Geben Sie eine Zahl ein: ");

            // Call operation to calculate result
            double ergebnis = ro.Rechnen(zahl1, zahl2, operation);

            Console.WriteLine("Ergebnis " + ergebnis);

            // Close Console
            Console.ReadLine();
        }
    }
}
