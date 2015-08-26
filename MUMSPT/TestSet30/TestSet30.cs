using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet30
{
   public static class TestSet30
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int isMeera(int[] a)
        {
            int isMeera = 0;

            int isPrime = -1, isZero = -1;

            for (int i = 0; i < a.Length && isMeera ==0; i++)
            {
                if (Helper.isPrime(a[i])) isPrime = 1;
                if (a[i] == 0) isZero = 1;

                if ((isZero == 1 && isPrime == 1))
                    isMeera = 1;
            }

            if (isPrime == -1 && isZero == -1)
                isMeera = 1;

            return isMeera;
        }

        public static int isBean(int[] a)
        {
            int isBean = 1;

            for (int i = 0; i < a.Length && isBean==1; i++)
            {
                int isValid = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j] + 1 || a[i] == a[j] - 1)
                    {
                        isValid = 1;
                        break;
                    }
                }

                if (isValid == 0)
                    isBean = 0;
            }

            return isBean;
        }

        public static int[] fill(int[] arr, int k, int n)
        {
            if (k < 1 || n < 1) return null;
            int index = 0;
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                index = i % k;
                arr2[i] = arr[index];
            }

            return arr2;
        }

        public static Boolean sumIsPower(int[] arr)
        {
          

            int sum = 0, power = 2;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                power *= 2;
            }


            

            return (sum == power);
        }

        public static int isHollow(int[] a)
        {
            int isHollow = 1;

            int precdingzero = 0, midzero = 0, followingzero = 0, current = 0;
            

            
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
                       
                        midzero++;
                    }
                    else if (precdingzero != 0 && followingzero == 0 )
                    {
                        midzero++;
                    }
                }
            }
           
            if (precdingzero != followingzero || midzero < 3)
                isHollow = 0;

            return isHollow;
        }

        public static int isBean913(int[] a)
        {
            int isBean = 1;
            int has9 = 0, has13 = 0, has7 = 0, has16 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 9)
                    has9 = 1;
                if (a[i] == 13)
                    has13 = 1;

                if (a[i] == 7)
                    has7 = 1;
                if (a[i] == 16)
                {
                    has16 = 1;
                    if (has7 == 1) break;
                }
            }

            if ((has9 == 1 && has13 == 0) || (has7 == 1 && has16 == 1))
                isBean = 0;
            return isBean;
        }
    }
}
