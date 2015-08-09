using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet6
{
    public static class TestSet6
    {

        /// <summary>
        /// Write a function named isSquare that returns 1 
        /// if its integer argument is a square of some integer, otherwise it returns 0.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isSquare(int n)
        {
            int isSquare = 0;

            int index = 0, sum = 0;
            do
            {
                sum = index * index;
                if (n == sum)
                    isSquare = 1;

                index++;
            } while (sum <= n && isSquare == 0);

            return isSquare;
        }


        /// <summary>
        /// Write a method named isLegalNumber that takes two arguments.
        ///  The first argument is an array whose elements are the digits of the number to test.
        ///  The second argument is the base of the number represented by the first argument.
        ///  The method returns 1 if the number represented by the array is a legal number in
        ///  the given base, otherwise it returns 0.
        ///  However, since all digits of a base n number must be less than n,
        ///  the following call will return 0 because 3716 is not a legal 
        ///  base 6 number (the digit 7 is not allowed)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="bases"></param>
        /// <returns></returns>
        public static int isLegalNumber(int[] a, int bases)
        {
            int isLegalNumber = 1;

            for (int i = 0; i < a.Length && isLegalNumber == 1; i++)
            {
                if (a[i] >= bases) isLegalNumber = 0;

            }
            return isLegalNumber;
        }




        /// <summary>
        /// Using the <array, base> representation for a number described in the
        /// second question write a method named convertToBase10 that  
        /// converts its "array, base" arguments to a base 10 number if 
        /// the input is legal for the specified base. If it is not, it returns -1.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="bases"></param>
        /// <returns></returns>
        public static int convertToBase10(int[] a,int bases)
        {
            int base10 = 0,islegal = isLegalNumber(a, bases);
            int exp = 0;
            for (int i = a.Length - 1; i >= 0 && islegal == 1; i--, exp++)
            {
                base10 += a[i] * (int)Math.Pow(bases, exp);

            }

            return base10;
        }
    }
}
