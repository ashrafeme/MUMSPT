using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet5
{
   public static class TestSet5
    {
        /// <summary>
        /// A perfect number is one that is the sum of its factors,
        /// excluding itself. The 1st perfect number is 6 because 6 = 1 + 2 + 3.
        ///  The 2nd perfect number is 28 which equals 1 + 2 + 4 + 7 + 14.
        ///  The third is 496 = 1 + 2 + 4 + 8 + 16 + 31 + 62 + 124 + 248.
       ///  In each case, the number is the sum of all its factors excluding itself.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static int henry(int i, int j)
        {
            int henry = 0,currentperfect = 0;
            int iperfect = 0, jperfect = 0, perfectindex = 0;
            int n = 1;
            do
            {
                for (int k = 1; k < n; k++)
                {
                    if (n % k == 0)
                    {
                        currentperfect += k;
                    }
                }
              if(currentperfect == n)
                {
                    perfectindex++;
                    if(perfectindex == i)
                    {
                        iperfect = n;
                    }
                    if(perfectindex == j)
                    {
                        jperfect = n;
                    }
                }
                n++;
                currentperfect = 0;
                henry = iperfect + jperfect;
            } while (henry == 0 || iperfect == 0 || jperfect == 0);

            return henry;
        }


        /// <summary>
        /// Write a method named isDivisible that takes an integer 
        /// array and a divisor and returns 1 if all its elements 
        /// are divided by the divisor with no remainder. Otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static int isDivisible(int[] a, int divisor)
        {
            int isDivisible = 1;

            for (int i = 0; i < a.Length && isDivisible == 1; i++)
            {
                if(a[i] % divisor != 0)
                {
                    isDivisible = 0;
                }
            }
            return isDivisible;

        }

        /// <summary>
        /// An array is defined to be n-unique if exactly one pair of its elements sum to n.
        ///  For example, the array {2, 7,  3, 4} is 5-unique because only a[0] and a[2] sum to 5.
        ///  But the array {2, 3, 3, 7} is not 5-unique because a[0] + a[1] = 5 and a[0] + a[2] = 5.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isNUnique(int[] a, int n)
        {
            int isNUnique = 0, occurCount = 0;

            for (int i = 0; i < a.Length && occurCount < 2; i++)
            {
                for (int j = i+1; j < a.Length && occurCount<2; j++)
                {
                    if(a[i]+a[j] == n)
                    {
                        occurCount++;
                    }

                }
            }

            return isNUnique = (occurCount == 1 ? 1 : 0);
        }
    }
}
