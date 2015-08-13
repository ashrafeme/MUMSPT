using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet17
{
   public static class TestSet17
    {


        public static int largestPrimeFactor(int n)
        {
            int largestpf = 0;

            if (n <= 1) return 0;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    if (Helper.isPrime(i))
                        if (i > largestpf)
                            largestpf = i;
            }

            return largestpf;
        }

        public static int[] encodeNumber(int n)
        {
            if (n < 2) return null;
            int  primecount = 0;
            List<int> temparray = new List<int>(); // temp array if you i can to use it
            int i= 2;
            do
            {
                if (Helper.isPrime(i))
                {
                    if (n % i == 0)
                    {
                        primecount++;
                        temparray.Add(i);
                    }
                    n = n / i;
                }
                else
                {
                    i++;
                }
            } while (n>1);

            int[] encodearray = new int[primecount];
            for (int j = 0; j < primecount; j++)
            {
                encodearray[i] = temparray[i];

            }

            return encodearray;
        }
    }
}
