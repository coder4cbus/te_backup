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
        Given three int values, a b c, return the largest.
        intMax(1, 2, 3) → 3
        intMax(1, 3, 2) → 3
        intMax(3, 2, 1) → 3
        */
        public int IntMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (a < b && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

    }
}
