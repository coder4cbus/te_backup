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
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another 
         of the values, it does not count towards the sum.
         loneSum(1, 2, 3) → 6
         loneSum(3, 2, 3) → 2
         loneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c)
        {
            if (a != b && b != c && a != c)
            {
                return (a + b + c);
            }
            else if (a == b && b !=c)
            {
                return c;
            }
            else if (b == c && c !=a)
            {
                return a;
            }
            else if (a == c && c !=b)
            {
                return b;
            }
            else
            {
                return 0;
            }
        }

    }
}
