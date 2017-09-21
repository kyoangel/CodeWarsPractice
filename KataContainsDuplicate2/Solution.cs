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

            var keyIndexPairMap = new Dictionary<int, int>();
            var duplicatedKeyIndexPairMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyIndexPairMap.ContainsKey(nums[i]))
                {
                    keyIndexPairMap.Add(nums[i], i);
                }
                else
                {
                    if (duplicatedKeyIndexPairMap.ContainsKey(nums[i]))
                    {
                        KeepMinIndexDistance(nums, keyIndexPairMap, duplicatedKeyIndexPairMap, i);
                    }
                    else
                    {
                        duplicatedKeyIndexPairMap.Add(nums[i], i);
                    }
                }

            }

            if (IsNoDuplicateElement(duplicatedKeyIndexPairMap))
                return false;
            else
            {
                foreach (var item in duplicatedKeyIndexPairMap)
                {
                    if (Math.Abs(item.Value - keyIndexPairMap[item.Key]) > k)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void KeepMinIndexDistance(int[] nums, Dictionary<int, int> keyIndexPairMap, Dictionary<int, int> duplicatedKeyIndexPairMap, int i)
        {
            if (Math.Abs(keyIndexPairMap[nums[i]] - duplicatedKeyIndexPairMap[nums[i]]) > Math.Abs(i - duplicatedKeyIndexPairMap[nums[i]]))
            {
                keyIndexPairMap.Remove(nums[i]);
                keyIndexPairMap.Add(nums[i], i);
            }
        }

        private static bool IsNoDuplicateElement(Dictionary<int, int> duplicatedKeyIndexPairMap)
        {
            return duplicatedKeyIndexPairMap.Count == 0;
        }
    }
}
