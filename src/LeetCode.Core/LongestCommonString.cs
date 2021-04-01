using System;

namespace LeetCode.Core
{
    public class LongestCommonString
    {
        /// <summary>
        /// 最长公共子串
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int LongestCommonSubstringLength(string a, string b)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b)) return 0;
            var arrayA = a.ToCharArray();
            var arrayB = b.ToCharArray();
            int[,] table = new int[a.Length, b.Length];
            var sum = 0;
            for (int j = 0; j < arrayB.Length; j++)
            {
                for (int i = 0; i < arrayA.Length; i++)
                {
                    if (arrayA[i] == arrayB[j])
                    {
                        table[i, j] = (i == 0 || j == 0) ? 1 : table[i - 1, j - 1] + 1;
                        sum = Math.Max(sum, table[i, j]);
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// 最长公共子序列
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        public int LongestCommonSubsequence(string text1, string text2)
        {
            if (string.IsNullOrWhiteSpace(text1) || string.IsNullOrWhiteSpace(text2)) return 0;
            int[,] table = new int[text1.Length + 1, text2.Length + 1];
            var sum = 0;
            for (int j = 1; j <= text2.Length; j++)
            {
                for (int i = 1; i <= text1.Length; i++)
                {
                    if (text1[i-1] == text2[j-1])
                    {
                        table[i, j] = table[i - 1, j - 1] + 1;
                        sum = Math.Max(sum, table[i, j]);
                    }
                    else
                    {
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
                    }
                }
            }
            return sum;
        }
    }
}
