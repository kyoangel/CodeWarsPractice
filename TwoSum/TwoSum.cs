using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    public class TwoSumLeetCode
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            Hashtable map = new Hashtable();
            for (int i = 0; i < length; i++)
            {
                int anotherPair = target - nums[i];
                if (map.ContainsKey(anotherPair))
                {
                    return new int[] { (int)map[anotherPair], i };
                }
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }
            throw new System.ArgumentException("No two sum solution");
        }
    }
}
