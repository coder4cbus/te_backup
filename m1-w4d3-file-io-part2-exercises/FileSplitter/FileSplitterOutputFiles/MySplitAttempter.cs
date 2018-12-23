//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using FileSplitter.Class;

//namespace FileSplitter.FileSplitterOutputFiles
//    {
//        public class Program
//        {
//            static void Main(string[] args)
//            {

//                //generate new object
//                FileSplitOutput fileSplitOutput = new FileSplitOutput();


//                bool success = false;
//                string userTypedFilePath = (@"C:\Users\eulry\eileenulry-c-exercises\m1-w4d3-file-io-part2-exercises\aaw.txt");
//                int linesForInputFile;
//                int linesPerOutputFile = 10;
//                int predictNumberOfFilesInOutput;





//                void LineCountForInputFile()
//                {
//                    Console.WriteLine("Welcome to File Splitter!");
//                    Console.WriteLine("In order to locate the desired input file, please provide an absolute file path including the file name and associated extension below...");
//                    //string userTypedFilePath = Console.ReadLine();
//                    Console.WriteLine("How many lines of text (max) should there be in the split files?");
//                    //int linesPerOutputFile = (int.Parse(Console.ReadLine()));

//                    while (!success)
//                    {
//                        try
//                        {
//                            using (StreamReader sr = new StreamReader(userTypedFilePath))
//                            {
//                                int count = 1;
//                                int lineCount = 1;
//                                string line = "";
//                                while (!sr.EndOfStream)
//                                {
//                                    line = sr.ReadLine();
//                                    lineCount = int.Parse(sr.ReadLine());

//                                    Console.WriteLine($" Contained by while loop:/n {count}) line Substring:{line.Substring(0, 3)} line count: {lineCount}");

//                                }
//                                Console.WriteLine($" Outside the while loop..../n count: {count}) line Substring:{line.Substring(0, 3)} line count: {lineCount}");
//                                count++;
//                                lineCount++;
//                                lineCount = linesForInputFile;
//                            }
//                            success = true;
//                            Console.WriteLine($" Absolute path of input file {userTypedFilePath},/n Lines found in the original file {linesForInputFile},/n Max lines in output file {linesPerOutputFile },/n Number of output files to be produced:{predictNumberOfFilesInOutput}/n, ");

//                        }
//                        catch (IOException e)
//                        {
//                            Console.WriteLine("That file didn't seem to work.... Did you provide the correct location (aka absolute file path) for your input file? Please try again.");
//                        }
//                    }
//                }

//                void WritingAnOutputFile()
//               
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace FizzWriter.Class
//{
//    public class FizzBuzzOutputToFile
//    {
//        bool success = false;
//        int linesForInputFile = 0;
//        int linesPerOutputFile = 10;
//        string userTypedFilePath = ("");

//        public void LineCountForInputFile()
//        {


//            Console.WriteLine("Welcome to File Splitter!");
//            Console.WriteLine("In order to locate the desired input file, please provide an absolute file path including the file name and associated extension below...");
//            //string userTypedFilePath = Console.ReadLine();

//            while (!success)
//            {
//                try
//                {
//                    using (StreamReader sr = new StreamReader(userTypedFilePath))
//                    {
//                        int count = 1;
//                        int lineCount = 1;
//                        while (!sr.EndOfStream)
//                        {
//                            string line = sr.ReadLine();
//                            lineCount = int.Parse(sr.ReadLine());

//                            Console.WriteLine($"{count}) {line.Substring(0, 3)} {lineCount}");

//                        }
//                        count++;
//                        lineCount++;

//                    }
//                    success = true;
//                }
//                catch (IOException e)
//                {
//                    Console.WriteLine("That file didn't seem to work.... Did you provide the correct location (aka absolute file path) for your input file? Please try again.");
//                }
//            }
//        }

//        public void WritingAnOutputFile()
//        {
//            Console.WriteLine("Request linesPerOutputFile");
//            //int linesPerOutputFile = (int.Parse(Console.ReadLine()));
//            int count = 1;
//            int fileOutputTotal = (linesForInputFile / linesPerOutputFile);
//            string directory = " ";
//            string filename = " ";
//            for (int i = 1; i <= fileOutputTotal; i++)
//            {
//                directory = Environment.CurrentDirectory;
//                filename = "output.txt" + count;
//                string fullPath = Path.Combine(directory, filename);


//            }
//            count++;
//            Console.WriteLine($" Your output files were placed in the following directory:{directory}");
//            Console.WriteLine($" File names were autogenerated to reflect the split sequence.");
//            Console.WriteLine($"{filename} contains the information starting on line number {(fileOutputTotal * count) - linesPerOutputFile} through/n line number {fileOutputTotal * count} of your original document by the name of: {Path.GetFileName(userTypedFilePath)}.");


//            // Creates a new stream writer
//            // FALSE indicates that the file should be overwritten instead of appended to
//            using (StreamWriter sw = new StreamWriter(filename, true))
//            {
//                // Prints the current datetime

//                sw.WriteLine(DateTime.UtcNow);

//                // Prints Hello World!
//                sw.Write("Hello ");
//                sw.Write("World!");

//                // Prints blank line
//                sw.WriteLine();

//                // Prints
//                // Tech
//                // Elevator
//                sw.WriteLine("Tech");
//                sw.WriteLine("Elevator");
//            }

//            // After the using statement ends, file has now been written
//            // and closed for further writing
//        }
//    }
//}


//fizz buzz
//     isValid = true;

//                                public string FizzBuzz(int integerValue)
//{
//    for (integerValue = 1; integerValue < 300; integerValue++)
//    {
//        string outputAsString = " ";
//        if ((integerValue % 3 != 0) && (integerValue % 5 != 0))
//        {
//            outputAsString = integerValue.ToString();
//        }
//        else if ((integerValue % 3 == 0) && (integerValue % 5 == 0))
//        {
//            outputAsString = "FizzBuzz";
//        }
//        else if (integerValue % 3 == 0)
//        {
//            outputAsString = "Fizz";
//        }
//        else if (integerValue % 5 == 0)
//        {
//            outputAsString = "Buzz";
//        }
//        return outputAsString;
//    }
//    return FizzBuzz(integerValue);

//}

//                                {
//                                    //int n;
//                                    string FizzBuzz(int n)
//{


//}
//                            }

//                        }
//}


//====
// public static class ReadingAndWritingFiles
//{
//    public static void OpenAndWrite()
//    {
//        // Figure the full path of the input file and output file
//        string directory = Environment.CurrentDirectory;
//        string inputFile = "programminglanguages.txt";
//        string outputFile = "programminglanguages-FIXED.txt";
//        string inputFullPath = Path.Combine(directory, inputFile);
//        string outputFullPath = Path.Combine(directory, outputFile);

//        // Open the existing file with the typo using a StreamReader
//        using (StreamReader sr = new StreamReader(inputFullPath))
//        {
//            // Open a StreamWriter where we will output the file
//            using (StreamWriter sw = new StreamWriter(outputFullPath, true))
//            {
//                // For each line in the input file, read it in                    
//                while (!sr.EndOfStream)
//                {
//                    // Read an individual line
//                    string line = sr.ReadLine();

//                    // Replace the occurence of the word langauge with language
//                    string fixedLine = line.Replace("langauge", "language");

//                    // Write the new line to the output file
//                    sw.WriteLine(fixedLine);
//                }
//            }
//        }
//    }
//}
//}
