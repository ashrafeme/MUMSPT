using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet24
{
   public static class TestSet24Test
    {
        public static void isTriangular()
        {
            Console.WriteLine("test for isTriangular ");
            Console.WriteLine("========================");
            for (int i = 1; i < 11; i++)
            {


                Console.Write("isTriangular of  " + i + "   is"); Console.WriteLine(" = {0}"
                     , TestSet24.isTriangular(i));

            }
           

            Console.WriteLine("========================");

        }

        public static void isMercurial()
        {
            Console.WriteLine("test for isMercurial ");
            Console.WriteLine("========================");



            Console.Write("isMercurial of  {1, 2, 10, 3, 15, 1, 2, 2}   is"); Console.WriteLine(" = {0}"
          , TestSet24.isMercurial(new int[] { 1, 2, 10, 3, 15, 1, 2, 2 }));


            Console.Write("isMercurial of  {5, 2, 10, 3, 15, 1, 2, 2}  is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] { 5, 2, 10, 3, 15, 1, 2, 2 }));

            Console.Write("isMercurial of  {1, 2, 10, 3, 15, 16, 2, 2}  is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] { 1, 2, 10, 3, 15, 16, 2, 2 }));


            Console.Write("isMercurial of  {3, 2, 18, 1, 0, 3, -11, 1, 3}  is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] { 3, 2, 18, 1, 0, 3, -11, 1, 3 }));


            Console.Write("isMercurial of  {2, 3, 1, 1, 18} is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] { 2, 3, 1, 1, 18 }));


            Console.Write("isMercurial of  {8, 2, 1, 1, 18, 3, 5}  is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] { 8, 2, 1, 1, 18, 3, 5 }));

            Console.Write("isMercurial of  {3, 3, 3, 3, 3, 3}  is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] { 3, 3, 3, 3, 3, 3 }));

            Console.Write("isMercurial of  {1}  is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] { 1 }));

            Console.Write("isMercurial of  {}  is"); Console.WriteLine(" = {0}"
         , TestSet24.isMercurial(new int[] {  }));

            Console.WriteLine("========================");

        }

        public static void is235Array()
        {
            Console.WriteLine("test for is235Array ");
            Console.WriteLine("========================");



            Console.Write("is235Array of  {2, 3, 5, 7, 11}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 2, 3, 5, 7, 11 }));

            Console.Write("is235Array of  {2, 3, 6, 7, 11}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 2, 3, 6, 7, 11 }));

            Console.Write("is235Array of  {2, 3, 4, 5, 6, 7, 8, 9, 10}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            Console.Write("is235Array of  {2, 4, 8, 16, 32}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 2, 4, 8, 16, 32 }));

            Console.Write("is235Array of {3, 9, 27, 7, 1, 1, 1, 1, 1}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 3, 9, 27, 7, 1, 1, 1, 1, 1 }));

            Console.Write("is235Array of  {7, 11, 77, 49}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 7, 11, 77, 49 }));

            Console.Write("is235Array of  {2}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 2}));

            Console.Write("is235Array of  {}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] {  }));

            Console.Write("is235Array of  {7, 2, 7, 2, 7, 2, 7, 2, 3, 7, 7}   is"); Console.WriteLine(" = {0}"
          , TestSet24.is235Array(new int[] { 7, 2, 7, 2, 7, 2, 7, 2, 3, 7, 7 }));



            Console.WriteLine("========================");

        }
    }
}
