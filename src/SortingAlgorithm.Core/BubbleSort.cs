using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class BubbleSort : IArraySort
    {
        /* 冒泡排序
         * 时间复杂度O(N^2)，空间复杂度：O(1)，稳定排序
         * 最优情况：当前数组为正序数组，时间复杂度：O(N)
         * 最差情况：当前数组为逆序数组，时间复杂度：O(N^2)
         */
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = i + 1; j < source.Length; j++)
                {
                    if (source[i] > source[j])
                    {
                        source[i] = source[i] + source[j];
                        source[j] = source[i] - source[j];
                        source[i] = source[i] - source[j];
                    }
                }
            }
            return source;
        }

        /* 冒泡排序（优化）
         * 增加isSwap变量，如果source为正序数组，外层循环只需要执行一次
         */
        public int[] OptimizedSort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            var isSwap = false;
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = i + 1; j < source.Length; j++)
                {
                    if (source[i] > source[j])
                    {
                        source[i] = source[i] + source[j];
                        source[j] = source[i] - source[j];
                        source[i] = source[i] - source[j];
                        isSwap = true;
                    }
                }
                if (!isSwap) break;
            }
            return source;
        }
    }
}
