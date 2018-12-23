using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001

        Hint:
        int value = 8;
        string binary = Convert.ToString(value, 2);
        (from: https://stackoverflow.com/questions/2954962/convert-integer-to-binary-in-c-sharp)

        */

        static void Main(string[] args)
        {
            string decimalValuesAsString = " ";

            GetDecimalValues();
        }

        static string GetDecimalValues()
        {
            Console.WriteLine("C:\\Users> DecimalToBinary ");
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string decimalValuesAsString = Console.ReadLine();
            Console.WriteLine();

            string[] valuesAsArrayOfStrings = decimalValuesAsString.Split(' ');

            foreach (var valueAsString in valuesAsArrayOfStrings)
            {
                int fromBase = 10;
                int toBase = 2;

                string displayBinaryResult = Convert.ToString(Convert.ToInt32(valueAsString, fromBase), toBase);
               
                Console.WriteLine($"{valueAsString} in binary is {displayBinaryResult}");
            }
            return decimalValuesAsString;
        }
    }
}  