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

            //if (zerocount < 4 ) isZero = 0;
            //else
            //{
            //    count++;

            //}

            if (isZero == 1) isZero = count;
            return isZero;
        }
    }
}
