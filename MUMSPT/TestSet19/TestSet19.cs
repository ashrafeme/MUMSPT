using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet19
{
   public static class TestSet19
    {
        /// <summary>
        /// An array is zero-plentiful if it 
        /// contains at least one 0 and every 
        /// sequence of 0s is of length at least 4.
        /// Write a method named isZeroPlentiful 
        /// which returns the 
        /// number of zero sequences if its array 
        /// argument is zero-plentiful, otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isZeroPlentiful(int[] a)
        {
            int isZero = 1;
            int count = 0;
            int zerocount = 0;
            for (int i = 0; i < a.Length && isZero==1 ; i++)
            {
                int current = a[i];
                if (current == 0)
                    zerocount++;
                else if (zerocount >= 4) { count++; zerocount = 0; isZero = 1; }
                else if (zerocount > 0) isZero = 0;
                
                
                if(i == a.Length - 1)
                {
                    if (zerocount >= 4) { count++; zerocount = 0; }
                   
                }
            }

           

            if (isZero == 1) isZero = count;
            return isZero;
        }



        /// <summary>
        /// A number is called digit-increasing if it is 
        /// equal to n + nn + nnn + … for some digit n 
        /// between 1 and 9. For example 24 is 
        /// digit-increasing because it equals 2 + 22 (here n = 2)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isDigitIncreasing(int n)
        {
            int isDigitI = 0;
            
            int digitcount = 0;
            int tempn = n;
            do
            {
                tempn = tempn / 10;
                digitcount++;
            } while (tempn >=1);

            for (int i = 1; i <= 9 && isDigitI == 0; i++)
            {
                int sum = 0;
                int digit = 0;
                
                for (int j = 1; j <= digitcount; j++)
                {
                    int ten = 1;
                    if (j > 1)
                        ten *= 10;
                    sum = sum * ten;
                    sum += i;

                    digit += sum;
                }

                if (digit == n) isDigitI = 1;
            }

            return isDigitI;
        }

        /// <summary>
        /// An integer number can be encoded as an array as follows. 
        /// Each digit n of the number is represented by n zeros followed by a 1. 
        /// So the digit 5 is represented by 0, 0, 0, 0, 0, 1. 
        /// The encodings of each digit of a number are combined 
        /// to form the encoding of the number. 
        /// So the number 1234 is encoded as the 
        /// array {0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1}. 
        /// The first 0, 1 is contributed by the digit 1, 
        /// the next 0, 0, 1 is contributed by the digit 2, and so on.
        /// There is one other encoding rule: if the number is negative, 
        /// the first element of the encoded array must be -1, so -201 is 
        /// encoded as {-1, 0, 0, 1, 1, 0, 1}. Note that the 0 digit is 
        /// represented by no zeros, i.e. there are two consecutive ones!
        /// Write a method named decodeArray 
        /// that takes an encoded array and decodes it to return the number.
        /// You may assume that the input array is a legal encoded array, 
        /// i.e., that -1 will only appear as the first element, 
        /// all elements are either 0, 1 or -1 and that the last element is 1.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int decodeArray(int[] a)
        {
            int decodenumber = 0;
            int Positive = 1;
            int zerocount = 0;
            int ten = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    if (a[i] < 0) Positive = a[i];
                }

                if (a[i] == 0)
                    zerocount++;
                else
                {
                    if (zerocount > 0)
                    {
                        decodenumber = decodenumber * ten;
                        decodenumber += zerocount;
                        zerocount = 0;
                        ten = 10;
                    }
                    else
                    {
                        decodenumber = decodenumber * ten;
                        decodenumber += 0;
                        ten = 10;
                    }
                }

            }

            decodenumber = decodenumber * Positive;
            return decodenumber;
        }

        
    }
}
