using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet23
{
    public static class TestSet23
    {
        /// <summary>
        /// A number n is vesuvian if it is the sum 
        /// of two different pairs of squares. 
        /// For example, 50 is vesuvian because 50 == 25 + 25 
        /// and 1 + 49. The numbers 65 (1+64, 16+49) and 85 
        /// (4+81, 36+49) are also vesuvian. 789 of 
        /// the first 10,000 integers are vesuvian.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int vesuvian(int n)
        {
            int isVesuvian = 0;

            int paircount = 0;
            for (int i = 0; i < n && isVesuvian == 0; i++)
            {
                if (Helper.isPerfectSquare(i))// is square
                {
                    for (int j = 0; j < n && isVesuvian == 0; j++)
                    {
                        if (Helper.isPerfectSquare(j))
                        {
                            if (i + j == n)
                                paircount++;
                            if (paircount == 2)
                                isVesuvian = 1;
                        }
                    }
                }
            }

            return isVesuvian;
        }


        /// <summary>
        /// Define an array to be one-balanced if 
        /// begins with zero or more 1s followed 
        /// by zero or more non-1s and concludes 
        /// with zero or more 1s. Write a function 
        /// named isOneBalanced that returns 1 if 
        /// its array argument is one-balanced, 
        /// otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isOneBalanced(int[] a)
        {

            int isOneBalanced = 1;

            int nonOneSequence = 0, oneSequence = 0;
            int firstOneSquenceCount = 0, secondOneSquenceCount = 0, nonOneSquenceCount = 0;

            for (int i = 0; i < a.Length && isOneBalanced == 1; i++)
            {
                int current = a[i];
                if (current == 1)
                {
                    if (oneSequence == 0 && nonOneSequence == 0)
                    {
                        oneSequence++;
                        if (firstOneSquenceCount == 0)
                        {
                            firstOneSquenceCount++;
                        }
                    }
                    else
                    {
                        if (nonOneSequence == 0)
                        {
                            if (oneSequence == 1)
                                firstOneSquenceCount++;
                            if (oneSequence == 2)
                                secondOneSquenceCount++;
                        }
                        else
                        {
                            if (nonOneSequence == 1 && oneSequence == 1)
                                oneSequence++;

                            if (oneSequence == 2 || nonOneSequence == 1)
                            {
                                secondOneSquenceCount++;
                            }

                        }
                    }
                }
                else
                {
                    if (nonOneSequence == 0)
                    {
                        nonOneSequence++;
                        if (nonOneSquenceCount == 0)
                        {
                            nonOneSquenceCount++;
                        }

                    }
                    else
                    {
                        if (oneSequence == 1 || oneSequence == 0)
                        {
                            nonOneSquenceCount++;
                        }
                        if (oneSequence == 2)
                        {
                            isOneBalanced = 0;
                        }
                    }
                }
            }

            if (firstOneSquenceCount + secondOneSquenceCount != nonOneSquenceCount)
                isOneBalanced = 0;
            return isOneBalanced;
        }


        /// <summary>
        /// The Fibonacci sequence of numbers 
        /// is 1, 1, 2, 3, 5, 8, 13, 21, 34,
        ///  … The first and second numbers 
        /// are 1 and after that ni = ni-2 + ni-1, 
        /// e.g., 34 = 13 + 21. 
        /// Write a method with signature
        /// int isFibonacci(int n) which returns 1 
        /// if its argument is a number in the Fibonacci sequence, 
        /// otherwise it returns 0. For example, isFibonacci(13) 
        /// returns a 1 and isFibonacci(27) returns a 0. 
        /// Your solution must not use 
        /// recursion because unless you cache the Fibonacci 
        /// numbers as you find them, 
        /// the recursive solution recomputes 
        /// the same Fibonacci number many times.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isFibonacci(int n)
        {
            int isFibonacci = 0;

            int a = 0, b = 1, c = a + b;

            do
            {
                a = b;
                b = c;
                c = a + b;
                if (c == n)
                    isFibonacci = 1;
            } while (c <=n && isFibonacci==0);

            return isFibonacci;
        }
    }
}
