using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int n)
        {
            string outputAsString = " ";
                if ((n > 100) || (n < 1))
                {
                    outputAsString = " ";
                }
                else if ((n % 3!= 0) && (n % 5 != 0))
                {
                    outputAsString = n.ToString();
                }
                else if ((n % 3 == 0) && (n % 5 == 0))
                {
                    outputAsString = "FizzBuzz";
                }
                else if (n % 3 == 0)
                {
                    outputAsString = "Fizz";
                }
                else if (n % 5 == 0)
                {
                    outputAsString = "Buzz";
                }
            return outputAsString;
        }
   }
}
