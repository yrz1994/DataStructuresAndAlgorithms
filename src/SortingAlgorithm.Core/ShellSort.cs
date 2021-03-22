using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class ShellSort : IArraySort
    {
        /* 希尔排序
         * 时间复杂度：根据步长序列的不同而不同，空间复杂度：O(1)，不稳定排序
         * 最优时间复杂度：O(n)
         * 最差时间复杂度：根据步长序列的不同而不同，已知最好：O(nlog^2n)
         * 非最佳算法
         */
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (var gap = source.Length / 2; gap > 0; gap /= 2)
            {
                for (var i = gap; i < source.Length; i++)
                {
                    var temp = source[i];
                    var j = i - gap;
                    while (j >= 0 && source[j] > temp)
                    {
                        source[j + gap] = source[j];
                        j -= gap;
                    }
                    source[j + gap] = temp;
                }
            }
            return source;
        }
    }
}
