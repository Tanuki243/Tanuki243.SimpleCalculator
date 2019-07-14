using System;

namespace Tanuki243.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechenoperation ro = new Rechenoperation();

            string zahl1String;
            string operation;
            string zahl2String;

            string val;
            Console.Write("Enter integer: ");
            do
            {
                zahl1String = Console.ReadLine();
            } while ();
            operation = Console.ReadLine();
            zahl2String = Console.ReadLine();

            int zahl1 = Int32.Parse(zahl1String);
            int zahl2 = Int32.Parse(zahl2String);

            int ergebnis = ro.Rechnen(zahl1, zahl2, operation); ;

            Console.WriteLine("Ergebnis " + ergebnis);

            Console.ReadLine();
        }
    }
}
