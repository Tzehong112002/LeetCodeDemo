using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public  class _26_RemoveDuplicatesfromSortedArray
    {
        //static void Main(string[] args)
        //{
        //    int[] num1 = { 1, 0, 2 };
        //    int[] num2 = { 0, 0, 1, 1, 2, 2, 3, 4 };
        //    int[] num3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int[] num4 = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9 };

        //    Console.WriteLine("Unique Count: " + RemoveDuplicates(num1));
        //    Console.WriteLine(string.Join(", ", num1));

        //}

        #region Method 1
        //public static int RemoveDuplicates(int[] nums)
        //{
        //    int num = 0;
        //    int[] tempArray = new int[nums.Length];
        //    bool zeroValue = false;

        //    for (int i = 0; i < nums.Length; i++)
        //    {

        //        for (int j = 0; j < tempArray.Length; j++)
        //        {

        //            if (nums[i] == 0 && tempArray[j] == 0 && zeroValue==false) {
        //                zeroValue = true;
        //                tempArray[num] = nums[i];
        //                nums[num] = tempArray[num];
        //                num++;
        //                break;
        //            }
        //            if (nums[i] != tempArray[j])
        //            {
        //                if (j == tempArray.Length-1)
        //                {
        //                    tempArray[num] = nums[i];
        //                    nums[num] = tempArray[num];
        //                    num++;
        //                }
        //            }
        //            else {
        //                break;
        //            }
        //        }
        //    }

        //    return num;
        //}

        #endregion

        #region method 2
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int index = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }
        #endregion



    }
}

