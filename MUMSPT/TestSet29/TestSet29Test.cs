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
    }
}
