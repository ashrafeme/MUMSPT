using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet29
{
   public static class TestSet29
    {
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
    }
}
