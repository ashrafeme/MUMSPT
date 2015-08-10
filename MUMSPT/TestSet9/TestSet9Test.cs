using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet9
{
    public static class TestSet9Test
    {
        public static void equivalentArrays()
        {
            Console.WriteLine("test for equivalentArrays ");
            Console.WriteLine("========================");

            Console.Write("equivalentArrays of   { 0, 1, 2 }, { 2, 0, 1 } is"); Console.WriteLine(" = {0}"
               , TestSet9.equivalentArrays(new int[] { 0, 1, 2 }, new int[] { 2, 0, 1 }));

            Console.Write("equivalentArrays of   {0, 1, 2, 1}, { 2, 0, 1 } is"); Console.WriteLine(" = {0}"
               , TestSet9.equivalentArrays(new int[] { 0, 1, 2, 1 }, new int[] { 2, 0, 1 }));

            Console.Write("equivalentArrays of   {2, 0, 1}, {0, 1, 2, 1} is"); Console.WriteLine(" = {0}"
               , TestSet9.equivalentArrays(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2, 1 }));

            Console.Write("equivalentArrays of   {0, 5, 5, 5, 1, 2, 1}, {5, 2, 0, 1} is"); Console.WriteLine(" = {0}"
               , TestSet9.equivalentArrays(new int[] { 0, 5, 5, 5, 1, 2, 1 }, new int[] { 5, 2, 0, 1 }));

            Console.Write("equivalentArrays of   {5, 2, 0, 1}, {0, 5, 5, 5, 1, 2, 1} is"); Console.WriteLine(" = {0}"
               , TestSet9.equivalentArrays(new int[] { 5, 2, 0, 1 }, new int[] { 0, 5, 5, 5, 1, 2, 1 }));

            Console.Write("equivalentArrays of   {0, 2, 1, 2}, {3, 1, 2, 0} is"); Console.WriteLine(" = {0}"
               , TestSet9.equivalentArrays(new int[] { 0, 2, 1, 2 }, new int[] { 3, 1, 2, 0 }));

            Console.Write("equivalentArrays of   {3, 1, 2, 0}, {0, 2, 1, 0} is"); Console.WriteLine(" = {0}"
               , TestSet9.equivalentArrays(new int[] { 3, 1, 2, 0 }, new int[] { 0, 2, 1, 0 }));

            Console.Write("equivalentArrays of   {1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 2} is"); Console.WriteLine(" = {0}"
              , TestSet9.equivalentArrays(new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 2 }));

            Console.Write("equivalentArrays of   {}, {3, 1, 1, 1, 1, 2}	 is"); Console.WriteLine(" = {0}"
              , TestSet9.equivalentArrays(new int[] { }, new int[] { 3, 1, 1, 1, 1, 2 }));

            Console.Write("equivalentArrays of   {}, {} is"); Console.WriteLine(" = {0}"
              , TestSet9.equivalentArrays(new int[] { }, new int[] { }));

            Console.WriteLine("========================");
        }

        public static void isStepped()
        {
            Console.WriteLine("test for isStepped ");
            Console.WriteLine("========================");

            Console.Write("isStepped of   {1, 1, 1, 5, 5, 5, 5, 8, 8, 8} is"); Console.WriteLine(" = {0}"
              , TestSet9.isStepped(new int[] { 1, 1, 1, 5, 5, 5, 5, 8, 8, 8 }));

            Console.Write("isStepped of   {1, 1, 5, 5, 5, 5, 8, 8, 8} is"); Console.WriteLine(" = {0}"
             , TestSet9.isStepped(new int[] { 1, 1, 5, 5, 5, 5, 8, 8, 8 }));

            Console.Write("isStepped of   {5, 5, 5, 15} is"); Console.WriteLine(" = {0}"
             , TestSet9.isStepped(new int[] { 5, 5, 5, 15 }));

            Console.Write("isStepped of   {3, 3, 3, 2, 2, 2, 5, 5, 5} is"); Console.WriteLine(" = {0}"
             , TestSet9.isStepped(new int[] { 3, 3, 3, 2, 2, 2, 5, 5, 5 }));

            Console.Write("isStepped of   {3, 3, 3, 2, 2, 2, 1, 1, 1} is"); Console.WriteLine(" = {0}"
            , TestSet9.isStepped(new int[] { 3, 3, 3, 2, 2, 2, 1, 1, 1 }));

            Console.Write("isStepped of   {1, 1, 1} is"); Console.WriteLine(" = {0}"
            , TestSet9.isStepped(new int[] { 1, 1, 1 }));

            Console.Write("isStepped of   {1, 1, 1, 1, 1, 1, 1} is"); Console.WriteLine(" = {0}"
          , TestSet9.isStepped(new int[] { 1, 1, 1, 1, 1, 1, 1 }));

            Console.WriteLine("========================");
        }

        public static void isRapidlyIncreasing()
        {
            Console.WriteLine("test for isRapidlyIncreasing ");
            Console.WriteLine("========================");

            Console.Write("isRapidlyIncreasing of   {1, 3, 9, 27} is"); Console.WriteLine(" = {0}"
              , TestSet9.isRapidlyIncreasing(new int[] { 1, 3, 9, 27 }));

            Console.Write("isRapidlyIncreasing of   {1, 3, 200, 500} is"); Console.WriteLine(" = {0}"
             , TestSet9.isRapidlyIncreasing(new int[] { 1, 3, 200, 500 }));

            Console.Write("isRapidlyIncreasing of   {1} is"); Console.WriteLine(" = {0}"
             , TestSet9.isRapidlyIncreasing(new int[] { 1 }));

            Console.Write("isRapidlyIncreasing of   {1, 3, 9, 26} is"); Console.WriteLine(" = {0}"
             , TestSet9.isRapidlyIncreasing(new int[] { 1, 3, 9, 26 }));

            Console.Write("isRapidlyIncreasing of   {1, 3, 7, 26} is"); Console.WriteLine(" = {0}"
             , TestSet9.isRapidlyIncreasing(new int[] { 1, 3, 7, 26 }));

            Console.Write("isRapidlyIncreasing of   {1, 3, 8, 26} is"); Console.WriteLine(" = {0}"
             , TestSet9.isRapidlyIncreasing(new int[] { 1, 3, 8, 26 }));


            Console.WriteLine("========================");
        }
    }
}
