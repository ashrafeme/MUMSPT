using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet17
{
    public static class TestSet17
    {

        /// <summary>
        /// Write a function named largestPrimeFactor that will 
        /// return the largest prime factor of a number. 
        /// If the number is &lt;=1 it should return 0. 
        /// Recall that a prime number is a number > 1 that is 
        /// divisible only by 1 and itself, e.g., 
        /// 13 is prime but 14 is not.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int largestPrimeFactor(int n)
        {
            int largestpf = 0;

            if (n <= 1) return 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    if (Helper.isPrime(i))
                        if (i > largestpf)
                            largestpf = i;
            }

            return largestpf;
        }


        /// <summary>
        /// The fundamental theorem of arithmetic states that 
        /// every natural number greater than 1 can be written 
        /// as a unique product of prime numbers. So, for 
        /// instance, 6936=2*2*2*3*17*17. Write a method 
        /// named encodeNumber what will encode a number 
        /// n as an array that contains the prime numbers that, 
        /// when multipled together, will equal n. 
        /// So encodeNumber(6936) would return the array {2, 2, 2, 3, 17, 17}. 
        /// If the number is &lt;= 1 the function should return null;
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] encodeNumber(int n)
        {
            if (n < 2) return null;
            int primecount = 0;
            List<int> temparray = new List<int>(); // temp array if i can to use it
            int i = 2;
            do
            {
                if (Helper.isPrime(i))
                {
                    if (Helper.IsWholeNumber(n / (double)i))
                    {
                        primecount++;
                        temparray.Add(i);
                        n = n / i;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            } while (n > 1);

            int[] encodearray = new int[primecount];
            for (int j = 0; j < primecount; j++)
            {
                encodearray[j] = temparray[j];
            }

            return encodearray;
        }


        /// <summary>
        /// Consider a simple pattern matching language that 
        /// matches arrays of integers. A pattern is an array 
        /// of integers. An array matches a pattern if it contains 
        /// sequences of the pattern elements in the same order 
        /// as they appear in the pattern. So for example, 
        /// the array {1, 1, 1, 2, 2, 1, 1, 3} matches the pattern {1, 2, 1, 3} 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static int matchPattern(int[] a, int[] pattern)
        {

            // len is the number of elements in the array a, patternLen is the number of elements in the pattern.
            int len = a.Length;
            int patternLen = pattern.Length;
            int i = 0; // index into a
            int k = 0; // index into pattern
            int matches = 0;  // how many times current pattern character has been matched so far

            for (i = 0; i < len; i++)
            {

                if (a[i] == pattern[k])
                    matches++;   // current pattern character was matched
                else if (matches == 0 || k == patternLen - 1)
                    return 0; // if pattern[k] was never matched (matches==0) or at end of pattern (k==patternLen-1)
                else
                {  
                    // advance to next pattern character 
                   //  !!You write this code!!
                    k++;
                    if (a[i] == pattern[k])
                        matches++;
                    else
                        return 0;
                   

                } // end of else

            } // end of for

            // return 1 if at end of array a (i==len) and also at end of pattern (k==patternLen-1)

            if (i == len && k == patternLen - 1) return 1; else return 0;

        }

    }
}
