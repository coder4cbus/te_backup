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
         Given an array of ints length 3, return the sum of all the elements.
         sum3([1, 2, 3]) → 6
         sum3([5, 11, 2]) → 18
         sum3([7, 0, 0]) → 7
         */
        public int Sum3(int[] nums)
        {
            int sumArray = 0;

            if (nums.Length == 3)
            {
                sumArray = (nums[0]+nums[1]+nums[2]);
            }
            else 
            {
                sumArray = 0;
            }
           
            return sumArray;
        }

    }
}
