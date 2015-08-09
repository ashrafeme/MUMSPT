using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT
{
    class PreTest
    {


        public static int equivalentArrays(int[] a1,int[] a2)
        {
            int isequivalent = 1;

            if (a1.Length == 0 && a2.Length == 0)
                return 0;

           

            for (int i = 0; i < a1.Length; i++)
            {
                int isqula = 0;
                for (int k = 0; k < a2.Length; k++)
                {
                    if (a1[i] == a2[k])
                    {
                        isqula = 1;
                        break;
                    }
                }
                if(isqula == 0)
                {
                    return 0;
                }
               
            }

            for (int i = 0; i < a2.Length; i++)
            {
                int isqula = 0;
                for (int k = 0; k < a1.Length; k++)
                {
                    if (a2[i] == a1[k])
                    {
                        isqula = 1;
                        break;
                    }
                }
                if (isqula == 0)
                {
                    return 0;
                }
            }

            return isequivalent;
        }

        public static int isStepped(int[] a)
        {
            int isStepped = 1;
            int distinctvalue = 0;
            int nextdistintvalue = 0;
            int distincaccurce = 0;
            int lastdislaue = 0;
            var dislvaue = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                // check if the value is accurce 3 or more time
             

                if (i == 0)
                {
                    lastdislaue = distinctvalue;
                }

                if (i < a.Length -1)
                {
                    nextdistintvalue = a[i+1];
                }
                else
                {
                    nextdistintvalue = a[i];
                }

                // check if it ascending order
                if ((distinctvalue == lastdislaue) && distinctvalue  <= nextdistintvalue)
                {
                   
                        distincaccurce++;
                    
                }
                else
                {
                  //  distincaccurce++;
                    // check for new dis
                    if (distincaccurce < 3)
                    {
                        // exist
                        isStepped = 0;
                        return 0;
                    }
                    if (nextdistintvalue > distinctvalue)
                    {
                        isStepped = 0;
                        return 0;
                    }
                    
                    distincaccurce = 0;

                }
            }

            return isStepped;
        }
        public static int isRapidlyIncreasing(int[] a)
        {
            int israpid = 1;
            if (a.Length == 1)
            {
                israpid = 1;
            }
            else
            {
                for (int i = 1; i < a.Length; i++)
                {
                    int rapidvalue = a[i];
                    int prevtotalvalue = 0;
                    for (int j = 0; j < i; j++)
                    {
                        prevtotalvalue += a[j];
                    }
                    int va = 2 * prevtotalvalue;
                    if (rapidvalue <= va)
                    {
                        return 0;
                    }

                }
            }

            return israpid;
        }
        public static int isPerfectSquare(int n)
        {
            int nextPerfectSquare = 0;
            if (n >= 0)
            {

                double sqrtResult = Math.Floor(Math.Sqrt(n));
                double nextNumber = sqrtResult + 1;
                nextPerfectSquare = (int)Math.Pow(nextNumber, 2);

            }
            return nextPerfectSquare;
        }

        public static int nUpCount(int[] a,int n)
        {
            int upCount = 0;
            int partialSum,previousPartialSum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                partialSum = previousPartialSum + a[i];
                if(previousPartialSum <= n)
                {
                    if(partialSum > n)
                    {
                        upCount++;
                    }
                }

                previousPartialSum = partialSum;
            }

            return upCount;
        }

        public static List<int> Factor(int number)
        {

            int max = (int)Math.Sqrt(number);
            List<int> factors = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                    if (i != number / i)
                    {
                        factors.Add(number / i);
                    }
                }
            }

            return factors;
        }

        public static List<int> Factors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }

            }

            return factors;
        }

        public static bool IsPrimeNumber(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPrimes(int number)
        {
            // first check if it 0 or 1
            if (number < 2)
            {
                return false;
            }
            bool isone = false;
            bool isNumber = false;
            int numberofFactor = 0;
            for (int i = 1; i <= number; i++)
            {
                
                if (number % i == 0)
                {
                    numberofFactor++;
                    if(i == 1)
                    {
                        isone = true;
                    }
                    if (i == number)
                    {
                        isNumber = true;
                    }
                }
            }
            return (isone && isNumber &&(numberofFactor == 2));
        }

        public static bool IsPrime(int number)
        {
            // no Even Number except 2
            if ((number % 2) == 0)
            {
                return number == 2;
            }
            int sqrt = (int)Math.Sqrt(number);
            for (int t = 3; t <= sqrt; t = t + 2)
            {
                if (number % t == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }
    }
}
