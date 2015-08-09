using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet8
{
    public static class TestSet8
    {
        /// <summary>
        /// Define a positive number to be isolated if none of the digits in 
        /// its square are in its cube. For example 163 is n isolated number 
        /// because 69*69 =  26569  and 69*69*69 = 4330747 and the square does 
        /// not contain any of the digits 0, 3, 4 and 7 which are the digits used 
        /// in the cube. On the other hand 162 is not an isolated number 
        /// because 162*162=26244 and 162*162*162 = 4251528 and the digits 2 and 4 
        /// which appear in the square are also in the cube.
        /// Note that the type of the input parameter is long. 
        /// The maximum positive number that can be represented as a long is 63 bits long. 
        /// This allows us to test numbers up to 2,097,151 because the cube of 2,097,151 
        /// can be represented as a long. However, the cube of 2,097,152 requires more 
        /// than 63 bits to represent it and hence cannot be computed without extra effort. 
        /// Therefore, your function should test if n is larger than 2,097,151 and return -1 
        /// if it is. If  n is less than 1 your function should also return -1
        /// Hint: n % 10 is the rightmost digit of n, n = n/10 shifts the digits of n one place to the right.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isIsolated(long n)
        {
            int isIsolated = 1;
            if (n < 1 || n > 2097151) isIsolated = -1;


            long cube = n * n * n;
            do
            {
                long lastcubedigit = cube % 10;
                cube = cube / 10;
                long squar = n * n;
                do
                {
                    long lastsquarDigit = squar % 10;
                    if (lastcubedigit == lastsquarDigit)
                        isIsolated = 0;
                    squar = squar / 10;

                } while (isIsolated >= 1 && squar > 1);

            } while (isIsolated >= 1 && cube > 1);

            return isIsolated;
        }

        /// <summary>
        /// An array is called vanilla if all its elements are made up of the same digit. 
        /// For example {1, 1, 11, 1111, 1111111} is a vanilla array because all its 
        /// elements use only the digit 1. However, the array {11, 101, 1111, 11111} 
        /// is not a vanilla array because its elements use the digits 0 and 1. 
        /// Write a method called isVanilla that returns 1 if its argument is a 
        /// vanilla array. Otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isVanilla(int[] a)
        {
            int isvanilla = 1;
            // if (a.Length == 0) return isvanilla;
            int firstelement = -12345;

            for (int i = 0; i < a.Length && isvanilla == 1; i++)
            {
                int n = Math.Abs(a[i]);
                do
                {
                    int lastdigit = n % 10;
                    if (firstelement == -12345)
                    {
                        firstelement = lastdigit;
                    }
                    if (firstelement != lastdigit)
                        isvanilla = 0;
                    n = n / 10;

                } while (isvanilla == 1 && n > 1);
            }

            return isvanilla;
        }

        /// <summary>
        /// Define an array to be trivalent if all its elements are one of three 
        /// different values. For example, {22, 19, 10, 10, 19, 22, 22, 10} is 
        /// trivalent because all elements are either 10, 22, or 19. However, 
        /// the array {1, 2, 2, 2, 2, 2, 2} is not trivalent because it contains 
        /// only two different values (1, 2). The array {2, 2, 3, 3, 3, 3, 2, 41, 65} 
        /// is not trivalent because it contains four different values (2, 3, 41, 65).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isTrivalent(int[] a)
        {
            int isTrivalent = 1;

            int[] uniq = new int[3];
            int uniqindex = 0;
            int isFristInit = 0;
            for (int i = 0; i < a.Length && isTrivalent == 1; i++)
            {
                if (isFristInit == a[i] ) isFristInit = 1;
                if (Helper.isExistInArray(uniq, a[i]) == -1 || isFristInit ==1)
                {
                    if (isFristInit ==1) isFristInit = -1;
                    if (uniqindex > 2)
                        isTrivalent = 0;
                    else
                    {
                        uniq[uniqindex] = a[i];
                    }
                    uniqindex++;
                }
            }

            if (uniqindex < 3)
                isTrivalent = 0;

            return isTrivalent;
        }
    }
}
