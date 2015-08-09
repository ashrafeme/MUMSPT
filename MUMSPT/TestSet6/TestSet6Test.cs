using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet6
{
    public static class TestSet6Test
    {
        public static void isSquare()
        {
            Console.WriteLine("test for isSquare ");
            Console.WriteLine("========================");


            Console.Write("isSquare of 4 is"); Console.WriteLine(" = {0}"
               , TestSet6.isSquare(4));

            Console.Write("isSquare of 25 is"); Console.WriteLine(" = {0}"
               , TestSet6.isSquare(25));


            Console.Write("isSquare of -4 is"); Console.WriteLine(" = {0}"
               , TestSet6.isSquare(-4));


            Console.Write("isSquare of 8 is"); Console.WriteLine(" = {0}"
               , TestSet6.isSquare(8));


            Console.Write("isSquare of 0 is"); Console.WriteLine(" = {0}"
               , TestSet6.isSquare(0));


            Console.WriteLine("========================");
        }

        public static void isLegalNumber()
        {
            Console.WriteLine("test for isLegalNumber ");
            Console.WriteLine("========================");

            Console.Write("array { 3, 2, 1 } and 4 is"); Console.WriteLine(" = {0}"
                , TestSet6.isLegalNumber(new int[] { 3, 2, 1 }, 4));

            Console.Write("array {3, 7, 1} and 6 is"); Console.WriteLine(" = {0}"
                , TestSet6.isLegalNumber(new int[] { 3, 7, 1 }, 6));

           

            Console.WriteLine("========================");
        }

        public static void convertToBase10()
        {
            Console.WriteLine("test for convertToBase10 ");
            Console.WriteLine("========================");

            Console.Write("array {1, 0, 1, 1} , 2 is"); Console.WriteLine(" = {0}"
                , TestSet6.convertToBase10(new int[] { 1, 0, 1, 1 }, 2));

            Console.Write("array {1, 1, 2}, 3  is"); Console.WriteLine(" = {0}"
                , TestSet6.convertToBase10(new int[] { 1, 1, 2 }, 3));

            Console.Write("array {3, 2, 5}, 8  is"); Console.WriteLine(" = {0}"
                , TestSet6.convertToBase10(new int[] { 3, 2, 5 }, 8));

            Console.Write("array  {3, 7, 1},  6  is"); Console.WriteLine(" = {0}"
                , TestSet6.convertToBase10(new int[] { 3, 7, 1 }, 6));

            Console.Write("array   {3, 2, 1},  4  is"); Console.WriteLine(" = {0}"
                , TestSet6.convertToBase10(new int[] { 3, 2, 1 }, 4));

            Console.WriteLine("========================");
        }
    }
}
