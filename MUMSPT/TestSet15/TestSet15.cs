using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet15
{
   public static class TestSet15
    {

        public static int getExponent(int n, int p)
        {
            int x = 0;
            int max = 0;
            do
            {
                x++;
                max = (int)Math.Pow(p, x);
                int d = 0;
                do
                {
                    d++;
                    max += (int)Math.Pow(2, d);
                    
                } while (max <n);

            } while (max < n);

            return x;
        }
    }
}
