using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet16
{
    public static class TestSet16Test
    {
        public static void largestAdjacentSum()
        {
            Console.WriteLine("test for largestAdjacentSum ");
            Console.WriteLine("========================");

            Console.Write("largestAdjacentSum of   {1, 2, 3, 4}   is"); Console.WriteLine(" = {0}"
             , TestSet16.largestAdjacentSum(new int[] { 1, 2, 3, 4 }));

            Console.Write("largestAdjacentSum of   {18, -12, 9, -10}   is"); Console.WriteLine(" = {0}"
             , TestSet16.largestAdjacentSum(new int[] { 18, -12, 9, -10 }));

            Console.Write("largestAdjacentSum of   {1,1,1,1,1,1,1,1,1}    is"); Console.WriteLine(" = {0}"
             , TestSet16.largestAdjacentSum(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));

            Console.Write("largestAdjacentSum of   {1,1,1,1,1,2,1,1,1}    is"); Console.WriteLine(" = {0}"
             , TestSet16.largestAdjacentSum(new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1 }));

            Console.WriteLine("========================");
        }

        public static void checkConcatenatedSum()
        {
            Console.WriteLine("test for checkConcatenatedSum ");
            Console.WriteLine("========================");

            Console.Write("checkConcatenatedSum of   192,2   is"); Console.WriteLine(" = {0}"
             , TestSet16.checkConcatenatedSum(198,2));

            Console.Write("checkConcatenatedSum of   192,3   is"); Console.WriteLine(" = {0}"
             , TestSet16.checkConcatenatedSum(198, 3));

            Console.Write("checkConcatenatedSum of   2997,3   is"); Console.WriteLine(" = {0}"
             , TestSet16.checkConcatenatedSum(2997, 3));

            Console.Write("checkConcatenatedSum of   2997,2   is"); Console.WriteLine(" = {0}"
            , TestSet16.checkConcatenatedSum(2997, 2));

            Console.Write("checkConcatenatedSum of   13332,4   is"); Console.WriteLine(" = {0}"
             , TestSet16.checkConcatenatedSum(13332, 4));

            Console.Write("checkConcatenatedSum of   9,1   is"); Console.WriteLine(" = {0}"
             , TestSet16.checkConcatenatedSum(9, 1));

            Console.WriteLine("========================");
        }

        public static void isSequencedArray()
        {
            Console.WriteLine("test for isSequencedArray ");
            Console.WriteLine("========================");

            Console.Write("isSequencedArray of   {2, 2, 3, 4, 4, 4, 5} ,2,5   is"); Console.WriteLine(" = {0}"
             , TestSet16.isSequencedArray(new int[] { 2, 2, 3, 4, 4, 4, 5 }, 2, 5));

            Console.Write("isSequencedArray of    {2, 2, 3, 5, 5, 5}  ,2,5   is"); Console.WriteLine(" = {0}"
            , TestSet16.isSequencedArray(new int[] { 2, 2, 3, 5, 5, 5 }, 2, 5));

            Console.Write("isSequencedArray of     {0, 2, 2, 3, 3}   ,2,3   is"); Console.WriteLine(" = {0}"
                        , TestSet16.isSequencedArray(new int[] { 0, 2, 2, 3, 3 }, 2, 3));

            Console.Write("isSequencedArray of     {1,1, 3, 2, 2, 4}    ,1,4   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { 1, 1, 3, 2, 2, 4 }, 1, 4));

            Console.Write("isSequencedArray of     {1, 2, 3, 4, 5}  ,1,5   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { 1, 2, 3, 4, 5 }, 1, 5));

            Console.Write("isSequencedArray of     {1, 3, 4, 2, 5}  ,1,5   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { 1, 3, 4, 2, 5 }, 1, 5));

            Console.Write("isSequencedArray of     {-5, -5, -4, -4, -4, -3, -3, -2, -2, -2}  ,-5,-2   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { -5, -5, -4, -4, -4, -3, -3, -2, -2, -2 }, -5, -2));

            Console.Write("isSequencedArray of     {0, 1, 2, 3, 4, 5}  ,1,5   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { 0, 1, 2, 3, 4, 5 }, 1, 5));

            Console.Write("isSequencedArray of     {1, 2, 3, 4}  ,1,5   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { 1, 2, 3, 4 }, 1, 5));

            Console.Write("isSequencedArray of     {1, 2, 5}  ,1,5   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { 1, 2, 5 }, 1, 5));

            Console.Write("isSequencedArray of     {5, 4, 3, 2, 1}  ,1,5   is"); Console.WriteLine(" = {0}"
                       , TestSet16.isSequencedArray(new int[] { 5, 4, 3, 2, 1 }, 1, 5));

            Console.WriteLine("========================");
        }
    }
}
