using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet19
{
  public static  class TestSet19Test
    {
        public static void isZeroPlentiful()
        {
            Console.WriteLine("test for isZeroPlentiful ");
            Console.WriteLine("========================");

            Console.Write("isZeroPlentiful of   {0, 0, 0, 0, 0}   is"); Console.WriteLine(" = {0}"
             , TestSet19.isZeroPlentiful(new int[] { 0, 0, 0, 0, 0 }));

            Console.Write("isZeroPlentiful of   {1, 2, 0, 0, 0, 0, 2, -18, 0, 0, 0, 0, 0, 12}  is"); Console.WriteLine(" = {0}"
            , TestSet19.isZeroPlentiful(new int[] { 1, 2, 0, 0, 0, 0, 2, -18, 0, 0, 0, 0, 0, 12 }));

            Console.Write("isZeroPlentiful of   {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0}   is"); Console.WriteLine(" = {0}"
            , TestSet19.isZeroPlentiful(new int[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0 }));

            Console.Write("isZeroPlentiful of   {1, 2, 3, 4}   is"); Console.WriteLine(" = {0}"
            , TestSet19.isZeroPlentiful(new int[] { 1, 2, 3, 4 }));

            Console.Write("isZeroPlentiful of   {1, 0, 0, 0, 2, 0, 0, 0, 0}   is"); Console.WriteLine(" = {0}"
            , TestSet19.isZeroPlentiful(new int[] { 1, 0, 0, 0, 2, 0, 0, 0, 0 }));

            Console.Write("isZeroPlentiful of   {0}   is"); Console.WriteLine(" = {0}"
            , TestSet19.isZeroPlentiful(new int[] { 0 }));
            Console.Write("isZeroPlentiful of   {}   is"); Console.WriteLine(" = {0}"
            , TestSet19.isZeroPlentiful(new int[] {  }));



            Console.WriteLine("========================");
        }

        public static void isDigitIncreasing()
        {
            Console.WriteLine("test for isDigitIncreasing ");
            Console.WriteLine("========================");

            Console.Write("isDigitIncreasing of   24   is"); Console.WriteLine(" = {0}"
             , TestSet19.isDigitIncreasing(24));

            Console.Write("isDigitIncreasing of   7   is"); Console.WriteLine(" = {0}"
             , TestSet19.isDigitIncreasing(7));


            Console.Write("isDigitIncreasing of   36   is"); Console.WriteLine(" = {0}"
             , TestSet19.isDigitIncreasing(36));


            Console.Write("isDigitIncreasing of   984   is"); Console.WriteLine(" = {0}"
             , TestSet19.isDigitIncreasing(984));



            Console.Write("isDigitIncreasing of   7404   is"); Console.WriteLine(" = {0}"
             , TestSet19.isDigitIncreasing(7404));


            Console.WriteLine("========================");
        }


        public static void decodeArray()
        {
            Console.WriteLine("test for decodeArray ");
            Console.WriteLine("========================");

            Console.Write("decodeArray of   {0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1}   is"); Console.WriteLine(" = {0}"
             , TestSet19.decodeArray(new int[] { 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 }));

            Console.Write("decodeArray of   {1}   is"); Console.WriteLine(" = {0}"
             , TestSet19.decodeArray(new int[] { 1 }));

            Console.Write("decodeArray of   {0, 1}   is"); Console.WriteLine(" = {0}"
            , TestSet19.decodeArray(new int[] { 0, 1 }));


            Console.Write("decodeArray of   {-1, 0, 1}   is"); Console.WriteLine(" = {0}"
           , TestSet19.decodeArray(new int[] { -1, 0, 1 }));


            Console.Write("decodeArray of   {0, 1, 1, 1, 1, 1, 0, 1}  is"); Console.WriteLine(" = {0}"
           , TestSet19.decodeArray(new int[] { 0, 1, 1, 1, 1, 1, 0, 1 }));


            Console.Write("decodeArray of   {0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1}   is"); Console.WriteLine(" = {0}"
           , TestSet19.decodeArray(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }));

            Console.WriteLine("========================");
        }

        
    }
}
