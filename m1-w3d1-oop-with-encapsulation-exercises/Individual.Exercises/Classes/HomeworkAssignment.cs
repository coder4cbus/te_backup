using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        //properties list below...
        private int totalMarks;
        private int possibleMarks;
        private string submitterName;
        private string letterGrade;

        //accessors
        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }
            set
            {
                totalMarks = value;
            }
        }

        public int PossibleMarks
        {
            get;
        }

        public string SubmitterName
        {
            get
            {
                return submitterName;
            }

        }
        public string LetterGrade
        {
            get
            {
                return GetLetterGrade(possibleMarks, totalMarks);
            }
        }
        //constructor below
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            this.submitterName = submitterName;
        }
        // method?
        public string GetLetterGrade(int possibleMarks, int totalMarks)
        {
            int percentageGrade = (int)((double)TotalMarks / (double)PossibleMarks * 100.00);
            
            letterGrade = " ";

            if (percentageGrade >=90 )
            {
                letterGrade = "A";
            }
            if ((percentageGrade >= 80) && (percentageGrade < 90))
            {
                letterGrade = "B";
            }
            if ((percentageGrade >= 70) && (percentageGrade < 80))
            {
                letterGrade = "C";
            }
            if ((percentageGrade >= 60) && (percentageGrade < 70))
            {
                letterGrade = "D";
            }
            else if (percentageGrade < 60)
            {
                letterGrade = "F";
            }
            return letterGrade;
        }

    }
}


