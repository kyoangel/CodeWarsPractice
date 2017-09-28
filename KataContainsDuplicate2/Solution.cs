using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataContainsDuplicate2
{
    public class Solution
    {
        private Dictionary<int, int> _keyIndexPairMap = new Dictionary<int, int>();
        private Dictionary<int, int> _duplicatedKeyIndexPairMap = new Dictionary<int, int>();

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length < 2)
                return false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!_keyIndexPairMap.ContainsKey(nums[i]))
                {
                    _keyIndexPairMap.Add(nums[i], i);
                }
                else
                {
                    if (_duplicatedKeyIndexPairMap.ContainsKey(nums[i]))
                    {
                        KeepMinIndexDistance(nums[i], i);
                    }
                    else
                    {
                        _duplicatedKeyIndexPairMap.Add(nums[i], i);
                    }
                }

            }

            if (IsNoDuplicateElement())
                return false;
            else
            {
                foreach (var item in _duplicatedKeyIndexPairMap)
                {
                    if (Math.Abs(item.Value - _keyIndexPairMap[item.Key]) > k)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void KeepMinIndexDistance(int key, int i)
        {
            if (Math.Abs(_keyIndexPairMap[key] - _duplicatedKeyIndexPairMap[key]) > Math.Abs(i - _duplicatedKeyIndexPairMap[key]))
            {
                _keyIndexPairMap.Remove(key);
                _keyIndexPairMap.Add(key, i);
            }
        }

        private bool IsNoDuplicateElement()
        {
            return !_duplicatedKeyIndexPairMap.Any();
        }
    }
}
