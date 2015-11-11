using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet1
{
  public static  class TestSet1Test
    {
        public static void primeCount()
        {
            int[] Start = new int[] {10,11,20,1,5,6,-10 };
            int[] End = new int[] { 30,29,22,1,5,2,6};
            for (int i = 0; i < Start.Length; i++)
            {
                Console.WriteLine("primeCount between {0} and {1} is {2} "
                    , Start[i], End[i]
                    , TestSet1.primeCount(Start[i], End[i]));
            } 
            
            Console.WriteLine("========================");
           
        }
        
        public static void Fibb()
        {
            Console.Write("array {2, 1, 1} is"); Console.WriteLine(" = {0}"
                 , TestSet1.nonRecusiveFib(9));
            string vva = TestSet1.RecusiveFib(9).ToString();
            
            Console.Write("array {2, 1, 1} is"); Console.WriteLine(" = {0}"
                , vva);

        }

        public static void isMadhavArray()
        {
            Console.WriteLine("test is isMadhavArray ");
            Console.WriteLine("========================");
            Console.Write("array {2, 1, 1} is");Console.WriteLine(" = {0}"
                , TestSet1.isMadhavArray(new int[] { 2, 1, 1 }));

            Console.Write("array {2, 1, 1, 4, -1, -1} is"); Console.WriteLine("= {0}"
                 , TestSet1.isMadhavArray(new int[] { 2, 1, 1, 4, -1, -1 }));

            Console.Write("array {6, 2, 4, 2, 2, 2, 1, 5, 0, 0} is"); Console.WriteLine(" = {0}"
                , TestSet1.isMadhavArray(new int[] { 6, 2, 4, 2, 2, 2, 1, 5, 0, 0 }));

            Console.Write("array {18, 9, 10, 6, 6, 6} is"); Console.WriteLine(" = {0}"
                , TestSet1.isMadhavArray(new int[] { 18, 9, 10, 6, 6, 6 }));

            Console.Write("array {-6, -3, -3, 8, -5, -4} is"); Console.WriteLine(" = {0}"
                , TestSet1.isMadhavArray(new int[] { -6, -3, -3, 8, -5, -4 }));

            Console.Write("array {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, -2, -1} is"); Console.WriteLine(" = {0}"
                , TestSet1.isMadhavArray(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, -2, -1 }));

            Console.Write("array {3, 1, 2, 3, 0} is"); Console.WriteLine(" = {0}"
               , TestSet1.isMadhavArray(new int[] { 3, 1, 2, 3, 0 }));

            Console.WriteLine("========================");

        }

        public static void isInertial()
        {
            Console.WriteLine("test is isInertial ");
            Console.WriteLine("========================");
            Console.Write("array {11, 4, 20, 9, 2, 8} is"); Console.WriteLine(" = {0}"
                 , TestSet1.isInertial(new int[] { 11, 4, 20, 9, 2, 8 }));

            Console.Write("array  {12, 11, 4, 9, 2, 3, 10} is"); Console.WriteLine("= {0}"
                 , TestSet1.isInertial(new int[] { 12, 11, 4, 9, 2, 3, 10 }));

            Console.Write("array {1} is"); Console.WriteLine(" = {0}"
                , TestSet1.isInertial(new int[] { 1 }));

            Console.Write("array {2} is"); Console.WriteLine(" = {0}"
                , TestSet1.isInertial(new int[] { 2 }));

            Console.Write("array {1, 2, 3, 4} is"); Console.WriteLine(" = {0}"
                , TestSet1.isInertial(new int[] { 1, 2, 3, 4 }));

            Console.Write("array {1, 1, 1, 1, 1, 1, 2} is"); Console.WriteLine(" = {0}"
                , TestSet1.isInertial(new int[] { 1, 1, 1, 1, 1, 1, 2 }));

            Console.Write("array {2, 12, 4, 6, 8, 11} is"); Console.WriteLine(" = {0}"
               , TestSet1.isInertial(new int[] { 2, 12, 4, 6, 8, 11 }));

            Console.Write("array {2, 12, 12, 4, 6, 8, 11} is"); Console.WriteLine(" = {0}"
               , TestSet1.isInertial(new int[] { 2, 12, 12, 4, 6, 8, 11 }));

            Console.Write("array {-2, -4, -6, -8, -11} is"); Console.WriteLine(" = {0}"
               , TestSet1.isInertial(new int[] { -2, -4, -6, -8, -11 }));

            Console.Write("array {2, 3, 5, 7} is"); Console.WriteLine(" = {0}"
               , TestSet1.isInertial(new int[] { 2, 3, 5, 7 }));

            Console.Write("array {2, 4, 6, 8, 10} is"); Console.WriteLine(" = {0}"
               , TestSet1.isInertial(new int[] { 2, 4, 6, 8, 10 }));

            Console.Write("array {} is"); Console.WriteLine(" = {0}"
              , TestSet1.isInertial(new int[] {  }));

            Console.WriteLine("========================");

        }
    }
}
