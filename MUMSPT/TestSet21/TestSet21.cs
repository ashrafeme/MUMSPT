using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet21
{
    public static class TestSet21
    {
        /// <summary>
        /// An array is called systematically increasing if it 
        /// consists of increasing sequences of the numbers from 1 to n.
        /// The first six (there are over 65,000 of them) systematically increasing arrays are:
        /// {1}
        /// {1, 1, 2}
        /// {1, 1, 2, 1, 2, 3}
        /// {1, 1, 2, 1, 2, 3, 1, 2, 3, 4}
        /// {1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5}
        /// {1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6}
        /// Write a function named isSystematicallyIncreasing which 
        /// returns 1 if its array argument is systematically increasing. Otherwise it returns 0.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isSystematicallyIncreasing(int[] a)
        {
            int isSystematicallyIncreasing = 0;

            int i = 0, k = 0;
            int current = 0;
            do
            {
                current = a[i];
                k = i;
                do
                {
                    //if()
                    k++;
                } while (k <= i + i);

                i = k;

            } while (i< a.Length);

            return isSystematicallyIncreasing;
        }
    }
}
