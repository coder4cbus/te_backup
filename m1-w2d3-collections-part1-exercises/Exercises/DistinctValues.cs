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
         Given a list of strings, return a list that contains the distinct values. In other words, no value is to be
         included more than once in the returned list. (Hint: Think HashSet)
         distinctValues( ["red", "yellow", "green", "yellow", "blue", "green", "purple"] ) -> ["red", "yellow", "green", "blue", "purple"]
         distinctValues( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"] ) -> ["jingle", "bells", "all", "the", "way"]
         */
        public List<string> DistinctValues(List<string> stringList)
        {
            foreach (string value in stringList)
            {
                Console.WriteLine("Before: {0}", value);
            }
            List<string> distinct = stringList.Distinct().ToList();

            foreach (string value in stringList)
            {
                Console.WriteLine("After: {0}", value);
            }
            return distinct;
        }
    }
}
