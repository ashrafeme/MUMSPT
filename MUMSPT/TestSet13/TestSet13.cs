using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet13
{
   public static class TestSet13
    {
        /// <summary>
        /// Write a function named countRepresentations that 
        /// returns the number of ways that an amount of money 
        /// in rupees can be represented as rupee notes. For this 
        /// problem we only use  rupee notes in denominations 
        /// of 1, 2, 5, 10 and 20 rupee notes.
        /// For example, countRepresentations(12) 
        /// should return 15 because 12 rupees can be represented in the following 15 ways.
        /// </summary>
        /// <param name="numRupees"></param>
        /// <returns></returns>
        public static int countRepresentations(int numRupees)
        {
            int count = 0;

            for (int rupee20 = 0; rupee20 <= numRupees / 20; rupee20++)
                for (int rupee10 = 0; rupee10 <= numRupees / 10; rupee10++)
                    for (int rupee5 = 0; rupee5 <= numRupees / 5; rupee5++)
                        for (int rupee2 = 0; rupee2 <= numRupees / 2; rupee2++)
                            for (int rupee1 = 0; rupee1 <= numRupees / 1; rupee1++)
                            {
                                if ((rupee1 * 1)
                                    + (rupee2 * 2)
                                    + (rupee5 * 5)
                                    + (rupee10 * 10)
                                    + (rupee20 * 20) == numRupees)
                                    count++;
                            }
                            


            return count;
        }


        /// <summary>
        /// An integer array is defined to be sequentially-bounded if 
        /// it is in ascending order and each value, n,  in the array  
        /// occurs less than n times in the array. So {2, 3, 3, 99, 99, 99, 99, 99} 
        /// is sequentially-bounded because it is in ascending order and the value 2 
        /// occurs less than 2 times, the value 3 occurs less than 3 times and the 
        /// value 99 occurs less than 99 times. On the other hand, the array {1, 2, 3} 
        /// is not sequentially-bounded because the value 1 does not occur greater than 1 times. 
        /// The array {2, 3, 3, 3, 3} is not sequentially-bounded because the maximum 
        /// allowable occurrences of 3 is 2 but 3 occurs 4 times. The array {12, 12, 9} 
        /// is not sequentially-bounded because it is not in ascending order.
        /// </summary>
        /// <param name="a"></param>
        public static int isSequentiallyBounded(int[] a)
        {
            int isSequentially = 1;

            int prev = 0, current = 0, i = 0,count=0;
            while (i < a.Length && isSequentially == 1)
            {
                current = a[i];
                if (i == 0) prev = current;
                //check for ascending order
                if (prev > current) isSequentially = 0;
                else if (prev == current)
                {
                    count++;
                    i++;
                    if (count >= prev) isSequentially = 0;
                }
                else
                {
                    count = 0;
                }
                prev = current;

            }
            
            return isSequentially;
        }

        /// <summary>
        /// An array is defined to be minmax-disjoint if the following conditions hold:
        /// a. The minimum and maximum values of the array are not equal.
        /// b. The minimum and maximum values of the array are not adjacent to one another.
        /// c. The minimum value occurs exactly once in the array.
        /// d. The maximum value occurs exactly once in the array.
        /// For example the array {5, 4, 1, 3, 2} is minmax-disjoint because
        /// a. The maximum value is 5 and the minimum value is 1 and they are not equal.
        /// b. 5 and 1 are not adjacent to one another
        /// c. 5 occurs exactly once in the array
        /// d. 2 occurs exactly once in the array
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isMinMaxDisjoint(int[] a)
        {
            int isMinMax = 1;
            int min = 0, max = 0, mincount = 0, maxcount = 0, maxindex = 0, minindex = 0;
            if (a.Length == 0) isMinMax = 0;

            for (int i = 0; i < a.Length && isMinMax==1; i++)
            {
                if(i == 0) {
                    min = a[i];
                    max = a[i];
                    maxindex = i;
                    minindex = i;
                    mincount++;
                    maxcount++;
                }else
                {
                    // check for min
                    if(a[i] < min)
                    {
                        // new min is here
                        min = a[i];
                        minindex = i;
                        mincount++;
                    }else if (a[i] == min)
                    {
                        // c. Filed
                        isMinMax = 0;
                    }

                    // check for max;
                    if(a[i] > max)
                    {
                        // new max is here
                        max = a[i];
                        maxindex = i;
                        maxcount++;
                    }else if(a[i] == max)
                    {
                        // d. not true
                        isMinMax = 0;
                    }
                }
            }

            if (isMinMax == 1)
            {
                // check for a.
                if (min == max) isMinMax = 0;
                //check for b
                if ((minindex == maxindex - 1) || (minindex == maxindex + 1))
                    isMinMax = 0;
            }

            return isMinMax;
        }
    }
}
