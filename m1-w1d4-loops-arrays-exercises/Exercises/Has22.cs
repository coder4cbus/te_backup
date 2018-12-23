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
         Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         has22([1, 2, 2]) → true
         has22([1, 2, 1, 2]) → false
         has22([2, 1, 2]) → false
         */
        public bool Has22(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                bool lotsOfTwos = false;

                if ((nums[i] == 2) && (nums[i + 1] == 2))
                {
                    lotsOfTwos = true;
                }
                else if ((nums[i+1] == 2) && (nums[i + 2] == 2))
                {
                    lotsOfTwos = true;
                }
                else
                {
                    lotsOfTwos = false;
                }
                return lotsOfTwos;
            }
            return false;
        }

    }
}