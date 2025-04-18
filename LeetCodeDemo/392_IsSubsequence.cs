using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class _392_IsSubsequence
    {
        //static void Main(string[] args)
        //{
        //    String s = "abc";
        //    string t = "ahbgdc";

        //    Console.WriteLine(IsSubsequence(s, t));


        //}

        #region Method1
        public static bool IsSubsequence(string s, string t)
        {
            //if s is empty
            if (s.Length == 0){return true;}
            //if t is empty & s is not empty
            if (t.Length == 0) { return false; }


            int sIndex = 0;
            int tIndex = 0;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }
            // If we have reached the end of s, it means all characters were found in t
            // in the correct order.
            if (sIndex == s.Length)
            {
                return true;
            }
            // If we have not reached the end of s, it means not all characters were found in t
            // in the correct order.
            else
            {
                return false;
            }
        }

        #endregion
    }
}
