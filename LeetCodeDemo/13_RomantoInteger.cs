using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class _13_RomantoInteger
    { 
        //static void Main(string[] args)
        //{
        //    string str1 = "III";
        //    string str2 = "LVIII";

        //    Console.WriteLine(RomanToInt(str1));

        //}

        #region Method1
        public static int RomanToInt(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if (i + 1 < s.Length && s[i + 1] == 'V')
                        {
                            count = count + 4;
                            i++;

                        }
                        else if (i + 1 < s.Length && s[i + 1] == 'X')
                        {
                            count = count + 9;
                            i++;
                        }
                        else { count = count + 1; }

                        break;
                    case 'V':
                        count = count + 5;
                        break;
                    case 'X':
                        if (i + 1 < s.Length && s[i + 1] == 'L')
                        {
                            count = count + 40;
                            i++;

                        }
                        else if (i + 1 < s.Length && s[i + 1] == 'C')
                        {
                            count = count + 90;
                            i++;
                        }
                        else { count = count + 10; }


                        break;
                    case 'L':
                        count = count + 50;
                        break;
                    case 'C':
                        if (i + 1 < s.Length && s[i + 1] == 'D')
                        {
                            count = count + 400;
                            i++;

                        }
                        else if (i + 1 < s.Length && s[i + 1] == 'M')
                        {
                            count = count + 900;
                            i++;
                        }
                        else { count = count + 100; }
                        break;
                    case 'D':
                        count = count + 500;
                        break;
                    case 'M':
                        count = count + 1000;
                        break;

                }
            }


            return count;
        }
        #endregion

        #region Method2
        //public static int RomanToInt(string s)
        //{
        //    int total = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        int value = 0;
        //        switch (s[i])
        //        {
        //            case 'I': value = 1; break;
        //            case 'V': value = 5; break;
        //            case 'X': value = 10; break;
        //            case 'L': value = 50; break;
        //            case 'C': value = 100; break;
        //            case 'D': value = 500; break;
        //            case 'M': value = 1000; break;
        //        }

        //        if (i + 1 < s.Length)
        //        {
        //            int nextValue = 0;
        //            switch (s[i + 1])
        //            {
        //                case 'I': nextValue = 1; break;
        //                case 'V': nextValue = 5; break;
        //                case 'X': nextValue = 10; break;
        //                case 'L': nextValue = 50; break;
        //                case 'C': nextValue = 100; break;
        //                case 'D': nextValue = 500; break;
        //                case 'M': nextValue = 1000; break;
        //            }

        //            if (value < nextValue)
        //            {
        //                total -= value;
        //            }
        //            else
        //            {
        //                total += value;
        //            }
        //        }
        //        else
        //        {
        //            total += value;
        //        }
        //    }

        //    return total;
        //}
        #endregion

    }

}
