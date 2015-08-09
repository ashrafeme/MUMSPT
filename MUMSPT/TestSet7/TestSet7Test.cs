using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet7
{
    public static class TestSet7Test
    {
        public static void matches()
        {
            Console.WriteLine("test for matches ");
            Console.WriteLine("========================");

            Console.Write("array { 1, 2, 3, -5, -5, 2, 3, 18 },  { 3, -2, 3} is"); Console.WriteLine(" = {0}"
                , TestSet7.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 3, -2, 3}));

            Console.Write("array  {1,  2,  3, -5, -5,  2, 3, 18},  {4, -1, 3} is"); Console.WriteLine(" = {0}"
                , TestSet7.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 4, -1, 3 }));


            Console.WriteLine("========================");
        }
        public static void isStacked()
        {
            Console.WriteLine("test for isStacked ");
            Console.WriteLine("========================");
            
            Console.Write("isStacked of 1 is"); Console.WriteLine(" = {0}"
               , TestSet7.isStacked(1));

            Console.Write("isStacked of 3 is"); Console.WriteLine(" = {0}"
               , TestSet7.isStacked(3));

            Console.Write("isStacked of 6 is"); Console.WriteLine(" = {0}"
               , TestSet7.isStacked(6));
            Console.Write("isStacked of 7 is"); Console.WriteLine(" = {0}"
               , TestSet7.isStacked(7));
            Console.Write("isStacked of 8 is"); Console.WriteLine(" = {0}"
               , TestSet7.isStacked(8));

            Console.Write("isStacked of 9 is"); Console.WriteLine(" = {0}"
              , TestSet7.isStacked(9));
            Console.Write("isStacked of 10 is"); Console.WriteLine(" = {0}"
               , TestSet7.isStacked(10));

            Console.Write("isStacked of 15 is"); Console.WriteLine(" = {0}"
             , TestSet7.isStacked(15));
            
            Console.WriteLine("========================");
        }

        public static void isSumSafe()
        {
            Console.WriteLine("test for isSumSafe ");
            Console.WriteLine("========================");

            Console.Write("isSumSafe of  {5, -5, 0} is"); Console.WriteLine(" = {0}"
               , TestSet7.isSumSafe(new int[] { 5, -5, 0 }));

            Console.Write("isSumSafe of   {5, -2, 1} is"); Console.WriteLine(" = {0}"
               , TestSet7.isSumSafe(new int[] { 5, -2, 1 }));
            
            Console.WriteLine("========================");
        }
    }
}
