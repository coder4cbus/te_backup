using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a version without both the first and last char of the string. The string 
         may be any length, including 0.
         withouEnd2("Hello") → "ell"
         withouEnd2("abc") → "b"
         withouEnd2("ab") → ""
         */
        public string WithouEnd2(string str)
        {
            string noEnds2 = "";
            if (str.Length <= 2)
            {
                noEnds2 = "";
            }
            else if (str.Length > 2)
            {
                string noFirst = str.Substring(1, (str.Length - 1));
                string noEnd = noFirst.Substring(0, (noFirst.Length - 1));
                noEnds2 = noEnd;
            }
            else if (str.Length == 0)
            {
                noEnds2 = "Does Not Exist";
            }
            return noEnds2;
        }
    }
}
