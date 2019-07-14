namespace Tanuki243.SimpleCalculator
{
    public class Rechenoperation
    {
        public double Rechnen(double zahl1, double zahl2, string rechenOperator)
        {
            switch (rechenOperator)
            {
                case "+":
                    return zahl1 + zahl2;
                case "-":
                    return zahl1 - zahl2;
                case "*":
                    return zahl1 * zahl2;
                case "/":
                    return zahl1 / zahl2;
                default:
                    return 0;
            }
        }
    }
}
