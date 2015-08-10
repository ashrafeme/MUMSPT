using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet12
{
  public static  class TestSet12
    {
        public static int smallest(int n)
        {
            int isSmallest = 0;
            int count = 0;
            int i = 0;
            do
            {
                i++;
                //check if it has 2;

                for (int j = 1; j <= n && HasDigitTwo(i * j); j++)
                {

                    count++;

                }

                if(count== n)
                {
                    isSmallest = i;
                }
                count = 0;
                

            } while (isSmallest == 0 );

            return isSmallest;
        }

        static bool HasDigitTwo(int n)
        {
            bool toreturn = false;

            do
            {
                int lastdigit = n % 10;
                if (lastdigit != 2)
                    n = n / 10;
                else toreturn = true;
            } while (n > 1 && toreturn == false);

            return toreturn;
        }


        public static int[] clusterCompression(int[] a)
        {

            int numClusters = 0;
             int[] testresult = new int[a.Length];
            

            int prev = 0, current = 0, i = 0; 
            while (i < a.Length)
            {
                current = a[i];
                if (i == 0)
                {
                    prev = current;
                    
                }
                if (prev != current)
                {
                    
                    numClusters++;
                    prev = current;
                }
                else
                {
                    testresult[numClusters] = prev;
                    i++;
                }
                //check for last

            }
            if (numClusters > 0)
            {
                // for last item
                numClusters++;
            }
            int[] result = new int[numClusters];
            for (int j = 0; j <= numClusters; j++)
            {
                result[j] = testresult[j];
            }

            return result;

        }

    }
}
