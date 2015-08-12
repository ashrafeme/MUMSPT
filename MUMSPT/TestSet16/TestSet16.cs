using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet16
{
    public static class TestSet16
    {
        /// <summary>
        ///  Write a function named largestAdjacentSum that iterates through an array 
        /// computing the sum of adjacent elements and returning the largest such sum. 
        /// You may assume that the array has at least 2 elements.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int largestAdjacentSum(int[] a)
        {
            int sum = 0;


            for (int i = 0; i < a.Length; i++)
            {
                int current = 0, next = 0;
                current = a[i];
                if (i < a.Length - 1) next = a[i + 1];

                int temp = current + next;
                if (temp > sum)
                    sum = temp;
            }

            return sum;
        }

        /// <summary>
        ///  The number 198 has the property that 198 = 11 + 99 + 88, i.e., 
        /// if each of its digits is concatenated twice and then summed, 
        /// the result will be the original number. It turns out that 198 is 
        /// the only number with this property. However, the property can be 
        /// generalized so that each digit is concatenated n times and then summed. 
        /// For example, 2997 = 222+999+999+777 and here each 
        /// digit is concatenated three times. Write a function named 
        /// checkContenatedSum that tests if a number has this generalized property. 
        /// The signature of the function is 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="catlen"></param>
        /// <returns></returns>
        public static int checkConcatenatedSum(int n, int catlen)
        {
            int isConcatenatedSum = 1;
            int sum = 0, tempn = n;
            do
            {
                int lastdigit = tempn % 10;
                int tempsum = 0;
                int tens = 1;
                for (int i = 1; i <= catlen; i++)
                {
                   
                    tempsum += (tens * lastdigit);
                     tens *= 10;
                }

                tempn = tempn / 10;
                sum += tempsum;
            } while (tempn >= 1);

            if (sum != n) isConcatenatedSum = 0;
            return isConcatenatedSum;
        }


        /// <summary>
        ///  Define an m-n sequenced array to be an array that contains one or 
        /// more occurrences of all the integers between m and n inclusive. 
        /// Furthermore, the array must be in ascending order and contain only those integers. 
        /// For example, {2, 2, 3, 4, 4, 4, 5} is a 2-5 sequenced array. 
        /// The array {2, 2, 3, 5, 5, 5} is not a 2-5 sequenced array because it is missing a 4. 
        /// The array {0, 2, 2, 3, 3} is not a 2-3 sequenced array because the 0 is out of range. 
        /// And {1,1, 3, 2, 2, 4} is not a 1-4 sequenced array because it is not in ascending order.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isSequencedArray(int[] a, int m, int n)
        {
            int isSequnced = 1;
            int current = 0;
            for (int i = 0; i < a.Length && isSequnced==1; i++)
            {
                current = a[i];
                if (i == 0) if (current != m) isSequnced = 0;
                if (i == a.Length - 1) if (current != n) isSequnced = 0;
                if (current < m || current > n) isSequnced = 0;
                if (i > 0)
                    if (current <a[i - 1]) isSequnced = 0;
                if (i < (a.Length - 1))
                    if (current != a[i + 1])
                        if (a[i + 1] != current + 1) isSequnced = 0;
            }

            return isSequnced;
        }

    }
}
