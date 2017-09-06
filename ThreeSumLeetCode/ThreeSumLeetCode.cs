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

            //int i = 0;
            //int j = 0;
            //int k = 0;
            //while (i < length - 2)
            //{
            //    j = i + 1;
            //    k = length - 1;
            //    while (j < k)
            //    {
            //        int threeSum = nums[i] + nums[j] + nums[k];
            //        if (threeSum == 0) result.Add(new List<int> { nums[i], nums[j], nums[k] });
            //        if (threeSum >= 0)
            //        {
            //            while (nums[k--] == nums[k] && j < k) ;
            //        }
            //        if (threeSum <=0)
            //        {
            //            while (nums[j] == nums[++j] && j < k) ;
            //        }
            //    }
            //    while (nums[i] == nums[++i] && i < length - 2) ;
            //}

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    for (int k = j + 1; k < length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> list = new List<int> { nums[i], nums[j], nums[k] };
                            list.Sort();
                            bool same = false;
                            foreach (var item in result)
                            {
                                if (item[0] != list[0])
                                    continue;
                                if (item[1] != list[1])
                                    continue;
                                if (item[2] != list[2])
                                    continue;
                                same = true;
                            }

                            if (!same)
                            {
                                result.Add(list);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
