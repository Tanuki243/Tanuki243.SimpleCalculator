using System;

namespace Tanuki243.SimpleCalculator
{
    public class RepeatCalculation
    {
        public bool repeatCalculation()
        {
            bool returnValue = false;
            bool correctInput = false;
            string userInput;

            do
            {
                Console.WriteLine("Do You want to do another Calculation? Type J for more and N to close the Calculator");
                userInput = Console.ReadLine();

                if (userInput.Contains("J") == true)
                {
                    returnValue = true;
                    correctInput = true;
                }
                else if (userInput.Contains("N") == true)
                {
                    correctInput = true;
                }
            } while(correctInput == false);

            return returnValue;
        }
    }
}
