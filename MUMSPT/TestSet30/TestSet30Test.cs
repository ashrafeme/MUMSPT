using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet30
{
   public static class TestSet30Test
    {
        public static void isMeera()
        {
            Console.WriteLine("test for isMeera ");
            Console.WriteLine("========================");

            Console.Write("isMeera of     {7, 6, 0, 10, 1}    is"); Console.WriteLine(" = {0}"
              , TestSet30.isMeera(new int[] { 7, 6, 0, 10, 1 }));

            Console.Write("isMeera of     {6, 10, 1}    is"); Console.WriteLine(" = {0}"
               , TestSet30.isMeera(new int[] { 6, 10, 1 }));


            Console.Write("isMeera of      {7, 6, 10}   is"); Console.WriteLine(" = {0}"
                           , TestSet30.isMeera(new int[] { 7, 6, 10 }));

            Console.Write("isMeera of       {6, 10, 0}   is"); Console.WriteLine(" = {0}"
                           , TestSet30.isMeera(new int[] { 6, 10, 0 }));

            Console.Write("isMeera of       {3, 7, 0, 8, 0, 5}    is"); Console.WriteLine(" = {0}"
                           , TestSet30.isMeera(new int[] { 3, 7, 0, 8, 0, 5 }));

            Console.WriteLine("========================");

        }

        public static void isBean()
        {
            Console.WriteLine("test for isBean ");
            Console.WriteLine("========================");

            Console.Write("isBean of     {2, 10, 9, 3}    is"); Console.WriteLine(" = {0}"
              , TestSet30.isBean(new int[] { 2, 10, 9, 3 }));

            Console.Write("isBean of      {2, 2, 3, 3, 3}    is"); Console.WriteLine(" = {0}"
              , TestSet30.isBean(new int[] { 2, 2, 3, 3, 3 }));

            Console.Write("isBean of     {1, 1, 1, 2, 1, 1}    is"); Console.WriteLine(" = {0}"
              , TestSet30.isBean(new int[] { 1, 1, 1, 2, 1, 1 }));

            Console.Write("isBean of { 0,-1,1} is"); Console.WriteLine(" = {0}"
              , TestSet30.isBean(new int[] { 0, -1, 1 }));

            Console.Write("isBean of     {3, 4, 5, 7}     is"); Console.WriteLine(" = {0}"
              , TestSet30.isBean(new int[] { 3, 4, 5, 7 }));

            Console.WriteLine("========================");
        }

        public static void fill()
        {
            Console.WriteLine("test for fill ");
            Console.WriteLine("========================");

            string ss = "";

            ss = "{";
            var output = TestSet30.fill(new int[] { 1, 2, 3, 5, 9, 12, -2, -1 }, 3, 10);
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
            Console.Write("fill of    {1,2,3,5, 9, 12,-2,-1}, 3, 10   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/
            //
            ss = "{";
            output = TestSet30.fill(new int[] { 4, 2, -3, 12 }, 1, 5);
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
            Console.Write("fill of  {4, 2, -3, 12}, 1, 5  is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/
            //
            ss = "{";
            output = TestSet30.fill(new int[] { 2, 6, 9, 0, -3 }, 0, 4);
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
            Console.Write("fill of  {2, 6, 9, 0, -3}, 0, 4  is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/


            Console.WriteLine("========================");

        }

        public static void sumIsPower()
        {
            Console.WriteLine("test for sumIsPower ");
            Console.WriteLine("========================");

            Console.Write("sumIsPower of    ({8,8,8,8}    is"); Console.WriteLine(" = {0}"
              , TestSet30.sumIsPower(new int[] { 8, 8, 8, 8 }));

            Console.Write("sumIsPower of    ({8,8,8}    is"); Console.WriteLine(" = {0}"
               , TestSet30.sumIsPower(new int[] { 8, 8, 8 }));

            Console.WriteLine("========================");
        }

        public static void isHollow()
        {
            Console.WriteLine("test for isHollow ");
            Console.WriteLine("========================");

            Console.Write("isHollow of    {1,2,4,0,0,0,3,4,5}    is"); Console.WriteLine(" = {0}"
              , TestSet30.isHollow(new int[] { 1, 2, 4, 0, 0, 0, 3, 4, 5 }));

            Console.Write("isHollow of   {1,2,0,0,0,3,4,5} is"); Console.WriteLine(" = {0}"
               , TestSet30.isHollow(new int[] { 1, 2, 0, 0, 0, 3, 4, 5 }));

            Console.Write("isHollow of   {1,2,4,9, 0,0,0,3,4, 5} is"); Console.WriteLine(" = {0}"
               , TestSet30.isHollow(new int[] { 1, 2, 4, 9, 0, 0, 0, 3, 4, 5 }));

            Console.Write("isHollow of   {1,2, 0,0, 3,4} is"); Console.WriteLine(" = {0}"
               , TestSet30.isHollow(new int[] { 1, 2, 0, 0, 3, 4 }));

            Console.WriteLine("========================");
        }

        public static void isBean913()
        {
            Console.WriteLine("test for isBean913 ");
            Console.WriteLine("========================");

            Console.Write("isBean913 of    {1, 2, 3, 9, 6, 13}     is"); Console.WriteLine(" = {0}"
              , TestSet30.isBean913(new int[] { 1, 2, 3, 9, 6, 13 }));

            Console.Write("isBean913 of   {3, 4, 6, 7, 13, 15}, is"); Console.WriteLine(" = {0}"
               , TestSet30.isBean913(new int[] { 3, 4, 6, 7, 13, 15 }));

            Console.Write("isBean913 of    {1, 2, 3, 4, 10, 11, 12}  is"); Console.WriteLine(" = {0}"
               , TestSet30.isBean913(new int[] { 1, 2, 3, 4, 10, 11, 12 }));

            Console.Write("isBean913 of    {3, 6, 9, 5, 7, 13, 6, 17} is"); Console.WriteLine(" = {0}"
               , TestSet30.isBean913(new int[] { 3, 6, 9, 5, 7, 13, 6, 17 }));

            Console.Write("isBean913 of     { 9, 6, 18} is"); Console.WriteLine(" = {0}"
               , TestSet30.isBean913(new int[] { 9, 6, 18 }));

            Console.Write("isBean913 of   {4, 7, 16}  is"); Console.WriteLine(" = {0}"
               , TestSet30.isBean913(new int[] { 4, 7, 16 }));

            Console.WriteLine("========================");
        }
    }
}
