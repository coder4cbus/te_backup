using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter.Class
{
    public class FileSplitOutput
    {
        //private instance variables




        //public properties 


        string userTypedFilePath = (@"C:\Users\eulry\eileenulry-c-exercises\m1-w4d3-file-io-part2-exercises\aaw.txt");
        int linesForInputFile;
        int linesPerOutputFile = 10;
        int predictNumberOfFilesInOutput;

        //constructor
        public void InfoForSplit()
        {
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Welcome to File Splitter!");
                Console.WriteLine("Please input the Path you want the files to be on:");
                userTypedFilePath = Console.ReadLine();
                if (!Directory.Exists(userTypedFilePath))
                {
                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(userTypedFilePath));
                        success = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("the Path you entered is NOT Valid");
                    }
                }
                success = true;
            }

            Console.WriteLine("In order to locate the desired input file, please provide an absolute file path including the file name and associated extension below...");
            //string userTypedFilePath = Console.ReadLine();

            success = false;

            while (!success)
            {
                try
                {
                    if (!File.Exists(userTypedFilePath))
                    {
                        throw new IOException();

                    }
                    else
                    {
                        success = true;
                        //CAll function 
                        //    WriteOnEveryFiles(getLineNumbers(destinationPath, sourceFileName), destinationPath, sourceFileName);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("That file path doesn't seem to work.... Did you provide the correct location (aka absolute file path) for your input file? Please try again." + e.Message);
                }
            }

            //DO I need to request a file name and extension also??

        }
        public int GetLineCountForInputFile(string userTypedFilePath)
        {
            int lineCount = 1;
            Console.WriteLine("How many lines of text (max) should there be in the split files?");
            try
            {
                int linesPerOutputFile = (int.Parse(Console.ReadLine()));
                if (linesPerOutputFile <= 0)
                {
                    throw new Exception();
                }

                bool success = false;
                while (!success)
                {
                    using (StreamReader sr = new StreamReader(userTypedFilePath))
                    {
                        int fileCount = 1;
                        string line = "";

                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            lineCount = int.Parse(sr.ReadLine());
                            fileCount++;

                            Console.WriteLine($" Contained by while loop:/n {line}) line Substring:{line.Substring(0, 3)} line count: {lineCount}");

                        }
                        Console.WriteLine($" Outside the while loop..../n count: {line}) line Substring:{line.Substring(0, 3)} line count: {lineCount}");
                        fileCount++;
                        lineCount++;
                        lineCount = linesForInputFile;

                        if ((lineCount < linesPerOutputFile) || (linesPerOutputFile < 0) || (lineCount < linesPerOutputFile))
                        {

                            Console.WriteLine("Document size does not allow for the requested split operation");
                        }
                        else if (lineCount % linesPerOutputFile == 0)
                        {
                            fileCount = (lineCount / linesPerOutputFile) + 1;
                        }
                        else
                        {
                            fileCount = (lineCount / linesPerOutputFile);
                        }
                    }
                    success = true;
                    Console.WriteLine($" Absolute path of input file {userTypedFilePath},/n Lines found in the original file {linesForInputFile},/n Max lines in output file {linesPerOutputFile },/n Number of output files to be produced:{predictNumberOfFilesInOutput}/n, ");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Invalid Number of Lines" + e.Message);
            }
            return lineCount;
        }
    }

    //public void WritingAnOutputFile()
    //{
    //    int fileOutputTotal = (linesForInputFile / linesPerOutputFile);
    //    int fileCount = 1;
    //    string directory = " ";
    //    string filename = " ";
    //    for (int i = fileCount; i <= fileOutputTotal; i++)
    //    {
    //        directory = Environment.CurrentDirectory;
    //        filename = "output.txt" + fileCount;
    //        string fullPath = Path.Combine(directory, filename);

    //    }
    //    fileCount++;

    //Console.WriteLine($" Your output files were placed in the following directory:{directory}");
    //Console.WriteLine($" File names were autogenerated to reflect the split sequence.");
    //Console.WriteLine($"{filename} contains the information starting on line number {(linesPerOutputFile * fileCount) - linesPerOutputFile} through/n line number {linesPerOutputFile * fileCount} of your original document by the name of: {Path.GetFileName(userTypedFilePath)}.");
    //Console.WriteLine($"Output file number predicted {predictNumberOfFilesInOutput}/n Total File Output that resulted {fileOutputTotal}");
}





