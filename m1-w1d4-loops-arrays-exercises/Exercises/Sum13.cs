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
         Return the sum of the numbers in the array, returning 0 for an empty array. Except the number 
         13 is very unlucky, so it does not count and numbers that come immediately after a 13 also do 
         not count.
         sum13([1, 2, 2, 1]) → 6
         sum13([1, 1]) → 2
         sum13([1, 2, 2, 1, 13]) → 6
         */

        public int Sum13(int[] nums)
        {
            int sum13Array = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Length == 0)
                {
                    sum13Array = 0;
                }
                else if (nums[i] == 13)
                {
                    sum13Array += 0;
                    break;
                }
                else if (nums[i] != 13)
                {
                    sum13Array += nums[i];
                }
                else 
                {
                    sum13Array = 0;
                }
            }
            return sum13Array;
        }

    }
}
