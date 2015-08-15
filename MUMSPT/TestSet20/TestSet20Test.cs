using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet20
{
    public static class TestSet20Test
    {
        public static void isOnionArray()
        {
            Console.WriteLine("test for isOnionArray ");
            Console.WriteLine("========================");

            Console.Write("isOnionArray of  {1, 2, 19, 4, 5}   is"); Console.WriteLine(" = {0}"
             , TestSet20.isOnionArray(new int[] { 1, 2, 19, 4, 5 }));


            Console.Write("isOnionArray of  1, 2, 3, 4, 15}   is"); Console.WriteLine(" = {0}"
             , TestSet20.isOnionArray(new int[] { 1, 2, 3, 4, 15 }));


            Console.Write("isOnionArray of  {1, 3, 9, 8}  is"); Console.WriteLine(" = {0}"
             , TestSet20.isOnionArray(new int[] { 1, 3, 9, 8 }));


            Console.Write("isOnionArray of  {2}   is"); Console.WriteLine(" = {0}"
             , TestSet20.isOnionArray(new int[] { 2 }));


            Console.Write("isOnionArray of  {}   is"); Console.WriteLine(" = {0}"
             , TestSet20.isOnionArray(new int[] { }));


            Console.Write("isOnionArray of  {-2, 5, 0, 5, 12}  is"); Console.WriteLine(" = {0}"
             , TestSet20.isOnionArray(new int[] { -2, 5, 0, 5, 12 }));

            Console.WriteLine("========================");
        }

        public static void isPrimeHappy()
        {
            TestSet11.TestSet11Test.isPrimeHappy();
        }


        public static void encodeArray()
        {
            Console.WriteLine("test for encodeArray ");
            Console.WriteLine("========================");

            string ss = "";

            ss = "{";
            var output = TestSet20.encodeArray(1234);
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
            Console.Write("encodeArray of   1234   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/

           //
            ss = "{";
            output = TestSet20.encodeArray(-999);
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
            Console.Write("encodeArray of   -999   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/
            ss = "{";
            output = TestSet20.encodeArray(999);
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
            Console.Write("encodeArray of   999   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/


            ss = "{";
            output = TestSet20.encodeArray(0);
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
            Console.Write("encodeArray of   0   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/


            ss = "{";
            output = TestSet20.encodeArray(1);
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
            Console.Write("encodeArray of   1   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/

            ss = "{";
            output = TestSet20.encodeArray(-1);
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
            Console.Write("encodeArray of   -1   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/

            ss = "{";
            output = TestSet20.encodeArray(100001);
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
            Console.Write("encodeArray of   100001   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/
        }
    }
}
