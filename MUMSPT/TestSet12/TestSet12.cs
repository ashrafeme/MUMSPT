using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet12
{
  public static  class TestSet12
    {
        /// <summary>
        /// The number 124 has the property that it is 
        /// the smallest number whose first three multiples 
        /// contain the digit 2. Observe that
        /// 124*1 = 124, 124*2 = 248, 124*3 = 372 and that 124, 248 and 372 
        /// each contain the digit 2. It is possible to generalize this 
        /// property to be the smallest number whose first n multiples each 
        /// contain the digit 2. Write a function named smallest(n) 
        /// that returns the smallest number whose first n multiples 
        /// contain the digit 2. Hint: use modulo base 10 arithmetic to 
        /// examine digits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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



        /// <summary>
        /// Define a cluster in an integer array to be a maximum 
        /// sequence of elements that are all the same value. 
        /// For example, in the array {3, 3, 3, 4, 4, 3, 2, 2, 2, 2, 4} 
        /// there are 5 clusters, {3, 3, 3}, {4, 4}, {3}, {2, 2, 2, 2} and {4}. 
        /// A cluster-compression of an array replaces each cluster 
        /// with the number that is repeated in the cluster. So, 
        /// the cluster compression of the previous array would be {3, 4, 3, 2, 4}. 
        /// The first cluster {3, 3, 3} is replaced by a single 3, and so on.
        /// The function returns the cluster compression of the array a. 
        /// The length of the returned array must be equal to the number of 
        /// clusters in the original array! This means that someplace in your 
        /// answer you must dynamically allocate the returned array.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
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
            }
            numClusters++; // for last item
            if (a.Length == 0)
            {
                numClusters = 0;
            }
            int[] result = new int[numClusters];
            for (int j = 0; j < numClusters; j++)
            {
                result[j] = testresult[j];
            }
            return result;
        }

        /// <summary>
        /// Define an array to be a railroad-tie array if the following three conditions hold
        /// <list type="bullet">
        /// <item> 
        /// <description>a. The array contains at least one non-zero element.</description> 
        /// </item> 
        /// <item> 
        /// <description>b. Every non-zero element has exactly one non-zero neighbor</description> 
        /// </item> 
        /// <item> 
        /// <description>c. Every zero element has two non-zero neighbors.</description> 
        /// </item> 
        /// </list> 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isRailroadTie(int[] a)
        {
            int isRailroad = 1;
            int current = 0,hasnonzero=0;
            for (int i = 0; i < a.Length && isRailroad==1; i++)
            {
                // check if non zero
                current = a[i];
                int neighborcount = 0;
                if (i - 1 >= 0)
                    if (a[i - 1] != 0) neighborcount++;
                if (i + 1 < a.Length)
                    if (a[i + 1] != 0) neighborcount++;

                if ( current != 0)
                {
                    hasnonzero++;
                    
                    //check neighborcount
                    if (neighborcount != 1) isRailroad = 0;

                }
                else
                {
                    if (neighborcount != 2) isRailroad = 0;
                }
            }


            // last if The array contains at least one non-zero element

            if (hasnonzero < 1) isRailroad = 0;
            return isRailroad;
        }
    }
}
