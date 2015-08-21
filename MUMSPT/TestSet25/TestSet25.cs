using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet25
{
   public static class TestSet25
    {
        /// <summary>
        /// Write a method named computeHMS 
        /// that computes the number of hours, 
        /// minutes and seconds in a given number of seconds.
        /// If you are programming in Java or C#, the method signature is
        /// int[] computeHMS(int seconds);
        /// The returned array has 3 elements; 
        /// arr[0] is the hours, arr[1] is the minutes and arr[2] 
        /// is the seconds contained within the seconds argument.
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static int[] computeHMS(int seconds)
        {
            int secondsData = 3600;
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = seconds / secondsData;
                seconds = seconds % secondsData;
                secondsData = secondsData / 60;
            }
            return arr;
        }


        /// <summary>
        /// Define an array to be a Martian array if 
        /// the number of 1s is greater than the 
        /// number of 2s and no two adjacent elements are equal. 
        /// Write a function named isMartian that returns 1 if its 
        /// argument is a Martian array; otherwise it returns 0.
        /// There are two additional requirements.
        /// 1. You should return 0 as soon as it is 
        /// known that the array is not a Martian array; 
        /// continuing to analyze the array would be a waste of CPU cycles.
        /// 2. There should be exactly one loop in your solution.
        /// Hint: Make sure that your solution does not exceed the boundaries of the array!
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isMartian(int[] a)
        {
            int isMartian = 1;
            int oneCount = 0, TwoCount = 0;
            for (int i = 0, j = a.Length - 1; i < j && isMartian == 1; i++, j--)
            {
                if (a[i] == 1)
                    oneCount++;
                else if (a[i] == 2)
                    TwoCount++;
                if (a[j] == 1)
                    oneCount++;
                else if (a[j] == 2)
                    TwoCount++;


                // check for adjacent elements are equal
                if (a[i] == a[i + 1] || a[j] == a[j - 1])
                {
                    isMartian = 0;
                    break;
                }


                // if array length event
                if (j - i == 1)
                {
                    if (oneCount <= TwoCount) isMartian = 0;
                }

                // if array length odd
                if (j - i == 2)
                {
                    // last element the middle of the array
                    i++;

                    if (a[i] == 1)
                        oneCount++;
                    else if (a[i] == 2)
                        TwoCount++;

                    if (oneCount <= TwoCount) isMartian = 0;
                }
            }

            return isMartian;
            
        }

        /// <summary>
        /// An array is defined to be paired-N if 
        /// it contains two distinct elements that 
        /// sum to N for some specified value of 
        /// N and the indexes of those elements 
        /// also sum to N. Write a function named 
        /// isPairedN that returns 1 if its array 
        /// parameter is a paired-N array, 
        /// otherwise it returns 0. 
        /// The value of N is passed as the second parameter.
        /// There are two additional requirements.
        /// 1. Once you know the array is paired-N, 
        /// you should return 1. No wasted loop iterations please.
        /// 2. Do not enter the loop unless you have to. 
        /// You should test the length of the array and the 
        /// value of n to determine whether the array 
        /// could possibly be a paired-N array. 
        /// If the tests indicate no, 
        /// return 0 before entering the loop.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isPairedN(int[] a, int n)
        {
            int isPairedN = 0;

            if (a.Length - 1 + a.Length - 2 < n || n < 0)
            {
                return 0;
            }

            for (int i = 0; i < a.Length && isPairedN==0; i++)
            {
                for (int j = i; j < a.Length && isPairedN == 0; j++)
                {
                    if(a[i] +a[j] == n)
                    {
                        if (i + j == n)
                            isPairedN = 1;
                    }
                }
            }

            return isPairedN;
        }

    }
}
