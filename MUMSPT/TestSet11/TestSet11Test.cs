using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet11
{
   public static  class TestSet11Test
    {
        public static void isMartian()
        {
            Console.WriteLine("test for isMartian ");
            Console.WriteLine("========================");

            Console.Write("isMartian of   {1, 3} is"); Console.WriteLine(" = {0}"
              , TestSet11.isMartian(new int[] { 1, 3 }));

            Console.Write("isMartian of   {1, 2, 1, 2, 1, 2, 1, 2, 1} is"); Console.WriteLine(" = {0}"
             , TestSet11.isMartian(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1 }));


            Console.Write("isMartian of   {1, 3, 2} is"); Console.WriteLine(" = {0}"
             , TestSet11.isMartian(new int[] { 1, 3, 2 }));

            Console.Write("isMartian of   {1, 3, 3, 2, 1} is"); Console.WriteLine(" = {0}"
             , TestSet11.isMartian(new int[] { 1, 3, 3, 2, 1 }));

            Console.Write("isMartian of   {1, 2, -18, -18, 1, 2} is"); Console.WriteLine(" = {0}"
             , TestSet11.isMartian(new int[] { 1, 2, -18, -18, 1, 2 }));

            Console.Write("isMartian of   {} is"); Console.WriteLine(" = {0}"
             , TestSet11.isMartian(new int[] { }));

            Console.Write("isMartian of   {1} is"); Console.WriteLine(" = {0}"
             , TestSet11.isMartian(new int[] { 1 }));

            Console.Write("isMartian of   {2} is"); Console.WriteLine(" = {0}"
            , TestSet11.isMartian(new int[] { 2 }));


            Console.WriteLine("========================");
        }

        public static void closestFibonacci()
        {
            Console.WriteLine("test for closestFibonacci ");
            Console.WriteLine("========================");

            Console.Write("closestFibonacci of   12 is"); Console.WriteLine(" = {0}"
              , TestSet11.closestFibonacci(12));

            Console.Write("closestFibonacci of   33 is"); Console.WriteLine(" = {0}"
              , TestSet11.closestFibonacci(33));

            Console.Write("closestFibonacci of   34 is"); Console.WriteLine(" = {0}"
              , TestSet11.closestFibonacci(34));

            Console.Write("closestFibonacci of   0 is"); Console.WriteLine(" = {0}"
             , TestSet11.closestFibonacci(0));
            Console.WriteLine("========================");
        }

        public static void isPrimeHappy()
        {
            Console.WriteLine("test for isPrimeHappy ");
            Console.WriteLine("========================");

            Console.Write("isPrimeHappy of   5 is"); Console.WriteLine(" = {0}"
              , TestSet11.isPrimeHappy(5));

            Console.Write("isPrimeHappy of   25 is"); Console.WriteLine(" = {0}"
              , TestSet11.isPrimeHappy(25));

            Console.Write("isPrimeHappy of   32 is"); Console.WriteLine(" = {0}"
               , TestSet11.isPrimeHappy(32));

            Console.Write("isPrimeHappy of   8 is"); Console.WriteLine(" = {0}"
               , TestSet11.isPrimeHappy(8));

            Console.Write("isPrimeHappy of   2 is"); Console.WriteLine(" = {0}"
               , TestSet11.isPrimeHappy(2));

            Console.WriteLine("========================");
        }

    }
}
