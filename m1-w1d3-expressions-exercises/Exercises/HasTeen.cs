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
        We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, 
        return true if 1 or more of them are teen.
        hasTeen(13, 20, 10) → true
        hasTeen(20, 19, 10) → true
        hasTeen(20, 10, 13) → true
        */
        public bool HasTeen(int a, int b, int c)
        {
            if (a >= 13 || a <= 19) 
            {
                return true;
            }
            else if (b >= 13 || b <= 19)
            {
                return true;
            }
            else if (c >= 13 || c <= 19)
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
