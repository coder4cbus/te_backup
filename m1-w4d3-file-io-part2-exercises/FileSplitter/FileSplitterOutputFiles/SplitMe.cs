using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter.Class
{
    public class SplitFileOutput
    {
        //static string userFileName = "aaw.txt";
        static string userFileName;
        static int swLineCount;
        static string destinationPath = @"C:\Users\eulry\eileenulry-c-exercises\m1-w4d3-file-io-part2-exercises\FileSplitter\FileSplitterOutputFiles\SplitFiles\";
        //static string destinationPath = Environment.CurrentDirectory;
        static string fullPath = Path.Combine(destinationPath, userFileName);

        static int numOfFiles;
        private static int linesPerOutputFile;
        //private static int linesPerOutputFile = 35;

       
        public static void GetUserInput()
        {
            Console.WriteLine("Welcome to the File Splitter!");
            //const string FilePath = @"C:\TestDirectory\FileName.txt";
            // Check to see if a file exists
            //bool fileExists = File.Exists(FilePath);
            //if (fileExists)
            // {
            bool isFound = false;
            while (!isFound)
            {
                Console.WriteLine("Please provide the name of your input file.\n For example, input.txt");
                Console.WriteLine($"string userFileName = {@"aaw.txt"} ");
                //string userFileName = Console.ReadLine();
                userFileName = Console.ReadLine();
                try
                {
                    if (!File.Exists(fullPath))
                    {
                        Console.WriteLine("Please enter a valid file name.");
                        throw new IOException();
                    }
                    else
                    {
                        isFound = true;
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("File NOT FOUND" + e.Message);
                }
            }
            bool acceptableInput = false;
            while (!acceptableInput)
            {
                Console.WriteLine("How many lines of text (max) should there be in the split files?");
                //int linesPerOutputFile = (int.Parse(Console.ReadLine()));
                //int linesPerOutputFile = (int.Parse("35"));
                Console.WriteLine($"int linesPerOutputFile = {(int.Parse($"{linesPerOutputFile}"))}");
                linesPerOutputFile = int.Parse(Console.ReadLine());
                try
                {
                    if (linesPerOutputFile <= 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        acceptableInput = true;
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("A positive value in integer form is required. Please try again!" + e.Message);
                }

            }
        }

        public static void GetLineCount()
        {
            try
            {
                        using (StreamReader sr = new StreamReader(fullPath))
                        {
                            int lineCount = 1;
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                Console.WriteLine("** GENERATING OUTPUT **");
                                lineCount++;
                            }
                            Console.WriteLine($"Final LineCount At Close of While LOOP: {lineCount})");
                            swLineCount = lineCount;
                        }
            }
            catch (IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Processing Error ...");
                Console.WriteLine(e.Message);
                //GetLineCount();
            }
        }

        public static void EstimateTotalFiles()
        {
            if (linesPerOutputFile < swLineCount)
            {
                Console.WriteLine($"There are not enough lines in your original document to split as requested...\n Input file Line count: {swLineCount} \n. Requested lines of text (max) per output file: {linesPerOutputFile}.");
            }
            else if (linesPerOutputFile % 2 == 0)
            {
                Console.WriteLine($"Line Count of: {swLineCount}) is EQUAL TO linesPerOutputFile: {linesPerOutputFile}");
                Console.WriteLine($"EVEN NUMBER FOR linesPerOutputFile: {linesPerOutputFile}\n ");
                numOfFiles = (swLineCount / linesPerOutputFile);
            }
            else if (swLineCount % linesPerOutputFile != 0)
            {
                Console.WriteLine($"ODD Number for ... lineCount:{swLineCount}");
                Console.WriteLine($"Number for ... linesPerOutputFile:{linesPerOutputFile}");
                numOfFiles = (swLineCount / linesPerOutputFile) + 1;
            }
        }
        public static void SplitFile(int numOfFiles, string destinationPath, string userFileName)
        {

            using (StreamReader sr = new StreamReader(Path.Combine(destinationPath, userFileName)))
            {
                for (int i = 1; i <= numOfFiles; i++)
                {
                    string outputFileName = ($"Generating outputFile-{i}.txt");
                    using (StreamWriter sw = new StreamWriter(Path.Combine(destinationPath, ($"Generating outputFile-{i}.txt"))))
                    {
                        for (int j = 1; j < numOfFiles; j++)
                            
                        {
                            if (!sr.EndOfStream)
                            {
                                sw.WriteLine(sr.ReadLine());
                            }
                            else break;
                        }
                    }

                }
            }

        }
        public static void ConsoleOutput()
        {
            Console.WriteLine($"The specified input file ({userFileName}) has {swLineCount} lines of text.\n For the associated output files, please see: {destinationPath}.\n A sequential number will be assigned to each file that is created.\n Based on a {swLineCount} line input file of:(\"{userFileName}\" ), a total of {numOfFiles} output files will be produced.\n\n ******GENERATING OUTPUT******");
            Console.ReadLine();
        }
    }
}
   



