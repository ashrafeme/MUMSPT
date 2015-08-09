using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet4
{
  public static class TestSet4Test
    {

        public static void solve10()
        {
            Console.WriteLine("test for solve10 ");
            Console.WriteLine("========================");

            

            Console.Write("solve10 of x is"); Console.WriteLine(" = {0}"
               , TestSet4.solve10()[0]);

            Console.Write("solve10 of y is"); Console.WriteLine(" = {0}"
               , TestSet4.solve10()[1]);

            

            Console.WriteLine("========================");
        }

        public static void solve101()
        {
            Console.WriteLine("test for solve101 ");
            Console.WriteLine("========================");

           
            Console.Write("solve10 of x is"); Console.WriteLine(" = {0}"
               , TestSet4.solve101()[0]);

            Console.Write("solve10 of y is"); Console.WriteLine(" = {0}"
               , TestSet4.solve101()[1]);

            


            Console.WriteLine("========================");
        }

        public  static void repsEqual()
        {
            Console.WriteLine("test for repsEqual ");
            Console.WriteLine("========================");

            Console.Write("array { 3, 2, 0, 5, 3 } and 32053 is"); Console.WriteLine(" = {0}"
                , TestSet4.repsEqual(new int[] { 3, 2, 0, 5, 3 }, 32053));

            Console.Write("array {3, 2, 0, 5} and 32053 is"); Console.WriteLine(" = {0}"
               , TestSet4.repsEqual(new int[] { 3, 2, 0, 5 }, 32053));

            Console.Write("array {3, 2, 0, 5, 3, 4} and 32053 is"); Console.WriteLine(" = {0}"
               , TestSet4.repsEqual(new int[] { 3, 2, 0, 5, 3, 4 }, 32053));

            Console.Write("array {2, 3, 0, 5, 3} and 32053 is"); Console.WriteLine(" = {0}"
               , TestSet4.repsEqual(new int[] { 2, 3, 0, 5, 3 }, 32053));

            Console.Write("array {9, 3, 1, 1, 2} and 32053 is"); Console.WriteLine(" = {0}"
               , TestSet4.repsEqual(new int[] { 9, 3, 1, 1, 2 }, 32053));


            Console.Write("array {0, 3, 2, 0, 5, 3} and 32053 is"); Console.WriteLine(" = {0}"
               , TestSet4.repsEqual(new int[] { 0, 3, 2, 0, 5, 3 }, 32053));

            Console.WriteLine("========================");


        }

        public static void isCentered15()
        {
            Console.WriteLine("test for isCentered15 ");
            Console.WriteLine("========================");

            Console.Write("array {3, 2, 10, 4, 1, 6, 9} is"); Console.WriteLine(" = {0}"
                , TestSet4.isCentered15(new int[] { 3, 2, 10, 4, 1, 6, 9 }));

            Console.Write("array {2, 10, 4, 1, 6, 9} is"); Console.WriteLine(" = {0}"
                , TestSet4.isCentered15(new int[] { 2, 10, 4, 1, 6, 9 }));

            Console.Write("array {3, 2, 10, 4, 1, 6} is"); Console.WriteLine(" = {0}"
                , TestSet4.isCentered15(new int[] { 3, 2, 10, 4, 1, 6 }));

            Console.Write("array {1,1,8, 3, 1, 1} is"); Console.WriteLine(" = {0}"
                , TestSet4.isCentered15(new int[] { 1, 1, 8, 3, 1, 1 }));

            Console.Write("array {9, 15, 6} is"); Console.WriteLine(" = {0}"
                , TestSet4.isCentered15(new int[] { 9, 15, 6 }));

            Console.Write("array {1, 1, 2, 2, 1, 1} is"); Console.WriteLine(" = {0}"
               , TestSet4.isCentered15(new int[] { 1, 1, 2, 2, 1, 1 }));

            Console.Write("array {1, 1, 15 -1,-1} is"); Console.WriteLine(" = {0}"
               , TestSet4.isCentered15(new int[] { 1, 1, 15 - 1, -1 }));

            Console.WriteLine("========================");


        }
    }
}
