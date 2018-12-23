using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {
        //variables, but cannot be used in conjunction with the automatic properties. It's an either or situation.
        //private decimal itemPrice;
        public int groupsOf5DifferentBooks;
        public int groupsOf4DifferentBooks;
        public int groupsOf3DifferentBooks;
        public int groupsOf2DifferentBooks;
        public int updateGroupsOf5;
        public int updateGroupsOf4;
        public int updateGroupsOf3;
        public int sameBookTitle;
        public int totalNumber = 0;
        public int[] totalsForEachTitle = { 0, 0, 0, 0, 0 };
        public int[] decendingTotalsByBookTitle = new int[4];
        //Meaning for Above Array...
        //totalsForEachTitle [0] = book1;
        //totalsForEachTitle [1] = book1;
        //totalsForEachTitle [2] = book1;
        //totalsForEachTitle [3] = book1;
        //totalsForEachTitle [4] = book1;
        int sumOfTitle0Books = 0;
        int sumOfTitle1Books = 0;
        int sumOfTitle2Books = 0;
        int sumOfTitle3Books = 0;
        int sumOfTitle4Books = 0;
        decimal sameTitle;
        decimal booksWith2Titles;
        decimal booksWith3Titles;
        decimal booksWith4Titles;
        decimal booksWith5Titles;
        decimal noBooks;
        //automatic properties

        public decimal ItemPrice
        { get; set; }

        //default constructor
        public KataPotter()
        {
        }
        //method
        public int GetTitleCount(int[] books)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (books[i] == 0)
                {
                    totalNumber += 1;
                    sumOfTitle0Books = totalNumber;
                }
                else if (books[i] == 1)
                {
                    totalNumber += 1;
                    sumOfTitle1Books = totalNumber;
                }
                else if (books[i] == 2)
                {
                    totalNumber += 1;
                    sumOfTitle2Books = totalNumber;
                }
                else if (books[i] == 3)
                {
                    totalNumber += 1;
                    sumOfTitle3Books = totalNumber;
                }
                else if (books[i] == 4)
                {
                    totalNumber += 1;
                    sumOfTitle4Books = totalNumber;
                }
                return totalNumber;
            }
            int[] totalsForEachTitle = { sumOfTitle0Books, sumOfTitle1Books, sumOfTitle2Books, sumOfTitle3Books, sumOfTitle4Books };
            return totalsForEachTitle[4];
        }


        public int GetTitleRank(int[] totalsForEachTitle)
        {
            Array.Sort(totalsForEachTitle);
            foreach (var totalOfOneTitle in totalsForEachTitle)
            {
                decendingTotalsByBookTitle[4] += totalOfOneTitle;
            }
            return decendingTotalsByBookTitle[4];
        }

        public int GetGroupsOfDifferentBooks(int[] decendingTotalsByBookTitle)
        {
            if (decendingTotalsByBookTitle[4] == decendingTotalsByBookTitle[3])
            {
                groupsOf5DifferentBooks = decendingTotalsByBookTitle[4];
                groupsOf5DifferentBooks = decendingTotalsByBookTitle[3];
            }
            else if (decendingTotalsByBookTitle[4] < decendingTotalsByBookTitle[3])
            {
                groupsOf5DifferentBooks = decendingTotalsByBookTitle[4];
            }
            else if (decendingTotalsByBookTitle[3] == decendingTotalsByBookTitle[2])
            {
                groupsOf4DifferentBooks = decendingTotalsByBookTitle[3];
                groupsOf4DifferentBooks = decendingTotalsByBookTitle[2];
            }
            else if (decendingTotalsByBookTitle[3] < decendingTotalsByBookTitle[2])
            {
                groupsOf4DifferentBooks = decendingTotalsByBookTitle[3];
            }
            else if (decendingTotalsByBookTitle[2] == decendingTotalsByBookTitle[1])
            {
                groupsOf3DifferentBooks = decendingTotalsByBookTitle[2];
                groupsOf3DifferentBooks = decendingTotalsByBookTitle[1];
            }
            else if (decendingTotalsByBookTitle[2] < decendingTotalsByBookTitle[1])
            {
                groupsOf3DifferentBooks = decendingTotalsByBookTitle[2];
            }
            else if (decendingTotalsByBookTitle[1] == decendingTotalsByBookTitle[0])
            {
                groupsOf2DifferentBooks = decendingTotalsByBookTitle[1];
                groupsOf2DifferentBooks = decendingTotalsByBookTitle[0];
            }
            else if (decendingTotalsByBookTitle[1] < decendingTotalsByBookTitle[0])
            {
                groupsOf2DifferentBooks = decendingTotalsByBookTitle[1];
            }
            else
            {
                sameBookTitle = decendingTotalsByBookTitle[0];
            }
            return (GetGroupsOfDifferentBooks(decendingTotalsByBookTitle));
        }

        public int GetBookGroupWithBestPrice()
        {
            if (groupsOf5DifferentBooks > groupsOf3DifferentBooks)
            {
                updateGroupsOf5 = groupsOf5DifferentBooks - groupsOf3DifferentBooks;
                updateGroupsOf4 = groupsOf3DifferentBooks;
                updateGroupsOf3 = 0;
            }
            else if (groupsOf3DifferentBooks > groupsOf5DifferentBooks)
            {
                updateGroupsOf3 = groupsOf3DifferentBooks - groupsOf5DifferentBooks;
                updateGroupsOf4 = groupsOf5DifferentBooks;
                updateGroupsOf5 = 0;
            }
            return GetBookGroupWithBestPrice();
        }

        public decimal GetCost(int[] books)
        {
            decimal resultTotal = 0.00M;
            if (books.Length < 1)
            {
                noBooks = 0.00M;
            }
            else if (books.Length >= 5)
            {
                booksWith5Titles = (updateGroupsOf5) * 5 * 8 * 0.75M;
            }
            else if (books.Length >= 4)
            {
                booksWith4Titles = (updateGroupsOf4 + groupsOf4DifferentBooks) * 4 * 8 * 0.80M;
            }
            else if (books.Length >= 3)
            {
                booksWith3Titles = (updateGroupsOf3) * 3 * 8 * 0.90M;
            }
            else if (books.Length >= 2)
            {
                booksWith2Titles = (groupsOf2DifferentBooks) * 3 * 8 * 0.95M;
            }
            else if (books.Length >= 1)
            {
                sameTitle = sameBookTitle * 1 * 8;
            }
            return resultTotal = (sameTitle + booksWith2Titles + booksWith3Titles + booksWith4Titles + booksWith5Titles + noBooks);
        }

    }
}