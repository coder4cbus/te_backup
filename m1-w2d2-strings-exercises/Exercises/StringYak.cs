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
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but 
         the "a" can be any char. The "yak" strings will not overlap.
         stringYak("yakpak") → "pak"
         stringYak("pakyak") → "pak"
         stringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            string noStringYak = "";
            for (int i=0; i < str.Length; i++)
            {
                if ((i + 2 < str.Length) && (str[i] == 'y') && (str[i + 2] == 'k'))
                {
                    i += 2;
                }
                else
                {
                    noStringYak += str[i];
                }

            }
            return noStringYak;
        }
    }
}