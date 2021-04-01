using System;
using System.Collections.Generic;

namespace LeetCode.Core
{
    public class ThreeSum
    {
        /// <summary>
        /// 三数之和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> GetThreeSum(int[] nums)
        {
            var threeSum = new List<IList<int>>();
            if (nums == null || nums.Length < 3) return threeSum;
            Array.Sort(nums);
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int j = i + 1, k = nums.Length - 1;
                while (j < k)
                {
                    if (nums[j] + nums[k] < -nums[i])
                    {
                        j++;
                    }
                    else if (nums[j] + nums[k] > -nums[i])
                    {
                        k--;
                    }
                    else
                    {
                        threeSum.Add(new List<int> { nums[i], nums[j], nums[k] });
                        while (j < k && nums[j] == nums[j + 1])
                        {
                            j++;
                        }
                        while (j < k && nums[k] == nums[k - 1])
                        {
                            k--;
                        }
                        j++;
                        k--;
                    }
                }
            }
            return threeSum;
        }
    }
}
