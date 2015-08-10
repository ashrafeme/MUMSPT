using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet11
{
    public static class TestSet11
    {
        /// <summary>
        /// Define an array to be a Martian array if the number of 
        /// 1s is greater than the number of 2s and no two adjacent 
        /// elements are equal. Write a function named isMartian that 
        /// returns 1 if its array argument is a Martian array, 
        /// otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isMartian(int[] a)
        {
            int isMartian = 1;
            int oneCount = 0, TwoCount = 0;
            for (int i = 0; i < a.Length && isMartian == 1; i++)
            {
                if (a[i] == 1) oneCount++;
                else if (a[i] == 2) TwoCount++;
                else
                {
                    if (i < a.Length - 1) // chek if not last item
                    {
                        if (a[i] == a[i + 1]) isMartian = 0;
                    }
                }
            }
            if (oneCount <= TwoCount) isMartian = 0;
            return isMartian;
        }

        public static int closestFibonacci(int n)
        {
            int closestFibonacci = 0;
            if (n > 0)
            {
                int a = 0, b = 1, c = a + b;

                do
                {
                    a = b;
                    b = c;
                    c = a + b;
                    if (c >= n)
                    {
                        closestFibonacci = b;
                    }
                } while (c <= n);
            }
            return closestFibonacci;
        }

    }
}
