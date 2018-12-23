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
         order 
         array2List( {"Apple", "Orange", "Banana"} )  ->  ["Apple", "Orange", "Banana"]
         array2List( {"Red", "Orange", "Yellow"} )  ->  ["Red", "Orange", "Yellow"]
         array2List( {"Left", "Right", "Forward", "Back"} )  ->  ["Left", "Right", "Forward", "Back"] 
         */
        public List<string> Array2List(string[] stringArray)
        {
            List<string> stringList= new List<string>(stringArray);
            return stringList;
        }
                
    }
}
