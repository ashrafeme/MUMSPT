using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet29
{
  public static  class TestSet29Test
    {
        public static void eval()
        {
            Console.WriteLine("test for eval ");
            Console.WriteLine("========================");

            Console.Write("eval of   {0, 1, 2, 3, 4}  and 1  is"); Console.WriteLine(" = {0}"
              , TestSet29.eval(new int[] { 0, 1, 2, 3, 4 }, 1));

            Console.Write("eval of   {3, 2, 1}  and 3  is"); Console.WriteLine(" = {0}"
              , TestSet29.eval(new int[] { 3, 2, 1 }, 3));

            Console.Write("eval of   {3, -2, -1}  and 2  is"); Console.WriteLine(" = {0}"
             , TestSet29.eval(new int[] { 3, -2, -1 }, 2));

            Console.Write("eval of   {3, 2, 1}  and -3  is"); Console.WriteLine(" = {0}"
             , TestSet29.eval(new int[] { 3, 2, 1 }, -3));

            Console.Write("eval of   {3, 2}  and 2  is"); Console.WriteLine(" = {0}"
             , TestSet29.eval(new int[] { 3, 2 }, 2));

            Console.Write("eval of   {4, 0, 9}  and 2  is"); Console.WriteLine(" = {0}"
             , TestSet29.eval(new int[] { 4, 0, 9 }, 2));

            Console.Write("eval of   {10}  and 2  is"); Console.WriteLine(" = {0}"
             , TestSet29.eval(new int[] { 10 }, 2));

            Console.Write("eval of   {0, 1}  and 10  is"); Console.WriteLine(" = {0}"
             , TestSet29.eval(new int[] { 0, 1 }, 10));

            Console.WriteLine("========================");

        }


        public static void isAllPossibilities()
        {
            Console.WriteLine("test for isAllPossibilities ");
            Console.WriteLine("========================");

            Console.Write("isAllPossibilities of   {1, 2, 0, 3}   is"); Console.WriteLine(" = {0}"
              , TestSet29.isAllPossibilities(new int[] { 1, 2, 0, 3 }));

            Console.Write("isAllPossibilities of   {3, 2, 1, 0}   is"); Console.WriteLine(" = {0}"
                          , TestSet29.isAllPossibilities(new int[] { 3, 2, 1, 0 }));

            Console.Write("isAllPossibilities of   {1, 2, 4, 3}   is"); Console.WriteLine(" = {0}"
                          , TestSet29.isAllPossibilities(new int[] { 1, 2, 4, 3 }));

            Console.Write("isAllPossibilities of   {0, 2, 3}   is"); Console.WriteLine(" = {0}"
                         , TestSet29.isAllPossibilities(new int[] { 0, 2, 3 }));


            Console.Write("isAllPossibilities of   {0}   is"); Console.WriteLine(" = {0}"
                         , TestSet29.isAllPossibilities(new int[] { 0 }));

            Console.Write("isAllPossibilities of   {}   is"); Console.WriteLine(" = {0}"
                        , TestSet29.isAllPossibilities(new int[] {  }));

            Console.WriteLine("========================");

        }

        public static void isLayered()
        {
            Console.WriteLine("test for isLayered ");
            Console.WriteLine("========================");

            Console.Write("isLayered of    {1, 1, 2, 2, 2, 3, 3}    is"); Console.WriteLine(" = {0}"
              , TestSet29.isLayered(new int[] { 1, 1, 2, 2, 2, 3, 3 } ));

            Console.Write("isLayered of    {3, 3, 3, 3, 3, 3, 3}    is"); Console.WriteLine(" = {0}"
              , TestSet29.isLayered(new int[] { 3, 3, 3, 3, 3, 3, 3 }));

            Console.Write("isLayered of    {3, 3, 1, 1, 1, 2, 2}     is"); Console.WriteLine(" = {0}"
             , TestSet29.isLayered(new int[] { 3, 3, 1, 1, 1, 2, 2 }));

            Console.Write("isLayered of    {1, 2, 2, 2, 3, 3}     is"); Console.WriteLine(" = {0}"
             , TestSet29.isLayered(new int[] { 1, 2, 2, 2, 3, 3 }));

            Console.Write("isLayered of    {2, 2, 2, 3, 3, 1, 1}     is"); Console.WriteLine(" = {0}"
            , TestSet29.isLayered(new int[] { 2, 2, 2, 3, 3, 1, 1 }));

            Console.Write("isLayered of    {2}     is"); Console.WriteLine(" = {0}"
           , TestSet29.isLayered(new int[] { 2 }));

            Console.Write("isLayered of    {}     is"); Console.WriteLine(" = {0}"
          , TestSet29.isLayered(new int[] {  }));

            Console.WriteLine("========================");

        }

        public static void updateMileagecounter()
        {
            Console.WriteLine("test for updateMileagecounter ");
            Console.WriteLine("========================");

            string ss = "";

            ss = "{";
            var output = TestSet29.updateMileagecounter(new int[] { 8, 9, 9, 5, 0 }, 1);
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
            Console.Write("updateMileagecounter of    {8, 9, 9, 5, 0} and 1   is"); Console.WriteLine(" = {0}"
             , ss);


            /********************************************************/
            //
            ss = "{";
            output = TestSet29.updateMileagecounter(new int[] { 8, 9, 9, 5, 0 },2);
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
            Console.Write("updateMileagecounter of  {8, 9, 9, 5, 0} and 2  is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/
            ss = "{";
            output = TestSet29.updateMileagecounter(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 1);
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
            Console.Write("updateMileagecounter of  {9, 9, 9, 9, 9, 9, 9, 9, 9, 9} and 1  is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/

            ss = "{";
            output = TestSet29.updateMileagecounter(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 13);
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
            Console.Write("updateMileagecounter of  {9, 9, 9, 9, 9, 9, 9, 9, 9, 9} and 13  is"); Console.WriteLine(" = {0}"
             , ss);

            /********************************************************/

            Console.WriteLine("========================");

        }

        public static void isHollow()
        {
            Console.WriteLine("test for isHollow ");
            Console.WriteLine("========================");
            /*
            Console.Write("isHollow of    {1,2,0,0,0,3,4}    is"); Console.WriteLine(" = {0}"
              , TestSet29.isHollow(new int[] { 1, 2, 0, 0, 0, 3, 4 }));

            Console.Write("isHollow of    {1,1,1,1,0,0,0,0,0,2,1,2,18}     is"); Console.WriteLine(" = {0}"
                          , TestSet29.isHollow(new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 1, 2, 18 }));


            Console.Write("isHollow of    {1, 2, 0, 0, 3, 4}    is"); Console.WriteLine(" = {0}"
              , TestSet29.isHollow(new int[] { 1, 2, 0, 0, 3, 4 }));

            Console.Write("isHollow of   {1,2,0,0,0,3,4,5}   is"); Console.WriteLine(" = {0}"
             , TestSet29.isHollow(new int[] { 1, 2, 0, 0, 0, 3, 4, 5 }));

            Console.Write("isHollow of    {3,8,3,0,0,0,3,3}    is"); Console.WriteLine(" = {0}"
             , TestSet29.isHollow(new int[] { 3, 8, 3, 0, 0, 0, 3, 3 }));

            Console.Write("isHollow of    {1,2,0,0,0,3,4,0}    is"); Console.WriteLine(" = {0}"
             , TestSet29.isHollow(new int[] { 1, 2, 0, 0, 0, 3, 4, 0 }));
            */
            Console.Write("isHollow of    {0,1,2,0,0,0,3,4}    is"); Console.WriteLine(" = {0}"
            , TestSet29.isHollow(new int[] { 0, 1, 2, 0, 0, 0, 3, 4 }));

            Console.Write("isHollow of    {0,0,0}    is"); Console.WriteLine(" = {0}"
            , TestSet29.isHollow(new int[] {  0, 0, 0 }));

            Console.WriteLine("========================");

        }
    }
}
