using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace LeetCodeDemo
{
    public  class _27
    {
        //static void Main(string[] args)
        //{
        //    int[] num3 = { 3, 2, 2, 3 };
        //    int val3 = 3;

        //    int newLength = RemoveElement(num3, val3);

        //    Console.WriteLine("New array length: " + newLength);
        //    Console.Write("Modified array: ");
        //    for (int i = 0; i < newLength; i++)
        //    {
        //        Console.Write(num3[i] + " ");
        //    }
        //}


        public static int RemoveElement(int[] nums, int val)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }
    }
}
