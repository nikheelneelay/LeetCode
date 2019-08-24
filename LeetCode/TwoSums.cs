using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class TwoSums
    {
       

        #region BruteForce

        public static int[] TwoSumByTwoLoops(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }

        #endregion

        #region Dictionary
        public static int[] TwoSumUsingDictionary(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                var ll = target - nums[i];
                if (dict.ContainsValue(ll))
                {
                    return new int[] { dict.FirstOrDefault(x => x.Value == ll).Key, i };
                }
                dict.Add(i, nums[i]);
            }

            return new int[0];
        }

        #endregion
    }
}
