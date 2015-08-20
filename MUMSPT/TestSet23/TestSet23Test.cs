using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet23
{
    public static class TestSet23Test
    {
        public static void vesuvian()
        {
            Console.WriteLine("test for vesuvian ");
            Console.WriteLine("========================");

            Console.Write("vesuvian of  50   is"); Console.WriteLine(" = {0}"
             , TestSet23.vesuvian(50));

            Console.Write("vesuvian of  51   is"); Console.WriteLine(" = {0}"
            , TestSet23.vesuvian(51));

            Console.Write("vesuvian of   65    is"); Console.WriteLine(" = {0}"
             , TestSet23.vesuvian(65));

            Console.Write("vesuvian of   85     is"); Console.WriteLine(" = {0}"
              , TestSet23.vesuvian(85));


            Console.WriteLine("========================");

        }

        public static void isOneBalanced()
        {
            Console.WriteLine("test for isOneBalanced ");
            Console.WriteLine("========================");

            Console.Write("isOneBalanced of  {1, 1, 1, 2, 3, -18, 45, 1}   is"); Console.WriteLine(" = {0}"
             , TestSet23.isOneBalanced(new int[] { 1, 1, 1, 2, 3, -18, 45, 1 }));

            Console.Write("isOneBalanced of  {1, 1, 1, 2, 3, -18, 45, 1, 0}   is"); Console.WriteLine(" = {0}"
              , TestSet23.isOneBalanced(new int[] { 1, 1, 1, 2, 3, -18, 45, 1, 0 }));

            Console.Write("isOneBalanced of  {1, 1, 2, 3, 1, -18, 26, 1}   is"); Console.WriteLine(" = {0}"
             , TestSet23.isOneBalanced(new int[] { 1, 1, 2, 3, 1, -18, 26, 1 }));

            Console.Write("isOneBalanced of  {}   is"); Console.WriteLine(" = {0}"
             , TestSet23.isOneBalanced(new int[] { }));

            Console.Write("isOneBalanced of  {3, 4, 1, 1}   is"); Console.WriteLine(" = {0}"
            , TestSet23.isOneBalanced(new int[] { 3, 4, 1, 1 }));

            Console.Write("isOneBalanced of  {1, 1, 3, 4}   is"); Console.WriteLine(" = {0}"
            , TestSet23.isOneBalanced(new int[] { 1, 1, 3, 4 }));

            Console.Write("isOneBalanced of  {3, 3, 3, 3, 3, 3}   is"); Console.WriteLine(" = {0}"
            , TestSet23.isOneBalanced(new int[] { 3, 3, 3, 3, 3, 3 }));

            Console.Write("isOneBalanced of  {1, 1, 1, 1, 1, 1}  is"); Console.WriteLine(" = {0}"
            , TestSet23.isOneBalanced(new int[] { 1, 1, 1, 1, 1, 1 }));


            Console.WriteLine("========================");

        }

        public static void isFibonacci()
        {
            Console.WriteLine("test for isFibonacci ");
            Console.WriteLine("========================");

            Console.Write("isFibonacci of  13   is"); Console.WriteLine(" = {0}"
             , TestSet23.isFibonacci(13));


            Console.Write("isFibonacci of  27   is"); Console.WriteLine(" = {0}"
             , TestSet23.isFibonacci(27));

            Console.WriteLine("========================");

        }

    }
}
