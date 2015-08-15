using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet20
{
    public static class TestSet20
    {
        /// <summary>
        /// An onion array is an array that satisfies the following condition for all values of j and k:
        /// if j>=0 and k>=0 and j+k=length of array and j!=k then a[j]+a[k]&lt;=10
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isOnionArray(int[] a)
        {
            int isOnion = 1;
            if (a.Length > 0)
            {
                int i = 0, k = a.Length - 1;
                while (i != k && isOnion == 1)
                {
                    if (a[i] + a[k] > 10) isOnion = 0;
                    i++;
                    k--;
                }
            }

            return isOnion;
        }


        /// <summary>
        /// A number n is called prime happy if there 
        /// is at least one prime less than n and the 
        /// sum of all primes less than n is evenly 
        /// divisible by n.
        /// Recall that a prime number is an integer > 1 
        /// which has only two integer factors, 1 and itself
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isPrimeHappy(int n)
        {
            return TestSet11.TestSet11.isPrimeHappy(n);
        }


        /// <summary>
        /// An integer number can be encoded as an array as follows. 
        /// Each digit n of the number is represented by n zeros followed by a 1. 
        /// So the digit 5 is represented by 0, 0, 0, 0, 0, 1. 
        /// The encodings of each digit of a number are combined to form the encoding of the number. 
        /// So the number 1234 is encoded as the array {0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1}. 
        /// The first 0, 1 is contributed by the digit 1, 
        /// the next 0, 0, 1 is contributed by the digit 2, and so on. 
        /// There is one other encoding rule: if the number is negative, 
        /// the first element of the encoded array must be -1, so -201 is encoded as {-1, 0, 0, 1, 1, 0, 1}. 
        /// Note that the 0 digit is represented by no zeros, i.e. there are two consecutive ones!
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] encodeArray(int n)
        {
            int arrayLength = 0;
            int positive = 0;
            if (n < 0)
            {
                positive = -1;
            }
            int[] encodeArray;
           int tempn = Math.Abs(n);
            do
            {
                int lastdigit = tempn % 10;
                arrayLength += lastdigit + 1;
                tempn = tempn / 10;
            } while (tempn >= 1);

            if (positive < 0)
            {
                arrayLength++;
            }

            encodeArray = new int[arrayLength];
            int index = arrayLength;
            if (positive < 0)
            {
                encodeArray[0] = -1;
            }


            tempn = Math.Abs(n);

            do
            {
                int lastdigit = tempn % 10;


                encodeArray[index - 1] = 1;

                index -= lastdigit + 1;
                tempn = tempn / 10;
            } while (tempn >= 1);
            return encodeArray;
        }
    }
}
