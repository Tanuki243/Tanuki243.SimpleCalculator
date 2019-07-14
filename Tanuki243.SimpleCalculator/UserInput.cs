using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double userInputDouble(String userMessage)
        {
            string checkUserInput;

            do {
                Console.Write(userMessage);
                checkUserInput = Console.ReadLine();

            } while(checkUserInput.Count() == 0);

            double userInput = Double.Parse(checkUserInput);

            return userInput;
        }
    }
}
