using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet2
{
    public static class TestSet2Test
    {
        public static void countSquarePairs()
        {
            Console.WriteLine("test for countSquarePairs ");
            Console.WriteLine("========================");

            Console.Write("array {11, 5, 4, 20} is"); Console.WriteLine(" = {0}"
                 , TestSet2.countSquarePairs(new int[] { 11, 5, 4, 20 }));

            Console.Write("array {9, 0, 2, -5, 7} is"); Console.WriteLine(" = {0}"
                  , TestSet2.countSquarePairs(new int[] { 9, 0, 2, -5, 7 }));

            Console.Write("array {9} is"); Console.WriteLine(" = {0}"
                 , TestSet2.countSquarePairs(new int[] { 9 }));

            Console.WriteLine("========================");

        }

        public static void findPorcupineNumber()
        {
            Console.WriteLine("test for findPorcupineNumber ");
            Console.WriteLine("========================");

            Console.Write("PorcupineNumber for 0 is"); Console.WriteLine(" = {0}"
                 , TestSet2.findPorcupineNumber(0));

            Console.Write("PorcupineNumber for 138 is"); Console.WriteLine(" = {0}"
                 , TestSet2.findPorcupineNumber(138));

            Console.Write("PorcupineNumber for 139 is"); Console.WriteLine(" = {0}"
                , TestSet2.findPorcupineNumber(139));

            Console.WriteLine("========================");

        }

        public static void isGuthrieSequence()
        {
            Console.WriteLine("test for isGuthrieSequence ");
            Console.WriteLine("========================");

            Console.Write("PorcupineNumber for { 7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 } is"); Console.WriteLine(" = {0}"
                 , TestSet2.isGuthrieSequence(new int[] { 7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 }));

            Console.Write("PorcupineNumber for {8, 4, 2, 1} is"); Console.WriteLine(" = {0}"
                 , TestSet2.isGuthrieSequence(new int[] { 8, 4, 2, 1 }));

            Console.Write("PorcupineNumber for {8, 17, 4, 1} is"); Console.WriteLine(" = {0}"
             , TestSet2.isGuthrieSequence(new int[] { 8, 17, 4, 1 }));

            Console.Write("PorcupineNumber for {8, 4, 1} is"); Console.WriteLine(" = {0}"
            , TestSet2.isGuthrieSequence(new int[] { 8, 4, 1 }));

            Console.Write("PorcupineNumber for {8, 4, 2} is"); Console.WriteLine(" = {0}"
            , TestSet2.isGuthrieSequence(new int[] { 8, 4, 2 }));

            Console.WriteLine("========================");

        }
    }
}
