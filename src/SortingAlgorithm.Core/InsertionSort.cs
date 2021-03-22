using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class InsertionSort : IArraySort
    {
        /* 插入排序
         * 时间复杂度O(n^2)，空间复杂度：O(1)，稳定排序
         * 最优情况：当前数组为正序数组，时间复杂度：O(n)
         * 最差情况：当前数组为逆序数组，时间复杂度：O(n^2)
         * 最佳解：非最佳算法
         */
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (var i = 1; i < source.Length; i++)
            {
                for (int j = i; j > 0 && source[j] < source[j - 1]; j--)
                {
                    source[j - 1] = source[j] + source[j - 1];
                    source[j] = source[j - 1] - source[j];
                    source[j - 1] = source[j - 1] - source[j];
                }
            }
            return source;
        }
    }
}
