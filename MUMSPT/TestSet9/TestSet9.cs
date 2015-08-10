using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet9
{
   public static  class TestSet9
    {
        /// <summary>
        ///  Write a function named equivalentArrays that has two array 
        /// arguments and returns 1 if the two arrays contain the same 
        /// values (but not necessarily in the same order), otherwise it returns 0. 
        /// Your solution must not sort either array or a copy of either array! 
        /// Also you must not modify either array, i.e., the values in the arrays 
        /// upon return from the function must be the same as when the function 
        /// was called. Note that the arrays do not have to have the same number 
        /// of elements, they just have to have one of more copies of the same values.
        /// Hint: If your solution compares the length of the first array with 
        /// the length of the second array or vice versa, you have misunderstood 
        /// the problem!! Your solution does not need to determine which array is bigger!
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static int equivalentArrays(int[] a1, int[] a2)
        {
            int isEquivalent = 1;

            for (int i = 0; i < a1.Length && isEquivalent==1; i++)
            {
                int exist = 0;
                for (int j = 0; j < a2.Length && exist == 0; j++)
                {
                    if (a1[i] == a2[j]) exist = 1;
                }
                if (exist == 0) isEquivalent = 0;
            }

            for (int i = 0; i < a2.Length && isEquivalent == 1; i++)
            {
                int exist = 0;
                for (int j = 0; j < a1.Length && exist == 0; j++)
                {
                    if (a2[i] == a1[j]) exist = 1;
                }
                if (exist == 0) isEquivalent = 0;
            }

            return isEquivalent;
        }


        /// <summary>
        /// An array is defined to be stepped if it is in ascending order 
        /// and there are 3 or more occurrences of each distinct value in the array. 
        /// Note that ascending order means<![CDATA[ a[n] <=a[n+1]. ]]>
        /// It does not mean a[n] (this is strictly ascending).
        /// Write a function named isStepped that returns 1 if its array argument is stepped, 
        /// otherwise return 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isStepped(int[] a)
        {
            int isStepped = 1;

            int count = 0, current = 0, next = 0;
            for (int i = 0; i < a.Length && isStepped==1; i++)
            {
                int k = (i == a.Length - 1) == true ? i : i + 1;
                current = a[i];
                next = a[k];
                //ckeck of is ascending
                if (current > next) isStepped = 0;
                else
                {
                    if(current == next)
                    {
                        count++;
                    }
                    else
                    {
                        if (current == a[i - 1])
                            count++;
                        if (count < 3) isStepped = 0;
                        count = 0;
                    }
                }
                if (i == a.Length - 1) // check for last item
                {
                    if (count < 3) isStepped = 0;
                }
            }
            
            return isStepped;
        }


        /// <summary>
        /// An array is rapidly increasing if each element (except the first one) is 
        /// greater than twice the sum of all its preceding elements.
        /// Write a method named isRapidlyIncreasing that returns 1 if its array argument is rapidly increasing. 
        /// Otherwise it returns 0
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isRapidlyIncreasing(int[] a)
        {
            int isRapidlyIncreasing = 1;

            for (int i = a.Length - 1; i > 0 && isRapidlyIncreasing == 1; i--)
            {
                int sum = 0;
                for (int j = i - 1; j >=0  ; j--)
                {
                    sum += a[j];
                }
                if (a[i] <= 2 * sum) isRapidlyIncreasing = 0;
            }

            return isRapidlyIncreasing;
        }
    }
}
