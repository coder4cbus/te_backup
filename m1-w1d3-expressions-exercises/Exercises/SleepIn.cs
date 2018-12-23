﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
	     The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on 
	     vacation. We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.
	     sleepIn(false, false) → true
	     sleepIn(true, false) → false
	     sleepIn(false, true) → true
	     */
        public bool SleepIn(bool weekday, bool vacation)
        {
            if (!weekday || vacation)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

    }
}
