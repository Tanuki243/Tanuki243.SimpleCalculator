namespace Tanuki243.SimpleCalculator
{
    public class MathOperation
    {
        public double Rechnen(double number1, double number2, string mathOperator)
        {
            switch (mathOperator)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    return 0;
            }
        }
    }
}
