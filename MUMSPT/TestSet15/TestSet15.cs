using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet15
{
   public static class TestSet15
    {
        /// <summary>
        /// Write a method named getExponent(n, p) that returns the largest 
        /// exponent x such that px evenly divides n. If p is &lt;= 1 the method should return -1.
        /// For example, getExponent(162, 3) returns 4 because 162 = 21 * 34, 
        /// therefore the value of x here is 4.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int getExponent(int n, int p)
        {
            if (p <= 1) return -1;
            bool isok = false;
            int x = 0;
          double temp = n;
            do
            {

                temp = temp / p;
                isok=(temp % 1 == 0);
                if (isok)
                {
                    x++;
                }

            } while (isok);

            return x;
        }

        /// <summary>
        /// Define an array to be a 121 array if all 
        /// its elements are either 1 or 2 and it begins with one or 
        /// more 1s followed by a one or more 2s and then ends with 
        /// the same number of 1s that it begins with. Write a method 
        /// named is121Array that returns 1 if its array argument is a 121 array, 
        /// otherwise, it returns 0
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int is121Array(int[] a)
        {
            int is121 = 1;
            int fristonecount = 0, secondonecount=0, twocount = 0;
            int prevelement = 0;
            int changecount = 0;
            int firstelement = a[0];
            if (firstelement != 1) is121 = 0;
            for (int i = 0; i < a.Length && is121==1; i++)
            {
               // if (a[i] != 1 && a[i] != 2) is121 = 0;
                if (a[i] == 2) twocount++;

                if (prevelement != a[i]) changecount++;
                if(changecount ==1) if (a[i] == 1) fristonecount++;
                if(changecount == 3) if (a[i] == 1) secondonecount++;
                if (changecount > 3) is121 = 0;

                prevelement = a[i];
            }
            if (twocount < 1) is121 = 0;
            if (fristonecount != secondonecount) is121 = 0;
            return is121;
        }


        /// <summary>
        /// A binary representation of a number can be used to select elements from an array. For example,
        /// n:           88 = 23 + 24 + 26  (1011000)
        /// array:     8, 4, 9, 0, 3, 1, 2
        /// indexes  0  1  2  3  4  5  6
        /// selected              *  *     *
        /// result                  0, 3,    2
        /// so the result of filtering {8, 4, 9, 0, 3, 1, 2} using 88 would be {0, 3, 2}
        /// In the above, the elements that are selected are those whose indices are 
        /// used as exponents in the binary representation of 88. 
        /// In other words, a[3], a[4], and a[6] are selected for the result 
        /// because 3, 4 and 6 are the powers of 2 that sum to 88.
        /// Write a method named filterArray that takes an array and a 
        /// non-negative integer and returns the result of filtering 
        /// the array using the binary representation of the integer. 
        /// The returned array must big enough to contain the filtered 
        /// elements and no bigger. So in the above example, the returned 
        /// array has length of 3, not 7 (which is the size of the original array.) 
        /// Futhermore, if the input array is not big enough to contain 
        /// all the selected elements, then the method returns null. 
        /// For example, if n=3 is used to filter the array a = {18}, 
        /// the method should return null because 3=20+21 and hence 
        /// requires that the array have at least 2 elements a[0] and a[1], 
        /// but there is no a[1].
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] filterArray(int[] a, int n)
        {
            int indexcount = 0;
            int digitindex = 0;
           
            int[] temp = new int[a.Length];
            do
            {
                int ldigit = n % 2;
                if(ldigit ==1)
                {
                    temp[indexcount] = digitindex;
                    indexcount++;
                }
                n = n / 2;
                digitindex++;
            } while (n>0);

            int[] filterarray = new int[indexcount];
            for (int i = 0; i < indexcount; i++)
            {
                int index = temp[i];
                if (index > a.Length-1) return null;
                filterarray[i] = a[index];

            }

            return filterarray;
        }
    }
}
