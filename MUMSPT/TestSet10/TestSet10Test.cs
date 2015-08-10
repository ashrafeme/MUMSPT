using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet10
{
    public static class TestSet10Test
    {
        public static void sameNumberOfFactors()
        {
            Console.WriteLine("test for sameNumberOfFactors ");
            Console.WriteLine("========================");
            Console.Write("sameNumberOfFactors of   -6, 21 is"); Console.WriteLine(" = {0}"
              , TestSet10.sameNumberOfFactors(-6, 21));

            Console.Write("sameNumberOfFactors of   6, 21 is"); Console.WriteLine(" = {0}"
              , TestSet10.sameNumberOfFactors(6, 21));

            Console.Write("sameNumberOfFactors of   8, 12 is"); Console.WriteLine(" = {0}"
              , TestSet10.sameNumberOfFactors(8, 12));


            Console.Write("sameNumberOfFactors of   23, 97 is"); Console.WriteLine(" = {0}"
              , TestSet10.sameNumberOfFactors(23, 97));


            Console.Write("sameNumberOfFactors of   0, 1 is"); Console.WriteLine(" = {0}"
              , TestSet10.sameNumberOfFactors(0, 1));

            Console.Write("sameNumberOfFactors of   0, 0 is"); Console.WriteLine(" = {0}"
              , TestSet10.sameNumberOfFactors(0, 0));
            Console.WriteLine("========================");
        }

        public static void hasSingleMaximum()
        {
            Console.WriteLine("test for hasSingleMaximum ");
            Console.WriteLine("========================");

            Console.Write("hasSingleMaximum of   {1, 2, 3, 1, 0} is"); Console.WriteLine(" = {0}"
              , TestSet10.hasSingleMaximum(new int[] { 1, 2, 3, 1, 0 }));

            Console.Write("hasSingleMaximum of   {18} is"); Console.WriteLine(" = {0}"
              , TestSet10.hasSingleMaximum(new int[] { 18 }));

            Console.Write("hasSingleMaximum of   {1, 2, 3, 0, 1, 3} is"); Console.WriteLine(" = {0}"
              , TestSet10.hasSingleMaximum(new int[] { 1, 2, 3, 0, 1, 3 }));

            Console.Write("hasSingleMaximum of   {13, 1, 13, 2, 13, 0, 13, 1, 13} is"); Console.WriteLine(" = {0}"
              , TestSet10.hasSingleMaximum(new int[] { 13, 1, 13, 2, 13, 0, 13, 1, 13 }));

            Console.Write("hasSingleMaximum of   { } is"); Console.WriteLine(" = {0}"
              , TestSet10.hasSingleMaximum(new int[] {  }));

            Console.Write("hasSingleMaximum of   {-6, -6, -6, -6, -6, -6, -6} is"); Console.WriteLine(" = {0}"
              , TestSet10.hasSingleMaximum(new int[] { -6, -6, -6, -6, -6, -6, -6 }));

            Console.WriteLine("========================");
        }
    }
}
