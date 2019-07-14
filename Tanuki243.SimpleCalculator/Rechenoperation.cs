namespace Tanuki243.SimpleCalculator
{
    class Rechenoperation
    {
        public int Rechnen(int zahl1, int zahl2, string rechenOperator)
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
