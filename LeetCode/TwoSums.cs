using System;
using System.Collections.Generic;

namespace LeetCode
{
    class TwoSums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var output = TwoSumByTwoLoops(new int[] { 2, 7, 9, 11 }, 18);

            Console.WriteLine("[{0}]", string.Join(", ", output));

            Console.ReadLine();
        }

        #region BruteForce

        public static int[] TwoSumByTwoLoops(int[] nums, int target)
        {
            int[] add_list = new int[2];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        add_list[0] = i;
                        add_list[1] = j;
                    }
                }
            }
            return add_list;
        }

        #endregion

        #region Dictionary
        public static int[] TwoSumUsingDictionary(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                dict.Add(nums[i], i);
            }

            for (int i = 0; i < dict.Count; i++)
            {
                var ll = target - dict[i]
                if(dict.ContainsValue(target - dict[i]))
                {
                    var jj = dict[]
                }
            }
        }

        #endregion
    }
}
