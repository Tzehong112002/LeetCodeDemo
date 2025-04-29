using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class _28_FindtheIndexoftheFirstOccurrenceinaString
    {

        static void Main(string[] args)
        {

            string haystack = "butbutsad";
            string needla = "sad";

            Console.WriteLine(StrStr(haystack, needla));
        }

        public static int StrStr(string haystack, string needle)
        {


            if (needle == "") {
                return 0;
            }
            if (haystack == null || needle.Length > haystack.Length) {
                return -1;
            }

            for (int i = 0; i <= haystack.Length-needle.Length; i++) {
                int j;
                for ( j = 0; j < needle.Length; j++) {
                    if (haystack[i + j] != needle[j]) { 

                        break;
                    }
                }
                if (j == needle.Length)
                {
                    return i;
                }

            }

           
            return -1;

        }
    }
}

