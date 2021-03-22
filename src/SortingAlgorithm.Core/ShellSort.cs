using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class ShellSort : IArraySort
    {
        /* 希尔排序
         * 时间复杂度O(N3/2)，空间复杂度：O(1)，不稳定排序
         * 最优情况：时间复杂度：O(N*log2N)
         * 最差情况：时间复杂度：O(N3/2)
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
