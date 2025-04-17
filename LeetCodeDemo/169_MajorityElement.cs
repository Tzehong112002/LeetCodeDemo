using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class _169MajorityElement
    {

        //static void Main(string[] args)
        //{
        //    int[] num1 = { 2, 2, 1, 1, 1, 2, 2 };
        //    int[] num2 = { 3, 2, 3 };
        //    int[] num3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int[] num4 = { 3,3,4 };

        //    Console.WriteLine("Majority Element: " + MajorityElement(num4));

        //}

        #region Method_1
        public static int MajorityElement(int[] nums)
        {
            float frequency  = nums.Length/2f;
            int count = 1;
            int majorityElement = 0;

            Array.Sort(nums);
            int currentElement = nums[0]; 
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == currentElement) {
                    count++;
                }else
                {
                    //reset element
                    currentElement = nums[i];
                    count = 1;
                }

                if (count > frequency) { break; }
            }

            //get majorifty elemnt
            if (count > frequency)
            {
                majorityElement = currentElement;
            }
            return majorityElement;
        }

        #endregion
    }
}

