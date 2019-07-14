using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanuki243.SimpleCalculator
{
    public class UserInput
    {
        public string userInputString()
        {
            return Console.ReadLine();
        }

        public double userInputDouble()
        {
            return Double.Parse(Console.ReadLine());
        }
    }
}
