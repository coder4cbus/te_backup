using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         interleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            int minLength = Math.Min(listOne.Count, listTwo.Count);
            List<int> twoListResult = new List<int>();

            for (int i = 0; i < minLength; i++)
            {
                twoListResult.Add(listOne[i]);
                twoListResult.Add(listTwo[i]);
            }

            // Add remainder Logic
            List<int> longList = (listOne.Count > listTwo.Count) ? listOne : listTwo;
            List<int> sublist = longList.GetRange(minLength, longList.Count - minLength);
            twoListResult.AddRange(sublist);

            return twoListResult;
        }
    }
}