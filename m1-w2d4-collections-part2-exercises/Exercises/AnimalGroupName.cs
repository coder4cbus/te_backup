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
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalGroups = new Dictionary<string, string>()
            //animalsGroups["RHINO"] = "Crash";
            {
                { "GIRAFFE", "Tower"},
                { "RHINO", "Crash"},
                { "LION", "Pride"}

            };
            var key = animalName.ToUpper();
            string animalResult;
            if (animalGroups.ContainsKey(key))
            {
                animalResult = animalGroups[key];
            }
            else
            {
                animalResult = "unknown";
            }
            return animalResult;
        }
    }
}

//return animalGroups.ContainsKey(key) ?
//animalGroups[key] :
//"unknown";