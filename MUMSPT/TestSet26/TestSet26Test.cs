using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet26
{
    public static class TestSet26Test
    {
        public static void isNPrimeable()
        {
            Console.WriteLine("test for isNPrimeable ");
            Console.WriteLine("========================");

            Console.Write("isNPrimeable of   {5, 15, 27} and 2 is"); Console.WriteLine(" = {0}"
              , TestSet26.isNPrimeable(new int[] { 5, 15, 27 }, 2));

            Console.Write("isNPrimeable of   {5, 15, 27} and 3 is"); Console.WriteLine(" = {0}"
              , TestSet26.isNPrimeable(new int[] { 5, 15, 27 }, 3));

            Console.Write("isNPrimeable of   {5, 15, 26} and 2 is"); Console.WriteLine(" = {0}"
              , TestSet26.isNPrimeable(new int[] { 5, 15, 26 }, 2));

            Console.Write("isNPrimeable of   {1, 1, 1, 1, 1, 1, 1} and 4 is"); Console.WriteLine(" = {0}"
              , TestSet26.isNPrimeable(new int[] { 1, 1, 1, 1, 1, 1, 1 }, 4));

            Console.Write("isNPrimeable of   {} and 2 is"); Console.WriteLine(" = {0}"
              , TestSet26.isNPrimeable(new int[] { }, 2));

            Console.WriteLine("========================");
            //TestSet25.TestSet25Test.isMartian();
        }

        public static void pairwiseSum()
        {
            Console.WriteLine("test for computeHMS ");
            Console.WriteLine("========================");

            string ss = "";

            ss = "{";
            var output = TestSet26.pairwiseSum(new int[] { 2, 1, 18, -5 });
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
            Console.Write("pairwiseSum of    {2, 1, 18, -5}   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/

            //
            ss = "{";
            output = TestSet26.pairwiseSum(new int[] { 2, 1, 18, -5, -5, -15, 0, 0, 1, -1 });
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
            Console.Write("pairwiseSum of   {2, 1, 18, -5, -5, -15, 0, 0, 1, -1}  is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/

            /********************************************************/

            //
            ss = "{";
            output = TestSet26.pairwiseSum(new int[] { 2, 1, 18 });
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
            Console.Write("pairwiseSum of   {2, 1, 18} is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/

            /********************************************************/

            //
            ss = "{";
            output = TestSet26.pairwiseSum(new int[] { });
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
            Console.Write("pairwiseSum of   { }  is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/

            /********************************************************/
        }

        public static void is121Array()
        {
            TestSet15.TestSet15Test.is121Array();
        }
    }
}
