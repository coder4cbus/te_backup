using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter.Class
{
    public class FizzBuzz2Write
    {
        public static void WritingFizzBuzz()
        {

            string fullPath = Path.Combine(Environment.CurrentDirectory, "writingFizzBuzz.txt");

            // Open up a streamwriter for the file to write to...
            using (StreamWriter sw = new StreamWriter(fullPath, false))
            {
                for (int numValue = 1; numValue < 300; numValue++)
                {
                    if ((numValue % 3 == 0) && (numValue % 5 == 0))
                    {
                        sw.WriteLine($"#{numValue.ToString()})... FizzBuzz");
                    }
                    else if (numValue % 3 == 0)
                    {
                        sw.WriteLine($"#{numValue.ToString()})... Fizz");
                    }
                    else if (numValue % 5 == 0)
                    {
                        sw.WriteLine($"#{numValue.ToString()})... Buzz");
                    }
                    else if ((numValue % 3 != 0) && (numValue % 5 != 0))
                    {
                        sw.WriteLine($"#{numValue.ToString()})... {numValue.ToString()}");
                    }

                }

            }
        }
    }
}


