using System;
using System.Linq;

namespace Tanuki243.SimpleCalculator
{
    public class UserInput
    {
        public string userInputString(String userMessage)
        {
            string userInput;

            do {
                Console.Write(userMessage);

                userInput = Console.ReadLine();
            } while(userInput.Count() == 0);

            return userInput;
        }

        public decimal userInputDecimal(String userMessage)
        {
            string checkUserInput;

            do {
                Console.Write(userMessage);
                checkUserInput = Console.ReadLine();

            } while(checkUserInput.Count() == 0);

            decimal userInput = Decimal.Parse(checkUserInput);

            return userInput;
        }
    }
}
