using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet21
{
    public static class TestSet21
    {
        /// <summary>
        /// An array is called systematically increasing if it 
        /// consists of increasing sequences of the numbers from 1 to n.
        /// The first six (there are over 65,000 of them) systematically increasing arrays are:
        /// {1}
        /// {1, 1, 2}
        /// {1, 1, 2, 1, 2, 3}
        /// {1, 1, 2, 1, 2, 3, 1, 2, 3, 4}
        /// {1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5}
        /// {1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6}
        /// Write a function named isSystematicallyIncreasing which 
        /// returns 1 if its array argument is systematically increasing. Otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isSystematicallyIncreasing(int[] a)
        {
            
            int currentSequence = 0;

            // Recusive Check for sequence
            return CheckcheckSquence(a, 0, ++currentSequence);
        }

        static int CheckcheckSquence(int[] a, int startindex, int currentsequence)
        {
            int isSequence = 1;
            int i = 0;
            int current = 0;
            for (i = startindex; i < a.Length && currentsequence >= a[i] && isSequence == 1; i++)
            {
                current++;
                if (currentsequence >= a[i])
                {
                    if (current != a[i])
                    {
                        isSequence = 0;
                    }
                }
                else
                {
                    if (current != a[i])
                    {
                        isSequence = 0;
                    }
                }
            }
            startindex = i;
            if (startindex < a.Length && isSequence == 1)
                return CheckcheckSquence(a, startindex, ++currentsequence);
            else return isSequence;
        }

        /// <summary>
        /// A positive, non-zero number n is a 
        /// factorial prime if it is equal to factorial(n) + 1 
        /// for some n and it is prime. Recall that factorial(n) 
        /// is equal to 1 * 2 * … * n-1 * n. If you understand recursion, 
        /// the recursive definition is
        /// factorial(1) = 1;
        /// factorial(n) = n*factorial(n-1).
        /// For example, factorial(5) = 1*2*3*4*5 = 120.
        /// Recall that a prime number is a natural number 
        /// which has exactly two distinct natural number divisors: 1 and itself.
        /// Write a method named isFactorialPrime which 
        /// returns 1 if its argument is a factorial prime number, otherwise it returns 0.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isFactorialPrime(int n)
        {
            int isFacorialPrime = 0;

            int currentfacorial = 1;
            for (int i = 1; i  <= n && isFacorialPrime==0; i++)
            {
                currentfacorial = Factorial(i);
                if (n == currentfacorial + 1)
                {
                    if (Helper.isPrime(n)) isFacorialPrime = 1;
                }
            }
            

            return isFacorialPrime;
        }

        private static int Factorial(int v)
        {
            if (v == 1) return 1;
            else return v * Factorial(v - 1);
        }



        /// <summary>
        /// Write a function named largestDifferenceOfEvens 
        /// which returns the largest difference between even 
        /// valued elements of its array argument. 
        /// For example largestDifferenceOfEvens(new int[ ]{-2, 3, 4, 9}) 
        /// returns 6 = (4 – (-2)). 
        /// If there are fewer than 2 even numbers in the array, 
        /// largestDifferenceOfEvens should return -1.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int largestDifferenceOfEvens(int[] a)
        {
            int largestDiff = 0;

            int maxevent = 0, minevent = 0,eventcount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] %2 == 0) {
                    if(eventcount == 0)
                    {
                        maxevent = a[i];
                        minevent = a[i];
                    }
                    eventcount++;
                    if(a[i] > maxevent)
                    {
                        maxevent = a[i];
                    }
                    if(a[i] < minevent)
                    {
                        minevent = a[i];
                    }

                    largestDiff = maxevent - minevent;
                }
            }

            if(eventcount <2)
            {
                largestDiff = -1;
            }
           
            return largestDiff;


        }
    }
}
