using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet27
{
    public static class TestSet27
    {
        /// <summary>
        ///  Write a function named isSquare that returns 1 
        /// if its integer argument is a square of some integer, 
        /// otherwise it returns 0. Your function must not 
        /// use any function or method (e.g. sqrt) that 
        /// comes with a runtime library or class library!  
        /// You will need to write a loop to solve this problem. 
        /// Furthermore, your method should return as soon as the 
        /// status of its parameter is known. 
        /// So once it is known that the input parameter 
        /// is a square of some integer, 
        /// your method should return 1 and once it is 
        /// known that the input is not a square, 
        /// the method should return 0. 
        /// There should be no wasted loop cycles, 
        /// your method should be efficent!
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isSquare(int n)
        {
            int isSquare = 0;

            int square = 0;
            for (int i = 0; square <= n && isSquare == 0; i++)
            {
                square = i * i;
                if (square - n == 0)
                {
                    isSquare = 1;
                }
            }

            return isSquare;


        }


        /// <summary>
        ///  An array is called complete if it contains an even element, 
        /// a perfect square and two different elements that sum to 8. 
        /// For example, {3, 2, 9, 5} is complete because 2 is even, 
        /// 9 is a perfect square and a[0] + a[3] = 8.
        ///  Write a function named isComplete that 
        /// accepts an integer array and returns 1 if it is a 
        /// complete array, otherwise it returns 0. 
        /// Your method must be efficient. 
        /// It must return as soon as it is known that the array is complete. 
        /// Hint: reuse the method you wrote for question 1. 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isComplete(int[] a)
        {
            int isComplete = 0;
            int isEven = 0, isperfectsquare = 0;
            int isSum8 = 0,current=0;
            for (int i = 0; i < a.Length && isComplete==0; i++)
            {
                current = a[i];
                if (current % 2 == 0) isEven = 1;
                if (isSquare(current) == 1)
                    isperfectsquare = 1;
                for (int j = i + 1; j < a.Length && isSum8==0; j++)
                {

                    if (current + a[j] == 8)
                        isSum8 = 1;

                }

                if (isEven == 1 && isperfectsquare == 1 && isSum8 == 1)
                    isComplete = 1;
            }


            return isComplete;
        }


        /// <summary>
        ///  Write a function that takes two arguments, 
        /// an array of integers and a positive, 
        /// non-zero number n. It sums n elements of the array 
        /// starting at the beginning of the array. If n is 
        /// greater than the number of elements in the array, 
        /// the function loops back to the beginning of 
        /// the array and continues summing until it 
        /// has summed n elements. You may assume that 
        /// the array contains at least one element 
        /// and that n is greater than 0. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int loopSum(int[] a, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int index = i % a.Length;
                sum += a[index];
            }
            return sum;
        }
    }
}
