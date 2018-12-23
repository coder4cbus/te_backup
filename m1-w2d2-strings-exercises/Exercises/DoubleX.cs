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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         doubleX("axxbb") → true
         doubleX("axaxax") → false
         doubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            bool resultDoubleX = false;
            for (int i = 0; i < (str.Length - 1); i++)
            {
                if (str.Substring(i, 2) == "xx")
                {
                    resultDoubleX = true;
                    break;
                }

                else if (str.Substring(i, 1) == "x")
                {
                    resultDoubleX = false;
                    break;
                }
            }
            return resultDoubleX;
        }
    }
}