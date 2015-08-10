using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet10
{
    public static class TestSet10
    {
        /// <summary>
        /// Write a function named sameNumberOfFactors that takes two integer 
        /// arguments and returns 1 if they have the same number of factors. 
        /// If either argument is negative, return -1. Otherwise return 0.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int sameNumberOfFactors(int n1, int n2)
        {
            int isSame = 0;

            // check for negative numbers
            if (n1 < 0 || n2 < 0) isSame = -1;

            // check if the same number
            if (n1 == n2) isSame = 1;

            if (isSame == 0)
            {
                int n1count = 0, n2count = 0;
                // get the factors of n1

                for (int i = 1; i <= n1; i++)
                {
                    if (n1 % i == 0) n1count++;
                }

                for (int i = 1; i <= n2; i++)
                {
                    if (n2 % i == 0) n2count++;
                }

                if (n1count == n2count) isSame = 1;
            }

            return isSame;
        }

        /// <summary>
        ///  Solved in TestSet9
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static int equivalentArrays(int[] a1, int[] a2)
        {
            return TestSet9.TestSet9.equivalentArrays(a1, a2);
        }

        public static int hasSingleMaximum(int[] a)
        {
            int hasSingle = 0;
            int maxcount = 0, max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > max) {
                    max = a[i];
                    maxcount = 1;
                }else if(a[i] == max)
                {
                    maxcount++;
                }
            }
            if (maxcount == 1) hasSingle = 1;
              
            return hasSingle;
        }
    }
}
