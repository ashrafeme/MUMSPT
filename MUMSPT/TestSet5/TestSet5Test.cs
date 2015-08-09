using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet5
{
   public static class TestSet5Test
    {
        public static void henry()
        {
            Console.WriteLine("test for henry ");
            Console.WriteLine("========================");


            Console.Write("henry of 1,3 is"); Console.WriteLine(" = {0}"
               , TestSet5.henry(1, 3));
            

            Console.WriteLine("========================");
        }

        public static void isDivisible()
        {
            Console.WriteLine("test for isDivisible ");
            Console.WriteLine("========================");

            Console.Write("array {3, 3, 6, 36} and 3 is"); Console.WriteLine(" = {0}"
                , TestSet5.isDivisible(new int[] { 3, 3, 6, 36 }, 3));

            Console.Write("array {4} and 2 is"); Console.WriteLine(" = {0}"
                , TestSet5.isDivisible(new int[] { 4 }, 2));

            Console.Write("array {3, 4, 3, 6, 36} and 3 is"); Console.WriteLine(" = {0}"
                , TestSet5.isDivisible(new int[] { 3, 4, 3, 6, 36 }, 3));

            Console.Write("array {6, 12, 24, 36} and 12 is"); Console.WriteLine(" = {0}"
                , TestSet5.isDivisible(new int[] { 6, 12, 24, 36 }, 12));

            Console.Write("array { } and 12 is"); Console.WriteLine(" = {0}"
                , TestSet5.isDivisible(new int[] {  }, 12));

            Console.WriteLine("========================");
        }

        public static void isNUnique()
        {
            Console.WriteLine("test for isNUnique ");
            Console.WriteLine("========================");

            Console.Write("array {7, 3, 3, 2, 4} and 6 is"); Console.WriteLine(" = {0}"
                , TestSet5.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 6));

            Console.Write("array {7, 3, 3, 2, 4} and 10 is"); Console.WriteLine(" = {0}"
                , TestSet5.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 10));

            Console.Write("array {7, 3, 3, 2, 4} and 11 is"); Console.WriteLine(" = {0}"
                , TestSet5.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 11));

            Console.Write("array {7, 3, 3, 2, 4} and 8 is"); Console.WriteLine(" = {0}"
                , TestSet5.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 8));

            Console.Write("array {7, 3, 3, 2, 4} and 4 is"); Console.WriteLine(" = {0}"
                , TestSet5.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 4));

            Console.Write("array { 1 } and 12 is"); Console.WriteLine(" = {0}"
                , TestSet5.isNUnique(new int[] { 1 }, 12));

            Console.WriteLine("========================");
        }
    }
}
