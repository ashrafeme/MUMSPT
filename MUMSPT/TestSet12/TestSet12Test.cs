using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet12
{
    public static class TestSet12Test
    {
        public static void smallest()
        {
            Console.WriteLine("test for smallest ");
            Console.WriteLine("========================");
            for (int i = 3; i < 8; i++)
            {


                Console.Write("smallest of   " + i + " is"); Console.WriteLine(" = {0}"
                      , TestSet12.smallest(i));

            }

            Console.WriteLine("========================");
        }

        public static void clusterCompression()
        {
            Console.WriteLine("test for clusterCompression ");
            Console.WriteLine("========================");

            string ss = "{";
            var list = TestSet12.clusterCompression(new int[] { 3, 3, 3, 4, 4, 3, 2, 2, 2, 2, 4 });
            for (int i = 0; i < list.Length; i++)
            {
                
                ss += string.Format("{0},", list[i]);
            }
            ss += "}";
            Console.Write("smallest of  {3, 3, 3, 4, 4, 3, 2, 2, 2, 2, 4}  is"); Console.WriteLine(" = {0}",
                      ss
            );

            ss = "{";
            list = TestSet12.clusterCompression(new int[] { 0, 0, 0, 2, 0, 2, 0, 2, 0, 0 });
            for (int i = 0; i < list.Length; i++)
            {
                
                ss += string.Format("{0},", list[i]);
            }
            ss += "}";
            Console.Write("smallest of  {0, 0, 0, 2, 0, 2, 0, 2, 0, 0}  is"); Console.WriteLine(" = {0}", ss);


            ss = "{";
            list = TestSet12.clusterCompression(new int[] { 18 });
            for (int i = 0; i < list.Length; i++)
            {
               
                ss += string.Format("{0},", list[i]);
            }
            ss += "}";
            Console.Write("smallest of  {18}  is"); Console.WriteLine(" = {0}", ss);




            ss = "{";
            list = TestSet12.clusterCompression(new int[] { });
            for (int i = 0; i < list.Length; i++)
            {
                
                ss += string.Format("{0},", list[i]);
            }
            ss += "}";
            Console.Write("smallest of  {}  is"); Console.WriteLine(" = {0}", ss);




            ss = "{";
            list = TestSet12.clusterCompression(new int[] { -5, -5, -5, -5, -5 });
            for (int i = 0; i < list.Length; i++)
            {
                
                ss += string.Format("{0},", list[i]);
            }
            ss += "}";
            Console.Write("smallest of  {-5, -5, -5, -5, -5}  is"); Console.WriteLine(" = {0}", ss);



            ss = "{";
            list = TestSet12.clusterCompression(new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 });
            for (int i = 0; i < list.Length; i++)
            {
                
                ss += string.Format("{0},", list[i]);
            }
            ss += "}";
            Console.Write("smallest of  {1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1}  is"); Console.WriteLine(" = {0}", ss);



            ss = "{";
            list = TestSet12.clusterCompression(new int[] { 8, 8, 6, 6, -2, -2, -2 });
            for (int i = 0; i < list.Length; i++)
            {
                
                ss += string.Format("{0},", list[i]);
            }
            ss += "}";

            Console.Write("smallest of  {8, 8, 6, 6, -2, -2, -2}  is"); Console.WriteLine(" = {0}", ss);



            Console.WriteLine("========================");
        }

        public static void isRailroadTie()
        {
            Console.WriteLine("test for isRailroadTie ");
            Console.WriteLine("========================");

            Console.Write("isRailroadTie of   {1, 2, 0, 3, -18, 0, 2, 2}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1, 2, 0, 3, -18, 0, 2, 2 }));

            Console.Write("isRailroadTie of   {1, 2, 3, 0, 2, 2}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1, 2, 3, 0, 2, 2 }));


            Console.Write("isRailroadTie of   {0, 1, 2, 0, 3, 4}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 0, 1, 2, 0, 3, 4 }));

            Console.Write("isRailroadTie of   {1, 2, 0, 0, 3, 4}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1, 2, 0, 0, 3, 4 }));


            Console.Write("isRailroadTie of   {1}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1 }));

            Console.Write("isRailroadTie of   {}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { }));

            Console.Write("isRailroadTie of   {0}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 0 }));

            Console.Write("isRailroadTie of   {1, 2}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1, 2 }));

            Console.Write("isRailroadTie of   {1, 2, 0, 1, 2, 0, 1, 2}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1, 2, 0, 1, 2, 0, 1, 2 }));

            Console.Write("isRailroadTie of   {3, 3, 0, 3, 3, 0, 3, 3, 0, 3, 3}	  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 3, 3, 0, 3, 3, 0, 3, 3, 0, 3, 3 }));

            Console.Write("isRailroadTie of   {0, 0, 0, 0}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 0, 0, 0, 0 }));

            Console.Write("isRailroadTie of   {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            Console.Write("isRailroadTie of   {1, 3, 0, 3, 5, 0}  is"); Console.WriteLine(" = {0}"
             , TestSet12.isRailroadTie(new int[] { 1, 3, 0, 3, 5, 0 }));


            Console.WriteLine("========================");
        }
    }
}
