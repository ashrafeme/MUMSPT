using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet13
{
    public static class TestSet13Test
    {
        public static void countRepresentations()
        {
            Console.WriteLine("test for countRepresentations ");
            Console.WriteLine("========================");

            Console.Write("countRepresentations of  12 is"); Console.WriteLine(" = {0}"
               , TestSet13.countRepresentations(12));

            Console.Write("countRepresentations of  50 is"); Console.WriteLine(" = {0}"
               , TestSet13.countRepresentations(50));

            Console.Write("countRepresentations of  10 is"); Console.WriteLine(" = {0}"
               , TestSet13.countRepresentations(10));

            Console.Write("countRepresentations of  5 is"); Console.WriteLine(" = {0}"
               , TestSet13.countRepresentations(5));

            Console.Write("countRepresentations of  2 is"); Console.WriteLine(" = {0}"
               , TestSet13.countRepresentations(2));

            Console.WriteLine("========================");
        }

        public static void isSequentiallyBounded()
        {
            Console.WriteLine("test for isSequentiallyBounded ");
            Console.WriteLine("========================");

            Console.Write("isSequentiallyBounded of  {2, 3, 3, 99, 99, 99, 99, 99} is"); Console.WriteLine(" = {0}"
               , TestSet13.isSequentiallyBounded(new int[] { 2, 3, 3, 99, 99, 99, 99, 99 }));

            Console.Write("isSequentiallyBounded of  {1, 2, 3} is"); Console.WriteLine(" = {0}"
               , TestSet13.isSequentiallyBounded(new int[] { 1, 2, 3 }));

            Console.Write("isSequentiallyBounded of  {2, 3, 3, 3, 3} is"); Console.WriteLine(" = {0}"
               , TestSet13.isSequentiallyBounded(new int[] { 2, 3, 3, 3, 3 }));

            Console.Write("isSequentiallyBounded of  {12, 12, 9} is"); Console.WriteLine(" = {0}"
               , TestSet13.isSequentiallyBounded(new int[] { 12, 12, 9 }));

            Console.Write("isSequentiallyBounded of  {0, 1} is"); Console.WriteLine(" = {0}"
               , TestSet13.isSequentiallyBounded(new int[] { 0, 1 }));

            Console.Write("isSequentiallyBounded of  {-1, 2} is"); Console.WriteLine(" = {0}"
               , TestSet13.isSequentiallyBounded(new int[] { -1, 2 }));

            Console.Write("isSequentiallyBounded of  {} is"); Console.WriteLine(" = {0}"
               , TestSet13.isSequentiallyBounded(new int[] { }));

            Console.Write("isSequentiallyBounded of  {5, 5, 5, 5} is"); Console.WriteLine(" = {0}"
                           , TestSet13.isSequentiallyBounded(new int[] { 5, 5, 5, 5 }));

            Console.Write("isSequentiallyBounded of  {5, 5, 5, 2, 5} is"); Console.WriteLine(" = {0}"
                           , TestSet13.isSequentiallyBounded(new int[] { 5, 5, 5, 2, 5 }));


            Console.WriteLine("========================");
        }

        public static void isMinMaxDisjoint()
        {
            Console.WriteLine("test for isMinMaxDisjoint ");
            Console.WriteLine("========================");

            Console.Write("isMinMaxDisjoint of  {5, 4, 1, 3, 2} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] { 5, 4, 1, 3, 2 }));

            Console.Write("isMinMaxDisjoint of  {18, -1, 3, 4, 0} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] { 18, -1, 3, 4, 0 }));

            Console.Write("isMinMaxDisjoint of  {9, 0, 5, 9} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] { 9, 0, 5, 9 }));

            Console.Write("isMinMaxDisjoint of {0, 5, 18, 0, 9} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] { 0, 5, 18, 0, 9 }));

            Console.Write("isMinMaxDisjoint of  {7, 7, 7, 7} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] { 7, 7, 7, 7 }));

            Console.Write("isMinMaxDisjoint of  {} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] {  }));

            Console.Write("isMinMaxDisjoint of  {1, 2} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] { 1, 2 }));

            Console.Write("isMinMaxDisjoint of  {1} is"); Console.WriteLine(" = {0}"
               , TestSet13.isMinMaxDisjoint(new int[] { 1 }));


            Console.WriteLine("========================");
        }

    }
}
