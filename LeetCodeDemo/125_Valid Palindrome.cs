using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    internal class _125_Valid_Palindrome
    {
        //static void Main(string[] args)
        //{
        //    string Sentences1 = "A man, a plan, a canal: Panama";
        //    string Sentences2 = "race a car";
        //    string Sentences3 = " ";


        //    Console.WriteLine("Is Palindrome: " + IsPalindrome(Sentences2));


        //}

        #region Method1
        public static bool IsPalindrome(string s)
        {
            // Remove non-alphanumeric characters and convert to lowercase
            s = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
            int left = 0;
            int right = s.Length - 1;

            // Check for palindrome
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        #endregion


    }
}
