using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet22
{
    public static class TestSet22Test
    {
        public static void isHodder()
        {
            Console.WriteLine("test for isHodder ");
            Console.WriteLine("========================");

            Console.Write("isHodder of  3   is"); Console.WriteLine(" = {0}"
             , TestSet22.isHodder(3));

            Console.Write("isHodder of  7   is"); Console.WriteLine(" = {0}"
            , TestSet22.isHodder(7));


            Console.Write("isHodder of  31   is"); Console.WriteLine(" = {0}"
           , TestSet22.isHodder(31));

            Console.Write("isHodder of  127   is"); Console.WriteLine(" = {0}"
           , TestSet22.isHodder(127));


            Console.WriteLine("========================");
        }

        public static void areAnagrams()
        {
            Console.WriteLine("test for areAnagrams ");
            Console.WriteLine("========================");

            Console.Write("areAnagrams of   {'s', 'i', 't'},{'i', 't', 's'}   is"); Console.WriteLine(" = {0}"
             , TestSet22.areAnagrams(new char[] {'s', 'i', 't'}, new char[] {'i', 't', 's'}));

            Console.Write("areAnagrams of   {'s', 'i', 't'} and {'i', 'd', 's'}   is"); Console.WriteLine(" = {0}"
             , TestSet22.areAnagrams(new char[] { 's', 'i', 't' }, new char[] { 'i', 'd', 's' }));

            Console.Write("areAnagrams of   {'b', 'i', 'g'} and {'b', 'i', 't'}   is"); Console.WriteLine(" = {0}"
             , TestSet22.areAnagrams(new char[] { 'b', 'i', 'g' }, new char[] { 'b', 'i', 't' }));

            Console.Write("areAnagrams of   {'b', 'o', 'g'} and {'b', 'o', 'o'}   is"); Console.WriteLine(" = {0}"
             , TestSet22.areAnagrams(new char[] { 'b', 'o', 'g' }, new char[] { 'b', 'o', 'o' }));

            Console.Write("areAnagrams of   {} and {}   is"); Console.WriteLine(" = {0}"
            , TestSet22.areAnagrams(new char[] {  }, new char[] {  }));

            Console.Write("areAnagrams of {'b', 'i', 'g'} and {'b', 'i', 'g'}  is"); Console.WriteLine(" = {0}"
           , TestSet22.areAnagrams(new char[] { 'b', 'i', 'g' }, new char[] { 'b', 'i', 'g' }));

            Console.Write("areAnagrams of {'p', 'o', 'o', 'l'} and {'p', 'o', 'l', 'l'}  is"); Console.WriteLine(" = {0}"
          , TestSet22.areAnagrams(new char[] { 'p', 'o', 'o', 'l' }, new char[] { 'p', 'o', 'l', 'l' }));

            Console.WriteLine("========================");
        }

        public static void closestFibonacci()
        {
            TestSet11.TestSet11Test.closestFibonacci();

        }
        }
}
