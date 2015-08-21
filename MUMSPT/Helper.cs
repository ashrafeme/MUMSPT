using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT
{
    public static class Helper
    {
        /// <summary>
        /// calucate if the number is prime or not
        /// </summary>
        /// <param name="n">the number that is under investigation</param>
        /// <returns>true if the number is prime ,false if not</returns>
        public static bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }


        /// <summary>
        /// search the array for a element is exist in array or not
        /// </summary>
        /// <param name="b">the array that is under investigation</param>
        /// <param name="element">the element being search about it int the array</param>
        /// <returns>return the index of the element in the array of not exist return -1</returns>
        public static int isExistInArray(int[] b, int element)
        {
            int isExist = -1;

            for (int i = 0; i < b.Length && isExist == -1; i++)
            {
                if (b[i] == element)
                    isExist = i;
            }
            return isExist;
        }

        public static int isExistInArray(char[] b, char element)
        {
            int isExist = -1;

            for (int i = 0; i < b.Length && isExist == -1; i++)
            {
                if (b[i] == element)
                    isExist = i;
            }
            return isExist;
        }


        /// <summary>
        ///  A perfect square is an integer whose square root is also an integer,
        /// e.g. 4, 9, 16 are perfect squares but 3, 10 and 17 are not.
        /// </summary>
        /// <param name="n">the number under invistegation</param>
        /// <returns></returns>
        public static bool isPerfectSquare(int n)
        {
            double sqrt = Math.Sqrt(n);
            return (sqrt == Math.Floor(sqrt));
        }

        /// <summary>
        /// get the factors of number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> Factors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }

            }
            return factors;
        }


        /// <summary>
        /// get if the number is Integer or not
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsWholeNumber(double n)
        {
            return (n % 1 == 0);
        }

        public static bool IsdivisibleBy(int number,int by)
        {
            return (number % by == 0);
        }
    }
}
