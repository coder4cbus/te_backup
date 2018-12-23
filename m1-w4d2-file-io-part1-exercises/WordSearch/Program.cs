using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
            Console.WriteLine("Type the word or phrase that you would like to find...");
            string userTypedText = Console.ReadLine();

            Console.WriteLine("Is your word or phrase search case sensitive? If (Y)es, enter Y and for (N)o enter N");
            string caseImportance = Console.ReadLine().ToLower();

            Console.WriteLine("A file location is needed to conduct this search.");
            Console.WriteLine("Please provide an absolute file path including the file name and associated extension below...");
            //C:\Users\eulry\eileenulry-c-exercises\m1-w4d3-file-io-part2-exercises\aaw.txt
            string userTypedFilePath = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(userTypedFilePath))
                {
                    int lineCount = 1;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (caseImportance == "n")
                        {
                            string lineUpper = line.ToUpper();
                            string userTypedTextUpper = userTypedText.ToUpper();
                            if (lineUpper.Contains(userTypedTextUpper))
                            {
                                Console.WriteLine($"{lineCount}) {line}");
                                lineCount++;
                            }
                        }
                        else 
                        {
                            if (line.Contains(userTypedText))
                            {
                                Console.WriteLine($"{lineCount}) {line}");
                                lineCount++;
                            }
                        }

                        if (!(line.Contains(userTypedText)))
                        {
                            Console.WriteLine($"LineCount = {lineCount})");
                            lineCount++;
                        }
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }

}

