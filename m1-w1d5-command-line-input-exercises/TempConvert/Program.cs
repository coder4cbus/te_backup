using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {

            TempTwoScales();
        }

        static string TempTwoScales()
        {
            Console.Write("Please enter the ambient temperature: ");
            string stringTemp = Console.ReadLine();
            double numTemp = double.Parse(stringTemp);
            
            Console.Write("Is the temperature in (C)elcius, or(F)arenheit? ");
            string scaleTemp = Console.ReadLine();

            if (scaleTemp == ("C") || scaleTemp == ("c"))
            {
                Console.WriteLine($"{(int)((numTemp * 9/5) + 32)}F is {(int)numTemp}C.");
            }
            else if (scaleTemp == ("F") || scaleTemp == ("f"))
            {
                Console.WriteLine($"{(int)numTemp}F is {(int)((numTemp - 32) * 5/9)}C.");
            }
            else
            {
                Console.WriteLine("Please be sure to follow directions and enter only the requested information. Thanks! :)");
            }
            return "";
        }
    }
}
           

    