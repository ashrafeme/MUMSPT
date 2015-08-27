using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet31
{
   public static class TestSet31Test
    {
        public static void isDual()
        {
            Console.WriteLine("test for isDual ");
            Console.WriteLine("========================");

            Console.Write("isDual of    {1, 2, 3, 0}     is"); Console.WriteLine(" = {0}"
              , TestSet31.isDual(new int[] { 1, 2, 3, 0 }));

            Console.Write("isDual of    {1, 2, 2, 1, 3, 0}     is"); Console.WriteLine(" = {0}"
              , TestSet31.isDual(new int[] { 1, 2, 2, 1, 3, 0 }));


            Console.Write("isDual of   {1, 1, 2, 2}     is"); Console.WriteLine(" = {0}"
              , TestSet31.isDual(new int[] { 1, 1, 2, 2 }));

            Console.Write("isDual of    {1, 2, 1}     is"); Console.WriteLine(" = {0}"
              , TestSet31.isDual(new int[] { 1, 2, 1 }));

            Console.Write("isDual of    {}     is"); Console.WriteLine(" = {0}"
             , TestSet31.isDual(new int[] {  }));



            Console.WriteLine("========================");
        }

        public static void isAllPossibilities()
        {
            Console.WriteLine("test for isAllPossibilities ");
            Console.WriteLine("========================");

            Console.Write("isAllPossibilities of   {1, 2, 0, 3}   is"); Console.WriteLine(" = {0}"
              , TestSet31.isAllPossibilities(new int[] { 1, 2, 0, 3 }));

            Console.Write("isAllPossibilities of   {3, 2, 1, 0}   is"); Console.WriteLine(" = {0}"
                          , TestSet31.isAllPossibilities(new int[] { 3, 2, 1, 0 }));

            Console.Write("isAllPossibilities of   {1, 2, 4, 3}   is"); Console.WriteLine(" = {0}"
                          , TestSet31.isAllPossibilities(new int[] { 1, 2, 4, 3 }));

            Console.Write("isAllPossibilities of   {0, 2, 3}   is"); Console.WriteLine(" = {0}"
                         , TestSet31.isAllPossibilities(new int[] { 0, 2, 3 }));


            Console.Write("isAllPossibilities of   {0}   is"); Console.WriteLine(" = {0}"
                         , TestSet31.isAllPossibilities(new int[] { 0 }));

            Console.Write("isAllPossibilities of   {}   is"); Console.WriteLine(" = {0}"
                        , TestSet31.isAllPossibilities(new int[] { }));

            Console.WriteLine("========================");

        }

        public static void isLayered()
        {
            Console.WriteLine("test for isLayered ");
            Console.WriteLine("========================");

            Console.Write("isLayered of    {1, 1, 2, 2, 2, 3, 3}     is"); Console.WriteLine(" = {0}"
              , TestSet31.isLayered(new int[] { 1, 1, 2, 2, 2, 3, 3 }));

            Console.Write("isLayered of    {3, 3, 3, 3, 3, 3, 3}     is"); Console.WriteLine(" = {0}"
              , TestSet31.isLayered(new int[] { 3, 3, 3, 3, 3, 3, 3 }));

            Console.Write("isLayered of    {1, 2, 2, 2, 3, 3}     is"); Console.WriteLine(" = {0}"
             , TestSet31.isLayered(new int[] { 1, 2, 2, 2, 3, 3 }));

            Console.Write("isLayered of   {2, 2, 2, 3, 3, 1, 1}     is"); Console.WriteLine(" = {0}"
             , TestSet31.isLayered(new int[] { 2, 2, 2, 3, 3, 1, 1 }));

            Console.Write("isLayered of   {2}    is"); Console.WriteLine(" = {0}"
             , TestSet31.isLayered(new int[] { 2 }));

            Console.Write("isLayered of   {}    is"); Console.WriteLine(" = {0}"
            , TestSet31.isLayered(new int[] { }));

            Console.WriteLine("========================");
        }
    }
}
