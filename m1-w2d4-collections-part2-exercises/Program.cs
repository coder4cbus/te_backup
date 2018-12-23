using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;


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

            //Console.WriteLine("Is your search case sensitive? If (Y)es, enter Y and for (N)o enter N");
            //bool caseSensitive = (Console.ReadLine().ToLower() == "y");

            //Console.WriteLine("A file location is needed to conduct thie search.");
            //Console.WriteLine("Please provide an absolute file path below.");
            //string userTypedFilePath = Console.ReadLine();
            //string documentPath = "@" + userTypedFilePath;
            //Console.Write("Please start your file path by typing an '@' symbol.");

            //Console.WriteLine("To confirm the previous entry, please provide your document's file name and associated extension. For example, Input.txt");
            //string userTypedFileName = Console.ReadLine();
            //string inputFileName = "@" + userTypedFileName;

            //Console.WriteLine("The file path that was registered is: " + documentPath);
            //Console.WriteLine("The file you identified for this search is: " + inputFileName);

            //Console.WriteLine("Is this correct? If (Y)es, enter Y and for (N)o enter N");
            //bool userConfirmationOfInput = (Console.ReadLine().ToLower() == "y");

            // Check to see if specified file and directory exist
            //bool fileExists = File.Exists("@" + documentPath);
            //bool directoryExists = Directory.Exists("@" + documentPath);
            //string response = " ";

            //if (directoryExists && fileExists)
            //{
                //// Get the parent directory of the directory path
                //DirectoryInfo parentDirectory = Directory.GetParent(documentPath);
                //// Open and search the file
                //string directory = Environment.CurrentDirectory;

                //string userSpecifiedFilePath = Path.Combine(documentPath, inputFileName);
            //How do I make the file path and document inputs into constants?  Does not appear to be permissable due to collection of info via variable name?
            // Create the full path
            string fullPath = Path.Combine(@"C:\Users\eulry\eileenulry-c-exercises\m1-w4d2-file-io-part1-exercises", @"aaw.txt");
            // Start with the file path to input
            //string directory = Environment.CurrentDirectory;
            string inputFileName = "aaw.txt";

            // Create the full path
            //string fullPath = Path.Combine(directory, inputFileName);
            Console.WriteLine($"{fullPath}");
            //Console.ReadLine();
            // Wrap the effort in a try-catch block to handle any exceptions
            try
            {
                //Open a StreamReader with the using statement
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    // Read the file until the end of the stream is reached
                    // EndOfStream is a "marker" that the stream uses to determine 
                    // if it has reached the end
                    // As we read forward the marker moves forward like a typewriter.
                  
                    while (!sr.EndOfStream)
                    {
                        // Read in the line
                        int i = 1;
                        string line = sr.ReadLine();
                        if ((line.IndexOf(inputFileName, StringComparison.CurrentCultureIgnoreCase) > 0) ||
                                (line.IndexOf(inputFileName) > 0)) 
                            {
                            while (!sr.EndOfStream )
                            {
                                Console.WriteLine("{i}) {line}");
                            }
                            
                        }

                        i++;
                    }
                }
            }
            catch (IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
        }
        //==
                //try
                //{
                //    using (StreamReader sr = new StreamReader(documentPath))
                //    {
                //        int i = 1;
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            bool lineContainsWord = (!caseSensitive && line.IndexOf(inputFileName, StringComparison.CurrentCultureIgnoreCase) > 0) ||
                //                line.IndexOf(inputFileName) > 0;

                //            if (lineContainsWord)
                //            {
                //                Console.WriteLine($"{i}) {line}");
                //            }

                //            i++;
                //        }
                //    }
                //}
                //catch (IOException e)
                //{
                //    Console.WriteLine("Error reading the file");
                //    Console.WriteLine(e.Message);
                //}
            //}
            //else if (!directoryExists)
            //{
            //    response = "File path that you entered is not valid. Please try again...";
            //    //call function to restart the program
            //}
            //Console.WriteLine(response);
        }
    }
//}

