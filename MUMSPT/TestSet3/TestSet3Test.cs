using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet4
{
    public static class TestSet3Test
    {
        public static void stantonMeasure()
        {
            Console.WriteLine("test for stantonMeasure ");
            Console.WriteLine("========================");

            Console.Write("array {1, 4, 3, 2, 1, 2, 3, 2} is"); Console.WriteLine(" = {0}"
                 , TestSet3.stantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 }));

            Console.Write("array {1} is"); Console.WriteLine(" = {0}"
                , TestSet3.stantonMeasure(new int[] { 1 }));

            Console.Write("array {0} is"); Console.WriteLine(" = {0}"
                , TestSet3.stantonMeasure(new int[] { 0 }));

            Console.Write("array {3, 1, 1, 4} is"); Console.WriteLine(" = {0}"
                , TestSet3.stantonMeasure(new int[] { 3, 1, 1, 4 }));

            Console.Write("array {1, 3, 1, 1, 3, 3, 2, 3, 3, 3, 4} is"); Console.WriteLine(" = {0}"
                , TestSet3.stantonMeasure(new int[] { 1, 3, 1, 1, 3, 3, 2, 3, 3, 3, 4 }));

            Console.Write("array {} is"); Console.WriteLine(" = {0}"
                , TestSet3.stantonMeasure(new int[] { }));

            Console.WriteLine("========================");

        }

        public static void sumFactor()
        {
            Console.WriteLine("test for sumFactor ");
            Console.WriteLine("========================");

            Console.Write("array {1, -1, 1, -1, 1, -1, 1} is"); Console.WriteLine(" = {0}"
                 , TestSet3.sumFactor(new int[] { 1, -1, 1, -1, 1, -1, 1 }));

            Console.Write("array {1, 2, 3, 4} is"); Console.WriteLine(" = {0}"
                 , TestSet3.sumFactor(new int[] { 1, 2, 3, 4 }));

            Console.Write("array {3, 0, 2, -5, 0} is"); Console.WriteLine(" = {0}"
                , TestSet3.sumFactor(new int[] { 3, 0, 2, -5, 0 }));

            Console.Write("array {9, -3, -3, -1, -1} is"); Console.WriteLine(" = {0}"
                , TestSet3.sumFactor(new int[] { 9, -3, -3, -1, -1 }));

            Console.Write("array {1} is"); Console.WriteLine(" = {0}"
                , TestSet3.sumFactor(new int[] { 1 }));

            Console.Write("array {0, 0, 0} is"); Console.WriteLine(" = {0}"
                , TestSet3.sumFactor(new int[] { 0, 0, 0 }));

            Console.WriteLine("========================");

        }

        public static void guthrieIndex()
        {
            Console.WriteLine("test for guthrieIndex ");
            Console.WriteLine("========================");

            Console.Write("guthrieIndex of 7 is"); Console.WriteLine(" = {0}"
                 , TestSet3.guthrieIndex(7));

            Console.Write("guthrieIndex of 1 is"); Console.WriteLine(" = {0}"
                , TestSet3.guthrieIndex(1));


            Console.Write("guthrieIndex of 2 is"); Console.WriteLine(" = {0}"
                , TestSet3.guthrieIndex(2));

            Console.Write("guthrieIndex of 3 is"); Console.WriteLine(" = {0}"
                , TestSet3.guthrieIndex(3));


            Console.Write("guthrieIndex of 4 is"); Console.WriteLine(" = {0}"
                , TestSet3.guthrieIndex(4));

            Console.Write("guthrieIndex of 42 is"); Console.WriteLine(" = {0}"
                , TestSet3.guthrieIndex(42));
        }

        
    }
}
