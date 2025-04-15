using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            
            Merge(nums1, m, nums2, n);


            //printf Line
            Console.WriteLine(string.Join(", ", nums1));
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            #region Answer 1
            //merge method
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            #endregion

            #region Answer 2

            //merge method 2
            //method 2 , assign a new array , need to use pointer only can modify the value from outside
            //orElse need create a new aaray  , then pass one by one to the ald array

            //int [] combineArray = nums1.Take(m).Concat(nums2.Take(n)).ToArray();

            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    nums1[i] = combineArray[i];
            //}
            #endregion

            //sort array
            Array.Sort(nums1);


        }
    }
}
