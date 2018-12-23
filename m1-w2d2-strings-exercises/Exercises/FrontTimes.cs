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
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or 
         whatever is there if the string is less than length 3. Return n copies of the front;
         frontTimes("Chocolate", 2) → "ChoCho"
         frontTimes("Chocolate", 3) → "ChoChoCho"
         frontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
            string repeatMiniNews = "";
            if (str.Length >= 3)
            {
                string mini3News = str.Substring(0, 3);
                string repeatMini3News = new StringBuilder(mini3News.Length * n).Insert(0, mini3News, n).ToString();
                repeatMiniNews = repeatMini3News;
            }
            else if (str.Length == 2)
            {
                string mini2News = str.Substring(0, 2);
                string repeatMini2News = new StringBuilder(mini2News.Length * n).Insert(0, mini2News, n).ToString();
                repeatMiniNews = repeatMini2News;
            }
            else if (str.Length == 1)
            {
                string mini1News = str.Substring(0, 1);
                string repeatMini1News = new StringBuilder(mini1News.Length * n).Insert(0, mini1News, n).ToString();
                repeatMiniNews = repeatMini1News;
            }
            else
            {
                Console.WriteLine("String is null or Empty");
            }
            return repeatMiniNews;
        }
    }
}
