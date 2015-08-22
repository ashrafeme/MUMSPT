using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet28
{
    public static class TestSet28Test
    {
        public static void allValuesTheSame()
        {
            Console.WriteLine("test for allValuesTheSame ");
            Console.WriteLine("========================");

            Console.Write("allValuesTheSame of   {1, 1, 1, 1}  is"); Console.WriteLine(" = {0}"
              , TestSet28.allValuesTheSame(new int[] { 1, 1, 1, 1 }));

            Console.Write("allValuesTheSame of   {83, 83, 83}  is"); Console.WriteLine(" = {0}"
              , TestSet28.allValuesTheSame(new int[] { 83, 83, 83 }));

            Console.Write("allValuesTheSame of   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}   is"); Console.WriteLine(" = {0}"
              , TestSet28.allValuesTheSame(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));

            Console.Write("allValuesTheSame of   {1, -2343456, 1, -2343456} is"); Console.WriteLine(" = {0}"
              , TestSet28.allValuesTheSame(new int[] { 1, -2343456, 1, -2343456 }));

            Console.Write("allValuesTheSame of   {0, 0, 0, 0, -1} is"); Console.WriteLine(" = {0}"
              , TestSet28.allValuesTheSame(new int[] { 0, 0, 0, 0, -1 }));


            Console.Write("allValuesTheSame of   {432123456} is"); Console.WriteLine(" = {0}"
              , TestSet28.allValuesTheSame(new int[] { 432123456 }));

            Console.Write("allValuesTheSame of   {-432123456} is"); Console.WriteLine(" = {0}"
             , TestSet28.allValuesTheSame(new int[] { -432123456 }));

            Console.Write("allValuesTheSame of   {} is"); Console.WriteLine(" = {0}"
             , TestSet28.allValuesTheSame(new int[] { }));

            Console.WriteLine("========================");

        }

        public static void hasNValues()
        {
            Console.WriteLine("test for hasNValues ");
            Console.WriteLine("========================");

            Console.Write("hasNValues of   {1, 2, 2, 1} and 2  is"); Console.WriteLine(" = {0}"
              , TestSet28.hasNValues(new int[] { 1, 2, 2, 1 }, 2));

            Console.Write("hasNValues of   {1, 1, 1, 8, 1, 1, 1, 3, 3} and 3  is"); Console.WriteLine(" = {0}"
               , TestSet28.hasNValues(new int[] { 1, 1, 1, 8, 1, 1, 1, 3, 3 }, 3));

            Console.Write("hasNValues of   {1, 2, 3, 4, 5, 6, 7, 8 ,9, 10}  and 10  is"); Console.WriteLine(" = {0}"
               , TestSet28.hasNValues(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10));


            Console.Write("hasNValues of   {1, 2, 2, 1} and 3  is"); Console.WriteLine(" = {0}"
              , TestSet28.hasNValues(new int[] { 1, 2, 2, 1 }, 3));

            Console.Write("hasNValues of   {1, 1, 1, 8, 1, 1, 1, 3, 3} and 2  is"); Console.WriteLine(" = {0}"
              , TestSet28.hasNValues(new int[] { 1, 1, 1, 8, 1, 1, 1, 3, 3 }, 2));

            Console.Write("hasNValues of   {1, 2, 3, 4, 5, 6, 7, 8 ,9, 10} and 20  is"); Console.WriteLine(" = {0}"
              , TestSet28.hasNValues(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 20));

            Console.WriteLine("========================");

        }

        public static void sameNumberOfFactors()
        {
            TestSet10.TestSet10Test.sameNumberOfFactors();
        }
    }
}
