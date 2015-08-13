using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet17
{
    public static class TestSet17Test
    {
        public static void largestPrimeFactor()
        {
            Console.WriteLine("test for largestPrimeFactor ");
            Console.WriteLine("========================");

            Console.Write("largestPrimeFactor of   10   is"); Console.WriteLine(" = {0}"
             , TestSet17.largestPrimeFactor(10));

            Console.Write("largestPrimeFactor of   6936    is"); Console.WriteLine(" = {0}"
              , TestSet17.largestPrimeFactor(6936));

            Console.Write("largestPrimeFactor of   1    is"); Console.WriteLine(" = {0}"
              , TestSet17.largestPrimeFactor(1));

            Console.WriteLine("========================");
        }


        public static void encodeNumber()
        {
            Console.WriteLine("test for filterArray ");
            Console.WriteLine("========================");

            string ss = "{";
            var output = TestSet17.encodeNumber(6936);
            if (output != null)
            {
                for (int i = 0; i < output.Length; i++)
                {
                    ss += output[i];
                    if (i < output.Length - 1) ss += ",";

                }
                ss += "}";
            }
            else
            {
                ss = "NULL";
            }
            Console.Write("filterArray of    {9, -9, 5}, 3  is"); Console.WriteLine(" = {0}"
             , ss);
        }

    }
}
