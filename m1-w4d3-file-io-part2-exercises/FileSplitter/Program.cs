using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileSplitter.Class;



namespace FileSplitter
{
    class Program
    {

        static void Main(string[] args)
        {
            FileSplitTime.GetUserInput();
            FileSplitTime.GetLineCount();
            FileSplitTime.EstimateTotalFiles();
            //FileSplitTime.SplitFile(numOfFiles, destinationPath, userFileName);
            FileSplitTime.ConsoleOutput();

        }

    }
}
