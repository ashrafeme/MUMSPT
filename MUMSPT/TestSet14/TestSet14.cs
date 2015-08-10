using System;

namespace MUMSPT.TestSet14
{
    public static class TestSet14
    {
        public static int fullnessQuotient(int n)
        {
            int isfullness = 0;

            if (n < 0) return -1;

            for (int i = 2; i < 10; i++)
            {
                // conver the number to bases
                int num = n;
                int j = 0;
                int hasezero = 0;
                int sum = 0;
                do
                {
                    int med = num % i;
                    sum += med * (int)Math.Pow(i, j);
                    if (med == 0)
                    {
                        hasezero = 1;
                    }
                    num = num / i;
                    j++;
                }
                while (sum < n);
                if (hasezero == 0)
                    isfullness++;
            }

            return isfullness;
        }

        public static int isPacked(int[] a)
        {
            int isPacked = 1;
            int allpositive = 1;
            //int indexcount = 0;
            for (int i = 0; i < a.Length && isPacked == 1; i++)
            {
                int count = 0;
                //bool exitloop = false;
                for (int j = 0; j < a.Length && isPacked == 1; j++)
                {
                    if (a[i] < 0) allpositive = 0;

                    if (a[i] == a[j])
                    {
                        count++;
                    }
                    else
                    {
                        if (j >= i)
                            if (count != a[i]) isPacked = 0;
                    }
                }
                if (count != a[i]) isPacked = 0;
            }
            if (allpositive == 0)
                isPacked = allpositive;
            return isPacked;
        }

        public static int isOddHeavy(int[] a)
        {
            int isOddHeavy = 1;

            int oddcount = 0;
            for (int i = 0; i < a.Length && isOddHeavy ==1; i++)
            {
                if(a[i]% 2 == 1) {
                    oddcount++;
                    for (int j = 0; j < a.Length && isOddHeavy ==1; j++)
                    {
                        if(a[j] % 2 == 0) {
                            if (a[i] < a[j]) isOddHeavy = 0;
                        }
                    }
                }

            }

            // check for oddcount
            if (oddcount < 1) isOddHeavy = 0;
            return isOddHeavy;
        }
    }
}