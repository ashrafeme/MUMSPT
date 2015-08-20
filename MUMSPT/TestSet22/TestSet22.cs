using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet22
{
   public static class TestSet22
    {
        /// <summary>
        /// A hodder number is one that is prime and is 
        /// equal to 2j-1 for some j. For example, 31 is 
        /// a hodder number because 31 is prime and is 
        /// equal to 25-1 (in this case j = 5). 
        /// The first 4 hodder numbers are 3, 7, 31, 127
        /// Write a function with signature int isHodder(int n) 
        /// that returns 1 if n is a hodder number, otherwise it returns 0.
        /// Recall that a prime number is a 
        /// whole number greater than 1 that has 
        /// only two whole number factors, itself and 1.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int isHodder(int n)
        {
            int isHodder = 0;

            int calculated = 0, j = 0;
            if (Helper.isPrime(n))
            {
                do
                {
                    calculated = ((int)Math.Pow(2, j)) - 1;
                    if (calculated == n)
                        isHodder = 1;
                    j++;
                } while (calculated <= n && isHodder == 0);
            }

            return isHodder;
        }


        /// <summary>
        /// One word is an anagram of another word 
        /// if it is a rearrangement of all the letters 
        /// of the second word. For example, the character 
        /// arrays {‘s’, ‘i’, ‘t’} and {‘i’, ‘t’, ‘s’} 
        /// represent words that are anagrams of one 
        /// another because “its” is a rearrangement of 
        /// all the letters of “sit” and vice versa. 
        /// Write a function that accepts two character 
        /// arrays and returns 1 if they are anagrams 
        /// of one another, otherwise it returns 0. 
        /// For simplicity, if the two input character 
        /// arrays are equal, you may consider them 
        /// to be anagrams.
        /// If you are programming in Java or C#, the function signature is:       
        /// int areAnagrams(char[] a1, char[] a2)
        /// Hint: Please note that “pool” is not an anagram of 
        /// “poll” even though they use the same letters. 
        /// Please be sure that your function returns 0 if given these two words! 
        /// You can use another array to keep track of each 
        /// letter that is found so that you don’t count the same letter 
        /// twice (e.g., the attempt to find the second “o” of “pool” in “poll” should fail.)
        /// Hint: do not modify either a1 or a2, i.e., 
        /// your function should have no side effects! 
        /// If your algorithm requires modification of 
        /// either of these arrays, you must work with a 
        /// copy of the array and modify the copy!
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static int areAnagrams(char[] a1, char[] a2)
        {
            int areAnagrams = 1;

            int[] isFound = new int[a1.Length];
            for (int i = 0; i < a1.Length && areAnagrams==1; i++)
            {
                int elindex = Helper.isExistInArray(a2, a1[i]);
                if (elindex != -1)
                {
                    
                    isFound[i] = elindex;
                }
                else
                {
                    areAnagrams = 0; 
                }
            }
            return areAnagrams;
        }


        /// <summary>
        /// Solved in TestSet11
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int closestFibonacci(int n)
        {
            return TestSet11.TestSet11.closestFibonacci(n);
        }
    }
}
