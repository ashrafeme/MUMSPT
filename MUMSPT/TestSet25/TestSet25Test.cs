using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet25
{
    public static class TestSet25Test
    {
        public static void computeHMS()
        {
            Console.WriteLine("test for computeHMS ");
            Console.WriteLine("========================");

            string ss = "";

            ss = "{";
            var output = TestSet25.computeHMS(3735);
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
            Console.Write("computeHMS of   3735   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/

            //
            ss = "{";
            output = TestSet25.computeHMS(380);
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
            Console.Write("computeHMS of   380   is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/

            //
            ss = "{";
            output = TestSet25.computeHMS(3650);
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
            Console.Write("computeHMS of   3650   is"); Console.WriteLine(" = {0}"
             , ss);



            /********************************************************/

            

            //
            ss = "{";
            output = TestSet25.computeHMS(55);
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
            Console.Write("computeHMS of   55   is"); Console.WriteLine(" = {0}"
             , ss);



            /********************************************************/


            /********************************************************/



            //
            ss = "{";
            output = TestSet25.computeHMS(0);
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
            Console.Write("computeHMS of   0   is"); Console.WriteLine(" = {0}"
             , ss);



            /********************************************************/
        }

        public static void isMartian()
        {
            Console.WriteLine("test for isMartian ");
            Console.WriteLine("========================");

            Console.Write("isMartian of   {1, 3} is"); Console.WriteLine(" = {0}"
              , TestSet25.isMartian(new int[] { 1, 3 }));

            Console.Write("isMartian of   {1, 2, 1, 2, 1, 2, 1, 2, 1} is"); Console.WriteLine(" = {0}"
             , TestSet25.isMartian(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1 }));


            Console.Write("isMartian of   {1, 3, 2} is"); Console.WriteLine(" = {0}"
             , TestSet25.isMartian(new int[] { 1, 3, 2 }));

            Console.Write("isMartian of   {1, 3, 2, 2, 1, 5, 1, 5} is"); Console.WriteLine(" = {0}"
             , TestSet25.isMartian(new int[] { 1, 3, 2, 2, 1, 5, 1, 5 }));

            Console.Write("isMartian of   {1, 2, -18, -18, 1, 2} is"); Console.WriteLine(" = {0}"
             , TestSet25.isMartian(new int[] { 1, 2, -18, -18, 1, 2 }));

            Console.Write("isMartian of   {} is"); Console.WriteLine(" = {0}"
             , TestSet25.isMartian(new int[] { }));

            Console.Write("isMartian of   {1} is"); Console.WriteLine(" = {0}"
             , TestSet25.isMartian(new int[] { 1 }));

            Console.Write("isMartian of   {2} is"); Console.WriteLine(" = {0}"
            , TestSet25.isMartian(new int[] { 2 }));


            Console.WriteLine("========================");
            
        }

        public static void isPairedN()
        {
            Console.WriteLine("test for isPairedN ");
            Console.WriteLine("========================");

            Console.Write("isPairedN of   {1, 4, 1, 4, 5, 6} and 5 is"); Console.WriteLine(" = {0}"
              , TestSet25.isPairedN(new int[] { 1, 4, 1, 4, 5, 6 }, 5));

            Console.Write("isPairedN of   {1, 4, 1, 4, 5, 6} and 6 is"); Console.WriteLine(" = {0}"
              , TestSet25.isPairedN(new int[] { 1, 4, 1, 4, 5, 6 }, 6));

            Console.Write("isPairedN of   {0, 1, 2, 3, 4, 5, 6, 7, 8} and 6 is"); Console.WriteLine(" = {0}"
              , TestSet25.isPairedN(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 6));

            Console.Write("isPairedN of  { 1, 4, 1} and 5 is"); Console.WriteLine(" = {0}"
              , TestSet25.isPairedN(new int[] { 1, 4, 1 }, 5));

            Console.Write("isPairedN of  {8, 8, 8, 8, 7, 7, 7} and 15 is"); Console.WriteLine(" = {0}"
              , TestSet25.isPairedN(new int[] { 8, 8, 8, 8, 7, 7, 7 }, 15));

            Console.Write("isPairedN of  {8, -8, 8, 8, 7, 7, -7} and -15 is"); Console.WriteLine(" = {0}"
              , TestSet25.isPairedN(new int[] { 8, -8, 8, 8, 7, 7, -7 }, -15));

            Console.Write("isPairedN of  {3} and 3 is"); Console.WriteLine(" = {0}"
             , TestSet25.isPairedN(new int[] { 3 }, 3));

            Console.Write("isPairedN of  {} and 0 is"); Console.WriteLine(" = {0}"
             , TestSet25.isPairedN(new int[] { }, 0));

            Console.WriteLine("========================");
            
        }
    }
}
