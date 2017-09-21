using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataContainsDuplicate2
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length < 2)
                return false;

            var dictionary = new Dictionary<int, int>();
            var dup_dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
                else
                {
                    if (dup_dictionary.ContainsKey(nums[i]))
                    {
                        
                        if (Math.Abs(dictionary[nums[i]] - dup_dictionary[nums[i]]) > Math.Abs(i - dup_dictionary[nums[i]]))
                        {
                            dictionary.Remove(nums[i]);
                            dictionary.Add(nums[i], i);
                        }
                    }
                    else
                    {
                        dup_dictionary.Add(nums[i], i);
                    }
                }

            }

            if (dup_dictionary.Count == 0)
                return false;
            else
            {
                foreach (var item in dup_dictionary)
                {
                    if (Math.Abs(item.Value - dictionary[item.Key]) > k)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
