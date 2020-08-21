using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a word is a palindrome: ");
            string word = "Ababa";
            Console.WriteLine("{0} is {1}a palindrome", word, IsPalindrome(word) == true ? "" : "not ") ;

            Console.ReadKey();
        }

        private static bool IsPalindrome(string word)
        {
            //var arr = word.ToLower().ToCharArray();
            //var lengthOfArray = arr.Length;
            //var halfLengthOfArray = arr.Length/2;
            
            var arr = word.ToLower();
            //var lengthOfArray = word.Length;
            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i] != arr[arr.Length - i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
