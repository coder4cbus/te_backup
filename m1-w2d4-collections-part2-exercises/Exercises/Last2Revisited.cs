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
         * Just when you thought it was safe to get back in the water --- last2Revisited!!!!
         * 
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears 
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1. 
         * 
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.  
         * 
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *  
         * last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         * 
         */
        public Dictionary<string, int> Last2Revisted(string[] words)
        {
            Dictionary<string, int> last2Revisted = new Dictionary<string, int>();

            foreach (string word in words)
            {
                int resultCount = 0;
                for (int i = 0; i < word.Length - 2; i++)
                {
                    //int resultCount = 0;
                    //when resultCount is placed here, instead of where it appears and is not marked out, desired value is not returned.  Why??
                    if ((word.Substring(i, 2)) == (word.Substring(word.Length - 2)))
                    {
                        resultCount += 1;
                    }
                    else
                    {
                        resultCount += 0;
                    }
                    last2Revisted[word] = resultCount;
                }  
            }
            return last2Revisted;
        }
    }
}
