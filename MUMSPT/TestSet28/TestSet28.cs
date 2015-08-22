using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet28
{
    public static class TestSet28
    {

        /// <summary>
        ///  Write a function named allValuesTheSame that 
        /// returns 1 if all elements of its argument array 
        /// have the same value. Otherwise, it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int allValuesTheSame(int[] a)
        {
            int isAllValues = 1;
            // if empty array set to 0 and don't enter the loop
            if (a.Length == 0)
                isAllValues = 0;

            int first = 0, current = 0;
            for (int i = 0; i < a.Length && isAllValues == 1; i++)
            {
                if (i == 0)
                    first = a[i];
                current = a[i];
                if (first != current) isAllValues = 0;
            }
            return isAllValues;
        }


        /// <summary>
        /// Write a function named hasNValues which takes an 
        /// array and an integer n as arguments. 
        /// It returns true if all the elements 
        /// of the array are one of n different values
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int hasNValues(int[] a, int n)
        {
            int hasNValues = 1;
            int[] uniqueValues = new int[n];
            int uniqueindex = 0;
            for (int i = 0; i < a.Length && hasNValues == 1; i++)
            {
                if (Helper.isExistInArray(uniqueValues, a[i]) == -1)
                {
                    if (uniqueindex < n)
                    {
                        uniqueValues[uniqueindex] = a[i];
                        uniqueindex++;
                    }
                    else
                    {
                        hasNValues = 0;
                    }
                }
            }

            if (uniqueindex != n) hasNValues = 0;

            return hasNValues;
        }

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
            return TestSet10.TestSet10.sameNumberOfFactors(n1, n2);
        }

    }
}
