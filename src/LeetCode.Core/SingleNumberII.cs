using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Core
{
    //LC.137 只出现一次的数字 II
    public class SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>(nums.Length);
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = dict[nums[i]] + 1;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }
            return dict.First(e => e.Value == 1).Key;
        }

        public int SingleNumber2(int[] nums)
        {
            int i = 0, j = 0;
            while (i < nums.Length && j < nums.Length)
            {
                if (i != j && nums[i] == nums[j])
                {
                    i++;
                    j = 0;
                }
                else
                {
                    j++;
                }
            }
            return nums[i];
        }
    }
}
