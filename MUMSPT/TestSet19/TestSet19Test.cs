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
    }
}
