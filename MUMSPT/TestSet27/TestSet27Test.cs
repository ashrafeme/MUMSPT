using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet27
{
    public static class TestSet27Test
    {
        public static void isSquare()
        {
            Console.WriteLine("test for isSquare ");
            Console.WriteLine("========================");

            Console.Write("isSquare of   4 is"); Console.WriteLine(" = {0}"
              , TestSet27.isSquare(4));

            Console.Write("isSquare of   25 is"); Console.WriteLine(" = {0}"
            , TestSet27.isSquare(25));


            Console.Write("isSquare of   -4 is"); Console.WriteLine(" = {0}"
            , TestSet27.isSquare(-4));

            Console.Write("isSquare of   8 is"); Console.WriteLine(" = {0}"
          , TestSet27.isSquare(8));

            Console.Write("isSquare of   0 is"); Console.WriteLine(" = {0}"
          , TestSet27.isSquare(0));

            Console.WriteLine("========================");
            
        }

        public static void isComplete()
        {
            Console.WriteLine("test for isComplete ");
            Console.WriteLine("========================");

            Console.Write("isComplete of   {3, 2, 9, 5}  is"); Console.WriteLine(" = {0}"
              , TestSet27.isComplete(new int[] { 3, 2, 9, 5 }));

            Console.Write("isComplete of   {36, -28} is"); Console.WriteLine(" = {0}"
              , TestSet27.isComplete(new int[] { 36, -28 }));

            Console.Write("isComplete of   {36, 28}  is"); Console.WriteLine(" = {0}"
              , TestSet27.isComplete(new int[] { 36, 28 }));

            Console.Write("isComplete of   {4}  is"); Console.WriteLine(" = {0}"
             , TestSet27.isComplete(new int[] { 4 }));

            Console.Write("isComplete of   {3, 2, 1, 1, 5, 6}  is"); Console.WriteLine(" = {0}"
             , TestSet27.isComplete(new int[] { 3, 2, 1, 1, 5, 6 }));

            Console.Write("isComplete of   {3, 7, 23, 13, 107, -99, 97, 81}  is"); Console.WriteLine(" = {0}"
             , TestSet27.isComplete(new int[] { 3, 7, 23, 13, 107, -99, 97, 81 }));

            Console.WriteLine("========================");
            
        }

        public static void loopSum()
        {
            Console.WriteLine("test for loopSum ");
            Console.WriteLine("========================");

            Console.Write("loopSum of   {1, 2, 3},2  is"); Console.WriteLine(" = {0}"
              , TestSet27.loopSum(new int[] { 1, 2, 3 },2));

            Console.Write("loopSum of   {-1, 2, -1},7  is"); Console.WriteLine(" = {0}"
               , TestSet27.loopSum(new int[] { -1, 2, -1 }, 7));

            Console.Write("loopSum of   {1, 4, 5, 6},4  is"); Console.WriteLine(" = {0}"
               , TestSet27.loopSum(new int[] { 1, 4, 5, 6 }, 4));

            Console.Write("loopSum of   {3},10  is"); Console.WriteLine(" = {0}"
               , TestSet27.loopSum(new int[] { 3 }, 10));

            Console.WriteLine("========================");
            
        }
    }
}
