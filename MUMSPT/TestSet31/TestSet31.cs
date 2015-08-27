using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet31
{
   public static class TestSet31
    {
        public static int isDual(int[] a)
        {
            int isDual = 1;

            if (a.Length % 2 != 0) isDual = 0;

            int sum = 0;

            for (int i = 0; i < a.Length && isDual == 1; i = i + 2)
            {
                if (i == 0)
                {
                    sum = a[i] + a[i + 1];
                }
                else
                {
                    if (sum != a[i] + a[i + 1])
                    {
                        isDual = 0;
                    }
                }
            }

            return isDual;
        }

        public static int isAllPossibilities(int[] a)
        {
            int isAllPosibilities = 1;

            if (a.Length == 0) isAllPosibilities = 0;

            for (int i = 0; i < a.Length && isAllPosibilities == 1; i++)
            {
                int index = -1;
                for (int j = 0; j < a.Length && index == -1; j++)
                {
                    if (i == a[j]) index = j;
                }
                if (index == -1)
                    isAllPosibilities = 0;
            }

            return isAllPosibilities;
        }


        public static int isLayered(int[] a)
        {
            int isLayered = 1;
            if (a.Length == 0) isLayered = 0;
            int count = 0;
            for (int i = 0; i < a.Length && isLayered == 1; i++)
            {
                count++;
                if (i < a.Length - 1)
                {
                    if (a[i] != a[i + 1])
                    {
                        if (count < 2)
                            isLayered = 0;
                        count = 0;
                    }
                    if (a[i] > a[i + 1])
                    {
                        isLayered = 0;
                    }
                }
                else
                {
                    if (count < 2)
                        isLayered = 0;
                }
            }

            return isLayered;
        }
    }
}
