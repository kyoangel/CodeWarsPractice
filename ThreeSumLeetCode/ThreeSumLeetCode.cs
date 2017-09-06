using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumLeetCode
{
    public class ThreeSumLeetCode
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            int length = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            int i = 0;
            int j = 0;
            int k = 0;
            while (i < length - 2)
            {
                j = i + 1;
                k = length - 1;
                while (j < k)
                {
                    int threeSum = nums[i] + nums[j] + nums[k];
                    if (threeSum == 0) result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    if (threeSum >= 0)
                    {
                        while (nums[k--] == nums[k] && j < k) ;
                    }
                    if (threeSum <= 0)
                    {
                        while (nums[j] == nums[++j] && j < k) ;
                    }
                }
                while (nums[i] == nums[++i] && i < length - 2) ;
            }
            return result;
        }
    }
}
