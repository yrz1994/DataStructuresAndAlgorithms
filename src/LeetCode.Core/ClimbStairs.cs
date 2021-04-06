using System;

namespace LeetCode.Core
{
    public class ClimbStairs
    {
        /// <summary>
        /// 使用最小花费爬楼梯
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost == null || cost.Length < 2) return 0;
            int[] dp = new int[cost.Length + 1];
            for(var i = 2; i <= cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }
            return dp[cost.Length];
        }
    }
}
