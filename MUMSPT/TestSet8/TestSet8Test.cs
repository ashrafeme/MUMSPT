using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet8
{
   public static class TestSet8Test
    {
        public static void isIsolated()
        {
            Console.WriteLine("test for isIsolated ");
            Console.WriteLine("========================");

            Console.Write("isIsolated of  163 is"); Console.WriteLine(" = {0}"
               , TestSet8.isIsolated(163));

            Console.Write("isIsolated of  162 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(162));

            Console.Write("isIsolated of  63 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(63));

            Console.Write("isIsolated of  58 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(58));

            Console.Write("isIsolated of  34 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(34));

            Console.Write("isIsolated of  28 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(28 ));

            Console.Write("isIsolated of  24 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(24));
            Console.Write("isIsolated of  14 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(14));
            Console.Write("isIsolated of  9 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(9));

            Console.Write("isIsolated of  10 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(10));

              Console.Write("isIsolated of  62 is"); Console.WriteLine(" = {0}"
              , TestSet8.isIsolated(62));

            Console.WriteLine("========================");
        }

        public static void isVanilla()
        {
            Console.WriteLine("test for isVanilla ");
            Console.WriteLine("========================");

            Console.Write("isVanilla of   {1, 1, 11, 1111, 1111111} is"); Console.WriteLine(" = {0}"
               , TestSet8.isVanilla(new int[] { 1, 1, 11, 1111, 1111111 }));

            Console.Write("isVanilla of   {11, 101, 1111, 11111}  is"); Console.WriteLine(" = {0}"
               , TestSet8.isVanilla(new int[] { 11, 101, 1111, 11111 }));

            Console.Write("isVanilla of   {1} is"); Console.WriteLine(" = {0}"
               , TestSet8.isVanilla(new int[] { 1 }));

            Console.Write("isVanilla of   {11, 22, 13, 34, 125} is"); Console.WriteLine(" = {0}"
               , TestSet8.isVanilla(new int[] { 11, 22, 13, 34, 125 }));

            Console.Write("isVanilla of   {9, 999, 99999, -9999} is"); Console.WriteLine(" = {0}"
               , TestSet8.isVanilla(new int[] { 9, 999, 99999, -9999 }));

            Console.Write("isVanilla of   { } is"); Console.WriteLine(" = {0}"
              , TestSet8.isVanilla(new int[] { }));

            Console.WriteLine("========================");
        }

        public static void isTrivalent()
        {
            Console.WriteLine("test for isTrivalent ");
            Console.WriteLine("========================");

            Console.Write("isTrivalent of   {22, 19, 10, 10, 19, 22, 22, 10} is"); Console.WriteLine(" = {0}"
               , TestSet8.isTrivalent(new int[] { 22, 19, 10, 10, 19, 22, 22, 10 }));

            Console.Write("isTrivalent of    {1, 2, 2, 2, 2, 2, 2}  is"); Console.WriteLine(" = {0}"
               , TestSet8.isTrivalent(new int[] { 1, 2, 2, 2, 2, 2, 2 }));

            Console.Write("isTrivalent of   {2, 2, 3, 3, 3, 3, 2, 41, 65} is"); Console.WriteLine(" = {0}"
              , TestSet8.isTrivalent(new int[] { 2, 2, 3, 3, 3, 3, 2, 41, 65 }));

            Console.Write("isTrivalent of   {-1, 0, 1, 0, 0, 0} is"); Console.WriteLine(" = {0}"
              , TestSet8.isTrivalent(new int[] { -1, 0, 1, 0, 0, 0 }));

            Console.Write("isTrivalent of   { 2147483647, -1, -1 ,- 2147483648} is"); Console.WriteLine(" = {0}"
              , TestSet8.isTrivalent(new int[] { 2147483647, -1, -1, -2147483648 }));

            Console.Write("isTrivalent of   {} is"); Console.WriteLine(" = {0}"
              , TestSet8.isTrivalent(new int[] {  }));

            Console.WriteLine("========================");
        }
    }
}
