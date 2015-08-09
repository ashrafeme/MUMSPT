using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet1
{
  public static  class TestSet1
    {
        /// <summary>
        /// Write a function named primeCount with signature
        /// int primeCount(int start, int end);
        /// The function returns the number of primes between start and end inclusive.
        /// Recall that a prime is a positive integer greater than 1 whose only integer factors  are 1 and itself.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <example>
        /// Examples
        /// If start is	and end is	return	reason
        /// 10	30	6	The primes between 10 and 30 inclusive are 11, 13, 17, 19, 23 and 29
        /// 11	29	6	The primes between 11 and 29 inclusive are 11, 13, 17, 19, 23 and 29
        /// 20	22	0	20, 21, and 22 are all non-prime
        /// 1	1	0	By definition, 1 is not a prime number
        /// 5	5	1	5 is a prime number
        /// 6	2	0	start must be less than or equal to end
        /// -10	 6	3	primes are greater than 1 and 2, 3, 5 are prime
        /// </example>
        /// <returns></returns>
        public static int primeCount(int start, int end)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (Helper.isPrime(i)) count++;
            }

            return count;
        }

        /// <summary>
        /// A Madhav array has the following property.
        /// a[0] = a[1] + a[2] = a[3] + a[4] + a[5] = a[6] + a[7] + a[8] + a[9] = …
        /// The length of a Madhav array must be n*(n+1)/2 for some n.
        /// Write a method named isMadhavArray that returns 1 if its array argument is a Madhav array, otherwise it returns 0. If you are programming in Java or C# the function signature is
        /// int isMadhavArray(int[] a)
        /// If you are programming in C or C++, the function signature is
        /// int isMadhavArray(int a[ ], int len) where len is the number of elements in a.
        /// </summary>
        /// <param name="a">the array under invstegation</param>
        /// <example>
        /// if a is	                                        return	  reason
        ///    {2, 1, 1}	                                    1     2 + 1 + 1
        ///    {2, 1, 1, 4, -1, -1}	                            1	  2 = 1 + 1, 2 = 4 + -1 + -1
        ///    {6, 2, 4, 2, 2, 2, 1, 5, 0, 0}	                1	  6 = 2 + 4, 6 = 2 + 2 + 2, 6 = 1 + 5 + 0 + 0
        ///    {18, 9, 10, 6, 6, 6}	                            0	  18 != 9 + 10
        ///    {-6, -3, -3, 8, -5, -4}	                        0	 -6 != 8 + -5 + -4
        ///    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, -2, -1}	1	  0 = 0 + 0,
        ///                                                           0 = 0 + 0 + 0, 
        ///                                                           0 = 0 + 0 + 0 + 0,
        ///                                                           0 = 1 + 1 + 1 + -2 + -1
        ///    {3, 1, 2, 3, 0}	                                0	  The length of the array is 5,
        ///                                                           but 5 does not equal n*(n+1)/2 for any value of n.
        /// </example>
        /// <returns></returns>
        public  static int isMadhavArray(int[] a)
        {
            int isMadhave = 1;
            if(a.Length < 3) { return 0; }
            // check if The length of a Madhav array must be n*(n+1)/2 for some n.
            int isLengthisMadhav = 0;
            for (int i = 1; i <= a.Length && isLengthisMadhav ==0; i++)
            {
                if (a.Length == i * (i - 1) / 2)
                {
                    isLengthisMadhav = 1;
                }
            }
            if (isLengthisMadhav == 0) return 0;// the length not satisfy the condition
            
            int startindex = 1, round = 1;
            int firstvalue = a[0];
            int endindex = startindex + round;
            while (isMadhave == 1 && endindex <= a.Length)
            {
                int sum = 0;
                for (int i = startindex; i <= endindex; i++)
                {
                    sum += a[i];
                }
                if (firstvalue != sum)
                    isMadhave = 0;

                round++;
                startindex = endindex + 1;
                endindex = startindex + round;
            }
            //
            return isMadhave;
        }


        public static int isInertial(int[] a)
        {
            int isInertial = 1;

            int[] oddValues = new int[a.Length];
            int oddindex = -1;
            int[] evenValues = new int[a.Length];
            int evenindex = -1;
            int maxValue = 0;
          
            for (int i = 0; i < a.Length; i++)
            {
                // get the max value
                if(a[i] > maxValue)
                {
                    maxValue = a[i];
                }
                // check for odd and even;
                if(a[i] %2 == 0)
                {
                    evenindex++;
                    evenValues[evenindex] = a[i];
                }
                else
                {
                    oddindex++;
                    oddValues[oddindex] = a[i];
                }
            }

            //a- check if contains at least one odd value
            if (oddindex < 0)
                return 0;
            //b- check  if the maximum value in the array is even
            if (maxValue % 2 != 0)
                return 0;
            int oddvalue = 0, evenvalue = 0;

            //c- check if every odd value is greater than every even value that is not the maximum value.
            for (int i = 0; i <= oddindex && isInertial == 1; i++)
            {
                oddvalue = oddValues[i];
                for (int j = 0; j <= evenindex && isInertial == 1; j++)
                {
                    evenvalue = evenValues[j];
                    
                    if (evenvalue != maxValue)
                    {
                        if (evenvalue > oddvalue)
                            isInertial = 0; //exit theloop
                    }
                }
            }
            return isInertial;
        }
    }
}
