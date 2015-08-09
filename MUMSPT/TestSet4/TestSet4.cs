using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet4
{
   public static class TestSet4
    {
        /// <summary>
        /// It is a fact that there exist two numbers x and y such that  x! + y! = 10!. Write a method named solve10  that returns the values x and y in an array.
        /// The notation n! is called n factorial and is equal to n * n-1 * n-2 * … 2 * 1, e.g.,  5! = 5*4*3*2*1 = 120.
        /// 
        /// </summary>
        /// <returns></returns>
        public static int[] solve10()
        {
            int[] factors = new int[2];

            int tenFactorial = 1;
            int Factorialx = 1, Factorialy = 1;
            int x = 1, y = 1;
            bool solved = false;
            for (int i = 1; i <= 10; i++)
            {
                tenFactorial *= i;
            }

            for (x = 1; x <= 10 && solved == false; x++)
            {
                Factorialx *= x;
                Factorialy = 1;
                for (y = 1; y <= 10 && solved == false; y++)
                {
                    Factorialy *= y;
                    solved = (Factorialx + Factorialy == tenFactorial);
                }
            }
            if(!solved)
            {
                x = y = 0;
            }
            factors[0] = x;
            factors[1] = y;
           
            return factors;
        }

        public static int[] solve101()
        {
            int[] solve10 = new int[2];
            int tenFactorial = 1;
            int x = 0;
            int y = 0;
            Boolean factorialFound = false;
            for (int i = 1; i <= 10; i++)
            {
                tenFactorial = tenFactorial * i;
            }
            for (x = 0; x < 10; x++)
            {
                int xFactorial = 1;
                if (x > 0)
                {
                    for (int i = 1; i <= x; i++)
                    {
                        xFactorial = xFactorial * i;
                    }
                }
                for (y = 0; y < 10; y++)
                {
                    int yFactorial = 1;
                    if (y > 0)
                    {
                        for (int j = 1; j <= y; j++)
                        {
                            yFactorial = yFactorial * j;
                        }
                    }
                    if (xFactorial + yFactorial == tenFactorial)
                    {
                        factorialFound = true;
                        break;
                    }
                }
                if (factorialFound)
                {
                    break;
                }
            }
            if (x == 10 && y == 10)
            {
                //Not Found
                x = 0;
                y = 0;
            }
            solve10[0] = x;
            solve10[1] = y;
            
            return solve10;
        }

        /// <summary>
        ///  An array can hold the digits of a number. 
        /// For example the digits of the number 32053 are stored in the array {3, 2, 0, 5, 3}. 
        /// Write a method call repsEqual that takes an array and an integer and returns 1 
        /// if the array contains only the digits of the number in the same order 
        /// that they appear in the number. Otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int repsEqual(int[] a, int n)
        {
            int repsEqual = 1;

            for (int i = a.Length -1 ; i >= 0 && repsEqual==1; i--)
            {
                
                int lastDigit = n % 10;
                if (a[i] != lastDigit)
                    repsEqual = 0;
                n = n / 10;
            }

            return repsEqual;
        }


        /// <summary>
        /// An array is called centered-15 if some consecutive sequence
        ///  of elements of the array sum to 15 and this sequence is preceded
        ///  and followed by the same number of elements.  For example
        /// {3, 2, 10, 4, 1, 6, 9} is centered-15 because
        ///  the sequence 10, 4, 1 sums to 15 and the sequence is preceded
        ///  by two elements (3, 2) and followed by two elements(6,9).
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isCentered15(int[] a)
        {
            int isCentered15 = 0;
             
            for (int i = 0; i < a.Length && isCentered15 == 0; i++)
            {
                int sum = 0;
                for (int j = i; j < a.Length && isCentered15 == 0 && sum < 15; j++)
                {
                    sum += a[j];
                    if (sum == 15 && ((i - 0) == ((a.Length - 1) - j)))
                    {
                        isCentered15 = 1;
                    }
                }
            }

            return isCentered15;
        }
    }
}
