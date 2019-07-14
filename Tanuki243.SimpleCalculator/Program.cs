using System;

namespace Tanuki243.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechenoperation ro = new Rechenoperation();

            // Declare Variables
            string zahl1String;
            string operation;
            string zahl2String;
            
            Console.Write("Enter integer: ");
            
            // Read User Input
            zahl1String = Console.ReadLine();
            operation = Console.ReadLine();
            zahl2String = Console.ReadLine();

            // Convert Strings to Integer
            int zahl1 = Int32.Parse(zahl1String);
            int zahl2 = Int32.Parse(zahl2String);

            // Call operation to calculate result
            int ergebnis = ro.Rechnen(zahl1, zahl2, operation); ;

            Console.WriteLine("Ergebnis " + ergebnis);

            // Close Console
            Console.ReadLine();
        }
    }
}
