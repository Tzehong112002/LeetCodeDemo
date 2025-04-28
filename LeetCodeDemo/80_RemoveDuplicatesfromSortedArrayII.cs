using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class _80_RemoveDuplicatesfromSortedArrayII
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int [] nums2 = { 0,0,1,1,1,1,2,3,3 };

            int k = RemoveDuplicates(nums);

            Console.WriteLine(k);
            for (int i = 0; i < k; i++)
            {
                Console.Write(nums[i] + " ");
            }

        }
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;

            int index = 2; 

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[index - 2])
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }
    }
}

        
    
