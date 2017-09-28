using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    public class TwoSumLeetCode
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var targetPair = new int[2];
            int length = nums.Length;
            Dictionary<int,int> map = new Dictionary<int, int>();
            for (int i = 0; i < length; i++)
            {
                int anotherPair = target - nums[i];
                if (map.ContainsKey(anotherPair))
                {
                    return new int[] { map[anotherPair], i };
                }
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }
            return targetPair;
        }
    }
}
