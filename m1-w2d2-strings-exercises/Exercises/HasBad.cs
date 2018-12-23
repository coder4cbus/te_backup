﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with 
         "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0. Note: use .equals()
         to compare 2 strings.
         hasBad("badxx") → true
         hasBad("xbadxx") → true
         hasBad("xxbadxx") → false
         */
        public bool HasBad(string str)
        {
            bool resultHasBad;
            if ((str.Contains("bad")) && (str.IndexOf("bad") == 0) || (str.IndexOf("bad") == 1))
            {
                resultHasBad = true;
            }
            else
            {
                resultHasBad = false;
            }
            return resultHasBad;
        }
    }
}
