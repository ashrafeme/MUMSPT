using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet15
{
   public static class TestSet15Test
    {
        public static void getExponent()
        {
            Console.WriteLine("test for getExponent ");
            Console.WriteLine("========================");

            Console.Write("getExponent of   162 , 3  is"); Console.WriteLine(" = {0}"
             , TestSet15.getExponent(162, 3));

            Console.Write("getExponent of  27 , 3  is"); Console.WriteLine(" = {0}"
            , TestSet15.getExponent(27, 3));

            Console.Write("getExponent of  28 , 3  is"); Console.WriteLine(" = {0}"
            , TestSet15.getExponent(28, 3));

            Console.Write("getExponent of  280 , 7  is"); Console.WriteLine(" = {0}"
                        , TestSet15.getExponent(280, 7));


            Console.Write("getExponent of  -250 , 5  is"); Console.WriteLine(" = {0}"
                        , TestSet15.getExponent(-250, 5));

            Console.Write("getExponent of  18 , 1  is"); Console.WriteLine(" = {0}"
                        , TestSet15.getExponent(18, 1));

            Console.Write("getExponent of  128 , 4  is"); Console.WriteLine(" = {0}"
                        , TestSet15.getExponent(128, 4));


            Console.WriteLine("========================");
        }

        public static void is121Array()
        {
            Console.WriteLine("test for is121Array ");
            Console.WriteLine("========================");

            Console.Write("is121Array of   {1, 2, 1}  is"); Console.WriteLine(" = {0}"
             , TestSet15.is121Array(new int[] { 1, 2, 1 }));

            Console.Write("is121Array of   {1, 1, 2, 2, 2, 1, 1}  is"); Console.WriteLine(" = {0}"
              , TestSet15.is121Array(new int[] { 1, 1, 2, 2, 2, 1, 1 }));

            Console.Write("is121Array of   {1, 1, 2, 2, 2, 1, 1, 1}  is"); Console.WriteLine(" = {0}"
                        , TestSet15.is121Array(new int[] { 1, 1, 2, 2, 2, 1, 1, 1 }));

            Console.Write("is121Array of   {1, 1, 2, 1, 2, 1, 1}  is"); Console.WriteLine(" = {0}"
                       , TestSet15.is121Array(new int[] { 1, 1, 2, 1, 2, 1, 1 }));

            Console.Write("is121Array of   {1, 1, 1, 2, 2, 2, 1, 1, 1, 3}  is"); Console.WriteLine(" = {0}"
                       , TestSet15.is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 1, 3 }));

            Console.Write("is121Array of   {1, 1, 1, 1, 1, 1}  is"); Console.WriteLine(" = {0}"
                       , TestSet15.is121Array(new int[] { 1, 1, 1, 1, 1, 1 }));

            Console.Write("is121Array of   {2, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1}  is"); Console.WriteLine(" = {0}"
                       , TestSet15.is121Array(new int[] { 2, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1 }));

            Console.Write("is121Array of   {1, 1, 1, 2, 2, 2, 1, 1, 2, 2}  is"); Console.WriteLine(" = {0}"
                       , TestSet15.is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 2, 2 }));

            Console.Write("is121Array of   {2, 2, 2}  is"); Console.WriteLine(" = {0}"
                       , TestSet15.is121Array(new int[] { 2, 2, 2 }));

            Console.WriteLine("========================");
        }

        public static void filterArray()
        {
            Console.WriteLine("test for filterArray ");
            Console.WriteLine("========================");

            string ss = "{";
            var output = TestSet15.filterArray(new int[] { 8, 4, 9, 0, 3, 1, 2 }, 88);
            for (int i = 0; i < output.Length; i++)
            {
                ss +=  output[i];
                if (i < output.Length - 1) ss += ",";

            }
            ss += "}";

            Console.Write("filterArray of    {8, 4, 9, 0, 3, 1, 2},88  is"); Console.WriteLine(" = {0}"
             , ss);




             ss = "{";
             output = TestSet15.filterArray(new int[] { 9, -9 },0);
            for (int i = 0; i < output.Length; i++)
            {
                ss += output[i];
                if (i < output.Length - 1) ss += ",";

            }
            ss += "}";

            Console.Write("filterArray of    {9, -9},0  is"); Console.WriteLine(" = {0}"
             , ss);


            ss = "{";
            output = TestSet15.filterArray(new int[] { 9, -9 }, 1);
            for (int i = 0; i < output.Length; i++)
            {
                ss += output[i];
                if (i < output.Length - 1) ss += ",";

            }
            ss += "}";

            Console.Write("filterArray of    {9, -9},1  is"); Console.WriteLine(" = {0}"
             , ss);


            ss = "{";
            output = TestSet15.filterArray(new int[] { 9, -9 }, 2);
            for (int i = 0; i < output.Length; i++)
            {
                ss += output[i];
                if (i < output.Length - 1) ss += ",";

            }
            ss += "}";

            Console.Write("filterArray of    {9, -9},2  is"); Console.WriteLine(" = {0}"
             , ss);


            ss = "{";
            output = TestSet15.filterArray(new int[] { 9, -9 }, 3);
            for (int i = 0; i < output.Length; i++)
            {
                ss += output[i];
                if (i < output.Length - 1) ss += ",";

            }
            ss += "}";

            Console.Write("filterArray of    {9, -9},3  is"); Console.WriteLine(" = {0}"
             , ss);


            ss = "{";
            output = TestSet15.filterArray(new int[] { 9, -9 }, 4);
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
            Console.Write("filterArray of    {9, -9},4  is"); Console.WriteLine(" = {0}"
             , ss);


            ss = "{";
            output = TestSet15.filterArray(new int[] { 9, -9, 5 }, 3);
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


            ss = "{";
            output = TestSet15.filterArray(new int[] { 0, 9, 12, 18, -6 }, 11);
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
            Console.Write("filterArray of    {0, 9, 12, 18, -6}, 11  is"); Console.WriteLine(" = {0}"
             , ss);

            Console.WriteLine("========================");
        }

    }
}
