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
         Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and". 
         The string length will be at least 3.
         middleThree("Candy") → "and"
         middleThree("and") → "and"
         middleThree("solving") → "lvi"
         */
        public string MiddleThree(string str)
        {
            int halfStrLength = (str.Length/ 2);
             string middleThree = str.Substring((halfStrLength -1), 3);
            return middleThree;
        }
    }
}