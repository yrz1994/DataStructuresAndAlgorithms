using System;

namespace LeetCode.Core
{
    public class BurstBalloons
    {
        public int GetMaxCoins(int[] nums)
        {
            var n = nums.Length;
            var array = new int[n + 2];
            array[0] = 1;
            array[n + 1] = 1;
            for (var i = 1; i <= nums.Length; i++)
            {
                array[i] = nums[i - 1];
            }

            var dp = new int[n+2, n+2];
            for (var len = 3; len <= n+2; len++)
            {
                for (var i = 0; i <= n - len + 2; i++)
                {
                    var max = 0;
                    for (var j = i + 1; j < i + len - 1; j++)
                    {
                        max = Math.Max(max, dp[i, j] + dp[j, i + len - 1] + array[j] * array[i] * array[i + len - 1]);
                    }
                    dp[i, i + len - 1] = max;
                }
            }
            return dp[0,n+1];
        }
    }
}
