﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("C:\\Users> LinearConvert ");
            Console.Write("Please enter the length: ");
            string stringLength = Console.ReadLine();
            double numLength = double.Parse(stringLength);

            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string scaleMeasure = Console.ReadLine();

            if (scaleMeasure == ("M") || scaleMeasure == ("m"))
            {
                //Console.WriteLine($"Actual Value: { (numLength * 3.2808399)}f is {numLength}m.");
                Console.WriteLine($"Integer Value: {(int)(numLength * 3.2808399)}f is {(int)numLength}m.");
                //Console.WriteLine($"Integer Rounded Value: {(int)Math.Round(numLength * 3.2808399)}f is {(int)Math.Round(numLength)}m.");
                //Console.WriteLine($"Floor Rounded Value: {Math.Floor(numLength * 3.2808399)}f is {Math.Floor(numLength)}m.");
            }
            else if (scaleMeasure == ("F") || scaleMeasure == ("f"))
            {
                //Console.WriteLine($"Actual Value: {numLength}f is {(numLength * 0.3048)}m.");
                Console.WriteLine($"Integer Value: {(int)numLength}f is {(int)(numLength * 0.3048)}m.");
                //Console.WriteLine($"Integer Rounded Value: {(int)Math.Round(numLength)}f is {(int)Math.Round(numLength * 0.3048)}m.");
                //Console.WriteLine($"Floor Rounded Value: {Math.Floor(numLength)}f is {Math.Floor(numLength * 0.3048)}m.");
            }
            else
            {
                Console.WriteLine("Please be sure to follow directions and enter only the requested information. Thanks! :)");
            }
            return;
        }
    }
}
