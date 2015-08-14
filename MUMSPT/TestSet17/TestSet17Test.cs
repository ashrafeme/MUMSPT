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
            Console.WriteLine("test for encodeNumber ");
            Console.WriteLine("========================");

            /************************************************************************/

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
            Console.Write("encodeNumber of    6936  is"); Console.WriteLine(" = {0}"
             , ss);


            /************************************************************************/

            ss = "{";
             output = TestSet17.encodeNumber(2);
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
            Console.Write("encodeNumber of    2  is"); Console.WriteLine(" = {0}"
             , ss);


            /************************************************************************/

            ss = "{";
            output = TestSet17.encodeNumber(6);
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
            Console.Write("encodeNumber of    6  is"); Console.WriteLine(" = {0}"
             , ss);

            /************************************************************************/

            ss = "{";
            output = TestSet17.encodeNumber(14);
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
            Console.Write("encodeNumber of    14  is"); Console.WriteLine(" = {0}"
             , ss);

            /************************************************************************/

            ss = "{";
            output = TestSet17.encodeNumber(24);
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
            Console.Write("encodeNumber of    24  is"); Console.WriteLine(" = {0}"
             , ss);

            /************************************************************************/


            ss = "{";
            output = TestSet17.encodeNumber(1200);
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
            Console.Write("encodeNumber of    1200  is"); Console.WriteLine(" = {0}"
             , ss);

            /************************************************************************/


            ss = "{";
            output = TestSet17.encodeNumber(1);
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
            Console.Write("encodeNumber of    1  is"); Console.WriteLine(" = {0}"
             , ss);

            /************************************************************************/

            ss = "{";
            output = TestSet17.encodeNumber(-18);
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
            Console.Write("encodeNumber of    -18  is"); Console.WriteLine(" = {0}"
             , ss);

            /************************************************************************/

        }

        public static void matchPattern()
        {
            Console.WriteLine("test for matchPattern ");
            Console.WriteLine("========================");

            Console.Write("matchPattern of   {1, 1, 1, 2, 2, 1, 1, 3} , {1, 2, 1, 3}  is"); Console.WriteLine(" = {0}"
             , TestSet17.matchPattern(new int[] { 1, 1, 1, 2, 2, 1, 1, 3 }, new int[] { 1, 2, 1, 3 }));

            Console.Write("matchPattern of   {1, 1, 1, 1, 1} , {1}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 }));

            Console.Write("matchPattern of   {1} , {1}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1 }, new int[] { 1 }));

            Console.Write("matchPattern of   {1, 1, 2, 2, 2, 2} , {1, 2}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 1, 2, 2, 2, 2 }, new int[] { 1, 2 }));

            Console.Write("matchPattern of   {1, 2, 3} , {1, 2}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));


            Console.Write("matchPattern of   {1, 2} , {1, 2,3}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 2 }, new int[] { 1, 2,3 }));


            Console.Write("matchPattern of   {1, 1, 2, 2, 2, 2, 3} , {1, 2}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 1, 2, 2, 2, 2, 3 }, new int[] { 1, 2 }));


            Console.Write("matchPattern of   {1, 1, 1, 1} , {1, 2}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 1, 1, 1 }, new int[] { 1, 2 }));

            Console.Write("matchPattern of   {1, 1, 1, 1, 2, 2, 3, 3} , {1, 2}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 1, 1, 1, 2, 2, 3, 3 }, new int[] { 1, 2 }));


            Console.Write("matchPattern of   {1, 1, 10, 4, 4, 3} , {1, 4, 3}  is"); Console.WriteLine(" = {0}"
            , TestSet17.matchPattern(new int[] { 1, 1, 10, 4, 4, 3 }, new int[] { 1, 4, 3 }));


            Console.WriteLine("========================");
        }

    }
}
