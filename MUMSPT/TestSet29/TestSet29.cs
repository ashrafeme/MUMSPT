using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet29
{
   public static class TestSet29
    {
        /// <summary>
        ///  Write a function named eval that 
        /// returns the value of the polynomial 
        /// anxn + an-1xn-1 + ... + a1x1 + a0.
        /// If you are programming in Java or C#, 
        /// the function signature is double eval(double x, int[ ] a)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double eval(int[] a,double x)
        {
            double eval = 0;
            int current = 0;
            for (int i = 0; i < a.Length; i++)
            {
                current = a[i];
                if (i == 0)
                    eval += current;
                else
                {
                    eval += current * (Math.Pow(x, i));
                }
            }
            return eval;
        }


        /// <summary>
        ///  A non-empty array a of length n 
        /// is called an array of all possiblities 
        /// if it contains all numbers between 0 and 
        /// a.length-1 inclusive. Write a method named 
        /// isAllPossibilities that accepts an integer array and returns 
        /// 1 if the array is an array of all 
        /// possiblities, otherwise it returns 0. 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isAllPossibilities(int[] a)
        {
            int isAllPosibilities = 1;

            if (a.Length == 0) isAllPosibilities = 0;

            for (int i = 0; i < a.Length && isAllPosibilities==1; i++)
            {
                int index = -1;
                for (int j = 0; j < a.Length && index==-1; j++)
                {
                    if (i == a[j]) index = j;
                }
                if (index == -1)
                    isAllPosibilities = 0;
            }

            return isAllPosibilities;
        }


        /// <summary>
        /// An array is called layered if its elements 
        /// are in ascending order and each element appears 
        /// two or more times. 
        /// For example, {1, 1, 2, 2, 2, 3, 3} 
        /// is layered but 
        /// {1, 2, 2, 2, 3, 3} 
        /// and {3, 3, 1, 1, 1, 2, 2}  are not. 
        /// Write a method named isLayered that accepts 
        /// an integer array and 
        /// returns 1 if the array is layered, otherwise it returns 0. 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isLayered(int[] a)
        {
            int isLayered = 1;
            if (a.Length == 0) isLayered = 0;
            int  count = 0;
            for (int i = 0; i < a.Length && isLayered==1; i++)
            {
                count++;
                if (i < a.Length - 1)
                {
                    if (a[i] != a[i + 1])
                    {
                        if (count < 2)
                            isLayered = 0;
                        count = 0;
                    }
                    if(a[i] > a[i + 1])
                    {
                        isLayered = 0;
                    }
                }
                else
                {
                    if (count < 2)
                        isLayered = 0;
                }
            }

            return isLayered;
        }


        /// <summary>
        ///  A mileage counter is used to measure mileage in an automobile. 
        /// A mileage counter looks something like this 0 5 9 9 8
        /// The above mileage counter says that the car has travelled 
        /// 5,998 miles. Each mile travelled by the automobile 
        /// increments the mileage counter. Here is how 
        /// the above mileage counter changes over a 3 mile drive.
        /// After the first mile 0 5 9 9 9
        /// After the second mile 0 6 0 0 0
        /// After the third mile 0 6 0 0 1
        /// A mileage counter can be represented as an array. The mileage counter 0 5 9 9 8
        /// can be represented as the array int a[ ] = new int[ ] {8, 9, 9, 5, 0} 
        /// Note that the mileage counter is "backwards" in the array, a[0] represents ones,
        ///  a[1] represents tens, a[2] represents hundreds, etc. 
        /// Write a function named updateMileage that takes 
        /// an array representation of a mileage counter 
        /// (which can be arbitrarily long) and adds a given 
        /// number of miles to the array. Since arrays are 
        /// passed by reference you can update the array in the function, 
        /// you do not have to return the updated array.
        /// You do not have to do any error checking. 
        /// You may assume that the array contains 
        /// non-negative digits and that the mileage is non-negative 
        /// Hint: Write a helper function that adds 1 to the mileage 
        /// counter and call the helper function once for each mile
        /// </summary>
        /// <param name="a"></param>
        /// <param name="miles"></param>
        /// <returns></returns>
        public static int[] updateMileagecounter(int[] a, int miles)
        {
            for (int i = 1; i <= miles; i++)
            {
                UpdateMiles(a, 1, 0);
            }
            return a;
        }

        private static void UpdateMiles(int[] a, int mile, int index)
        {
            if (index < a.Length)
            {
                int current = a[index];
                if (current + mile == 10)
                {
                    a[index] = 0;
                    UpdateMiles(a, mile, index + 1);
                }
                else
                {
                    a[index] = current + mile;
                }
            }
        }


        /// <summary>
        ///  An array is said to be hollow if it 
        /// contains 3 or more zeros in the 
        /// middle that are preceded and 
        /// followed by the same number of 
        /// non-zero elements. Furthermore, 
        /// all the zeroes in the array must 
        /// be in the middle of the array.
       ///  Write a function named isHollow that accepts an integer array and returns 1 if it is a hollow array, otherwise it returns 0. 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isHollow(int[] a)
        {
            int isHollow = 1;

            int precdingzero = 0, midzero=0, followingzero = 0,current=0;
            bool isNotMiddle = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] != 0 && midzero == 0) {
                    precdingzero++;
                }
            }

            /*
            for (int i = 0; i < a.Length && isHollow==1; i++)
            {
                current = a[i];
                //
                if (current != 0)
                {
                    if (precdingzero != 0 && midzero != 0)
                    {
                        followingzero++;
                    }
                    else if (midzero == 0 && followingzero == 0)
                    {
                        precdingzero++;
                    }
                }
                else
                {
                    if (precdingzero != 0 && followingzero != 0)
                        isHollow = 0;
                    else if (precdingzero == 0 && followingzero == 0)
                    {
                        isNotMiddle = true;
                        midzero++;
                    }
                    else if (precdingzero != 0 && followingzero == 0 && isNotMiddle == false)
                    {
                        midzero++;
                    }
                }
            }
            */
            if (precdingzero != followingzero || midzero < 3)
                isHollow = 0;

            return isHollow;
        }

    }
}
