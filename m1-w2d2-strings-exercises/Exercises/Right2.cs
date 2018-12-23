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
         Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
         The string length will be at least 2.
         right2("Hello") → "loHel"
         right2("java") → "vaja"
         right2("Hi") → "Hi"
         */
        public string Right2(string str)
        {
            string startFirstTwo;
            string lastTwoChar = str.Substring((str.Length-2), 2);
            string noTwoChar = str.Substring(0, (str.Length - 2));
            startFirstTwo = lastTwoChar + noTwoChar;
            return startFirstTwo;
        }
    }
}
