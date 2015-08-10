using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet14
{
    public static class TestSet14Test
    {
        public static void Qone()
        {
            Console.WriteLine("test for fullnessQuotient ");
            Console.WriteLine("========================");

            Console.Write("fullnessQuotient of   94  is"); Console.WriteLine(" = {0}"
             , TestSet14.fullnessQuotient(94));

            Console.Write("fullnessQuotient of   1  is"); Console.WriteLine(" = {0}"
             , TestSet14.fullnessQuotient(1));

            Console.Write("fullnessQuotient of   9  is"); Console.WriteLine(" = {0}"
            , TestSet14.fullnessQuotient(9));

            Console.Write("fullnessQuotient of   360  is"); Console.WriteLine(" = {0}"
            , TestSet14.fullnessQuotient(360));

            Console.Write("fullnessQuotient of   -4  is"); Console.WriteLine(" = {0}"
            , TestSet14.fullnessQuotient(-4));


            Console.WriteLine("========================");
        }

        public static void QTwo()
        {
            Console.WriteLine("test for isPacked ");
            Console.WriteLine("========================");

            Console.Write("isPacked of   {2, 2, 3, 3, 3}   is"); Console.WriteLine(" = {0}"
             , TestSet14.isPacked(new int[] { 2, 2, 3, 3, 3 }));

            Console.Write("isPacked of   {2, 3, 2, 3, 3}   is"); Console.WriteLine(" = {0}"
            , TestSet14.isPacked(new int[] { 2, 3, 2, 3, 3 }));

            Console.Write("isPacked of   {2, 2, 2, 3, 3, 3}   is"); Console.WriteLine(" = {0}"
            , TestSet14.isPacked(new int[] { 2, 2, 2, 3, 3, 3 }));

            Console.Write("isPacked of   {2, 2, 1}   is"); Console.WriteLine(" = {0}"
         , TestSet14.isPacked(new int[] { 2, 2, 1 }));

            Console.Write("isPacked of   {2, 2, 1, 2, 2}   is"); Console.WriteLine(" = {0}"
         , TestSet14.isPacked(new int[] { 2, 2, 1, 2, 2 }));

            Console.Write("isPacked of   {4, 4, 4, 4, 1, 2, 2, 3, 3, 3}   is"); Console.WriteLine(" = {0}"
         , TestSet14.isPacked(new int[] { 4, 4, 4, 4, 1, 2, 2, 3, 3, 3 } ));

            Console.Write("isPacked of   {7, 7, 7, 7, 7, 7, 7, 1}   is"); Console.WriteLine(" = {0}"
         , TestSet14.isPacked(new int[] { 7, 7, 7, 7, 7, 7, 7, 1 }));

            Console.Write("isPacked of   {7, 7, 7, 7, 1, 7, 7, 7}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { 7, 7, 7, 7, 1, 7, 7, 7 }));

            Console.Write("isPacked of   {7, 7, 7, 7, 7, 7, 7}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { 7, 7, 7, 7, 7, 7, 7 }));

            Console.Write("isPacked of   {}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { }));


            Console.Write("isPacked of   {1, 2, 1}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { 1, 2, 1 }));

            Console.Write("isPacked of   {2, 1, 1}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { 2, 1, 1 }));

            Console.Write("isPacked of   {-3, -3, -3}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { -3, -3, -3 }));

            Console.Write("isPacked of   {0, 2, 2}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { 0, 2, 2 }));

            Console.Write("isPacked of   {2, 1, 2}   is"); Console.WriteLine(" = {0}"
        , TestSet14.isPacked(new int[] { 2, 1, 2 }));

            Console.WriteLine("========================");
        }



        public static void QThree()
        {
            Console.WriteLine("test for isOddHeavy ");
            Console.WriteLine("========================");

            Console.Write("isOddHeavy of   {11, 4, 9, 2, 8}  is"); Console.WriteLine(" = {0}"
             , TestSet14.isOddHeavy(new int[] { 11, 4, 9, 2, 8 }));

            Console.Write("isOddHeavy of   {11, 4, 9, 2, 3, 10}  is"); Console.WriteLine(" = {0}"
             , TestSet14.isOddHeavy(new int[] { 11, 4, 9, 2, 3, 10 }));

            Console.Write("isOddHeavy of   {1}  is"); Console.WriteLine(" = {0}"
             , TestSet14.isOddHeavy(new int[] { 1 }));

            Console.Write("isOddHeavy of   {2}  is"); Console.WriteLine(" = {0}"
             , TestSet14.isOddHeavy(new int[] { 2 }));

            Console.Write("isOddHeavy of   {1, 1, 1, 1, 1, 1}  is"); Console.WriteLine(" = {0}"
             , TestSet14.isOddHeavy(new int[] { 1, 1, 1, 1, 1, 1 }));

            Console.Write("isOddHeavy of  {2, 4, 6, 8, 11}  is"); Console.WriteLine(" = {0}"
             , TestSet14.isOddHeavy(new int[] { 2, 4, 6, 8, 11 }));

            Console.Write("isOddHeavy of  {-2, -4, -6, -8, -11}  is"); Console.WriteLine(" = {0}"
            , TestSet14.isOddHeavy(new int[] { -2, -4, -6, -8, -11 }));

            Console.WriteLine("========================");
        }
    }
}
