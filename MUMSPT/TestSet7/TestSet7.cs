using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet7
{
   public static class TestSet7
    {
        /// <summary>
        /// A simple pattern match on the elements of an array A can be 
        /// defined using another array P. Each element n of P 
        /// is negative or positive (never zero) and defines the 
        /// number of elements in a sequence in A. The first sequence 
        /// in A starts at A[0] and its length is defined by P[0]. The 
        /// second sequence follows the first sequence and its length is 
        /// defined by P[1] and so on. Furthermore, for n in P, if n is 
        /// positive then the sequence of n elements of A must all be positive.
        /// Otherwise the sequence of abs(n) elements must all be negative. 
        /// The sum of the absolute values of the elements of P must be the length of A.  
        /// For example, consider the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int matches(int[] a, int[] p)
        {
            bool isNegative = false;
            int isMatches = 1, upperindex = 0,lowinddex = 0;
            for (int i = 0; i < p.Length && isMatches==1; i++)
            {
                isNegative = (p[i] < 0);
                upperindex = lowinddex + Math.Abs(p[i]);

                for (int j = lowinddex; j < upperindex && isMatches ==1; j++)
                {
                    if (isNegative)
                    {
                        if (a[j] > 0) isMatches = 0;
                    }
                    else
                    {
                        if (a[j] < 0) isMatches = 0;
                    }
                }
                lowinddex = upperindex;
            }

            return isMatches;
        }

        /// <summary>
        /// Define a stacked number to be a number that is the sum of the first n 
        /// positive integers for some n. The first 5 stacked numbers are
        /// 1 = 1
        /// 3 = 1 + 2
        /// 6 = 1 + 2 + 3
        /// 10 = 1 + 2 + 3+ 4
        /// 15 = 1 + 2 + 3 + 4 + 5
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isStacked(int n)
        {
            int isStacked = 0;
            int sum = 0;
            int index = 0;
            do
            {
                sum += index;
                if (sum == n) isStacked = 1;
                index++;
                
            } while (sum <= n);

            return isStacked;
        }


        /// <summary>
        /// Define an array to be sum-safe if none of its elements is equal to the sum of its elements. 
        /// The array a = {5, -5, 0} is not sum-safe because the sum of 
        /// its elements is 0 and a[2] == 0. However, the array a = {5, -2, 1} is 
        /// sum-safe because the sum of its elements is 4 and none of its elements equal 4.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isSumSafe(int[] a)
        {
            int isSumSafe = 1;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            for (int i = 0; i < a.Length && isSumSafe==1; i++)
            {
                if (sum == a[i]) isSumSafe = 0;
            }

            return isSumSafe;
        }
    }
}
