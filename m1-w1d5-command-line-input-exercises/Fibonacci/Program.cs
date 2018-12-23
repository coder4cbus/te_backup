using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {

            GetFibonacciSequence();
        }
        static string GetFibonacciSequence()

        {
            Console.WriteLine("C:\\Users> Fiboncci ");
            Console.Write("Please enter the Fibonacci number: ");

            string numberInputAsString = Console.ReadLine();
            int numberAsValue = int.Parse(numberInputAsString);

            Console.WriteLine();

            int startValue = 0, secondValue = 1;
            string FibonacciSequence = " ";

            //if (numberAsValue == 0)
            //{
            //    Console.WriteLine($"Fibonacci Sequence is: {startValue}");
            //}
            //else if ((numberAsValue >= 1) && (numberAsValue <= 2))
            //{
            //    Console.WriteLine($"Fibonacci Sequence is: {startValue}, {secondValue}, {startValue + secondValue}");
            //}
            //else if (numberAsValue < 0)
            //{
            //    Console.WriteLine("Invalid entry! Please provide a positive integer value.");
            //}
            //else
            //{
                int nextValue = 0;
                while ((nextValue <= numberAsValue))
                {
                    nextValue = startValue + secondValue;


                    startValue = secondValue;
                    secondValue = nextValue;

                    FibonacciSequence += ($"{startValue}, ");
                }
                Console.WriteLine($"Fibonacci Sequence is: {FibonacciSequence}");
            return FibonacciSequence;
        }
            //return FibonacciSequence;
        }
    }
//}