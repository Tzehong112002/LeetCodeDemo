using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class _14_LongestCommonPrefix
    {

        static void Main(string[] args)
        {
            string[] array1 = {"flower", "flow", "flight"};


            Console.WriteLine(LongestCommonPrefix(array1));

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string str = "";

            if (strs == null || strs.Length == 0) {
                return "";
            }

            for (int i = 0; i < strs[0].Length; i++) {
                char ch = strs[0][i];

                for (int j = 0; j < strs.Length; j++){
                    if ( i>= strs[j].Length || strs[j][i] != ch)
                    {
                        return str;
                    }
                             
                }
                str += strs[0][i];
            }
            return str;        
        }
    }
}
