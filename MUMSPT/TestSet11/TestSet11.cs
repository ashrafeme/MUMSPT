using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet11
{
    public static class TestSet11
    {
        /// <summary>
        /// Define an array to be a Martian array if the number of 
        /// 1s is greater than the number of 2s and no two adjacent 
        /// elements are equal. Write a function named isMartian that 
        /// returns 1 if its array argument is a Martian array, 
        /// otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isMartian(int[] a)
        {
            int isMartian = 1;
            int oneCount = 0, TwoCount = 0;
            for (int i = 0; i < a.Length && isMartian == 1; i++)
            {
                if (a[i] == 1) oneCount++;
                else if (a[i] == 2) TwoCount++;
                else
                {
                    if (i < a.Length - 1) // chek if not last item
                    {
                        if (a[i] == a[i + 1]) isMartian = 0;
                    }
                }
            }
            if (oneCount <= TwoCount) isMartian = 0;
            return isMartian;
        }


        /// <summary>
        /// The Fibonacci sequence of numbers is 1, 1, 2, 3, 5, 8, 13, 21, 34, ... 
        /// The first and second numbers are 1 and after that ni = ni-2 + ni-1, 
        /// e.g., 34 = 13 + 21. A number in the sequence is called a Fibonacci number. 
        /// Write a method with signature int closestFibonacci(int n) which returns the largest 
        /// Fibonacci number that is less than or equal to its argument. For example, 
        /// closestFibonacci(12) returns 8 because 8 is the largest Fibonacci number less 
        /// than 12 and closestFibonacci(33) returns 21 because 21 is the largest Fibonacci 
        /// number that is &lt;= 33. closestFibonacci(34) should return 34. If the argument 
        /// is less than 1 return 0. Your solution must not use recursion because unless you 
        /// cache the Fibonacci numbers as you find them, the recursive solution recomputes 
        /// the same Fibonacci number many times.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int closestFibonacci(int n)
        {
            int closestFibonacci = 0;
            if (n > 0)
            {
                int a = 0, b = 1, c = a + b;

                do
                {
                    a = b;
                    b = c;
                    c = a + b;
                    if (c >= n)
                    {
                        closestFibonacci = b;
                    }
                } while (c <= n);
            }
            return closestFibonacci;
        }

        /// <summary>
        /// A number n is called prime-happy if there is at least one prime 
        /// less than n and the sum of all primes less than n is evenly divisible by n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isPrimeHappy(int n)
        {
            int isPrimeHappy = 1;
            int count = 0, sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (Helper.isPrime(i))
                {
                    count++;
                    sum += i;
                }
            }

            if (count < 1) isPrimeHappy = 0;
            if (sum % n != 0) isPrimeHappy = 0;

            return isPrimeHappy;


        }

    }
}
