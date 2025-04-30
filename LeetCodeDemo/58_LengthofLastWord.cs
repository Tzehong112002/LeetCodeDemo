using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public static class _58_LengthofLastWord
    {
        static void Main(string[] args)
        {


            string str = "Hello World";
            string str2 = "   fly me   to   the moon  ";

            Console.WriteLine(LengthOfLastWord(str2));
        }

        #region Method 1
        //public static int LengthOfLastWord(string s)
        //{
        //    string str = "";          

        //    if (s == null) { 
        //        return 0;   
        //    }

        //    if (s.Any(char.IsWhiteSpace) == false) { 
        //        return s.Length;
        //    }

        //    for (int i = 0; i < s.Length; i++) {
        //        if (char.IsWhiteSpace(s[i]))
        //        {
        //            for (int j = i+1; j < s.Length; j++) {
        //                if (char.IsWhiteSpace(s[j])==false ) {
        //                    str = "";
        //                    break;
        //                }
        //            }

        //        }
        //        else {
        //            str = str + s[i];
        //        }
        //    }
        //    return str.Length;
        //}
        #endregion

        #region Method 2
        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            int length = 0;
            int i = s.Length - 1;

            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            return length;
        }

        #endregion

    }

}
