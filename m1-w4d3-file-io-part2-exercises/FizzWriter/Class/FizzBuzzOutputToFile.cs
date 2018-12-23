using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter.Class
{
    public class FizzBuzzOutputToFile
    {
        private List<string> storeFizzBuzzResult = new List<string>();
        string outputAsString = " ";
        //private string[] result;

        public FizzBuzzOutputToFile ()
        {

        }
        public string[] GetFizzBuzz()
        {
            List<string> storeFizzBuzzResult = new List<string>();
            //string outputAsString = " ";
            for (int numValue = 1; numValue < 300; numValue++)
            {
                //List<string> storeFizzBuzzResult = new List<string>();

                if ((numValue % 3 == 0) && (numValue % 5 == 0))
                {
                    outputAsString = "FizzBuzz";
                    storeFizzBuzzResult.Add("FizzBuzz");
                    Console.WriteLine(outputAsString);
                }
                else if (numValue % 3 == 0)
                {
                    outputAsString = "Fizz";
                    storeFizzBuzzResult.Add("Fizz");
                    Console.WriteLine(outputAsString);
                }
                else if (numValue % 5 == 0)
                {
                    outputAsString = "Buzz";
                    storeFizzBuzzResult.Add("Buzz");
                    Console.WriteLine(outputAsString);
                }
                else
                {
                    outputAsString = numValue.ToString();
                    storeFizzBuzzResult.Add(outputAsString);
                    Console.WriteLine(outputAsString);
                }
                //return storeFizzBuzzResult.ToArray();
            }
            //return GetFizzBuzz();
            return storeFizzBuzzResult.ToArray();
        }

        public static void WritingFizzBuzz()
        {
            bool success = false;
            string directory = Environment.CurrentDirectory;
            string fileName = "writingFizzBuzz.txt";

            while (!success)
            {
                Console.WriteLine("Before writing your text file, to be named FizzBuzz.txt, a file storage location is needed. Please specify your desired location by typing an absolute file path.");
                try
                {
                    string fullPath = Console.ReadLine();
                    //string fullPath = Path.Combine(directory, fileName);
                    if (!Directory.Exists(fullPath))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
                        File.Create(Path.GetFileName(fullPath));
                        success = true;
                    }
                    success = true;
                    int numCount = 1;
                    // Open up a streamwriter for the file to write to...
                    using (StreamWriter sw = new StreamWriter(fullPath, true))
                    {
                        FizzBuzzOutputToFile GetFizzBuzz = new FizzBuzzOutputToFile();
                        string[] storeFizzBuzzResult = new [] storeFizzBuzzResult();
                        foreach (string output in storeFizzBuzzResult)
                        {
                            sw.WriteLine($"{numCount.ToString()} is ... {output}");
                            numCount++;
                        }
                        //Should automatically flush and close the stream when done writing to the file.
                    }
                }

                catch (IOException e) //catch a specific type of Exception
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
          
