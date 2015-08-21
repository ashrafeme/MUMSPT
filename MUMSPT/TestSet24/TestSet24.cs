using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet24
{
   public static class TestSet24
    {
        /// <summary>
        /// A number n is triangular if n == 1 + 2 +…+j for some j. Write a function
        /// int isTriangular(int n)
        /// that returns 1 if n is a triangular number, otherwise it returns 0. 
        /// The first 4 triangular numbers are 1 (j=1), 3 (j=2), 6, (j=3), 10 (j=4).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isTriangular(int n)
        {
            int isTriangular = 0;


            int sum = 0;

            for (int j = 0; j <= n && isTriangular==0; j++)
            {
                sum += j;
                if(sum == n)
                {
                    isTriangular = 1;
                }
            }

            return isTriangular;
        }

        /// <summary>
        /// Define an array to be a Mercurial array 
        /// if a 3 does not occur between any two 1s. 
        /// Write a function named isMercurial that 
        /// returns 1 if its array argument is a 
        /// Mercurial array, otherwise it returns 0
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isMercurial(int[] a)
        {
            int isMercurial = 1;

            int firstone = -1, secondone = -1, firstthree = -1;

            for (int i = 0; i < a.Length && isMercurial == 1; i++)
            {
                int current = a[i];
                if (current == 1)
                {
                    if (firstthree == -1)
                    {
                        firstone = i;
                    }
                    else
                    {
                        if (firstthree != -1)
                        {
                            secondone = i;
                            if (firstthree != -1 && firstone != -1 && secondone != -1)
                            {
                                if (firstone < firstthree && firstthree < secondone)
                                {
                                    isMercurial = 0;
                                }
                            }
                        }
                    }
                }
                else if (current == 3)
                    if (firstone != -1)
                        firstthree = i;
            }

            if (firstthree != -1 && firstone != -1 && secondone != -1)
            {
                if (firstone < firstthree && firstthree < secondone)
                {
                    isMercurial = 0;
                }
            }

            return isMercurial;
        }

        /// <summary>
        /// An array is defined to be a 235 array 
        /// if the number of elements divisible by 2 
        /// plus the number of elements divisible by 3 
        /// plus the number of elements divisible by 5 
        /// plus the number of elements not divisible by 2, 3, 
        /// or 5 is equal to the number of elements of the array. 
        /// Write a method named is123Array that returns 
        /// 1 if its array argument is a 235 array, otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int is235Array(int[] a)
        {
            int is235Array = 0;
            int div2count = 0, div3count = 0, div5count = 0, othercount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool isother = true;
                int current = a[i];
                if (Helper.IsdivisibleBy(current, 2))
                {
                    div2count++;
                    isother = false;
                }
                if (Helper.IsdivisibleBy(current, 3))
                {
                    div3count++;
                    isother = false;
                }
                if (Helper.IsdivisibleBy(current, 5))
                {
                    div5count++;
                    isother = false;
                }
                if (isother)
                    othercount++;

            }

            if (div2count + div3count + div5count + othercount == a.Length)
                is235Array = 1;
            return is235Array;
        }
    }
}
