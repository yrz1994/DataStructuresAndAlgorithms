using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class SelectionSort : IArraySort
    {
        /* 选择排序
         * 时间复杂度O(n^2)，空间复杂度：O(1)，不稳定排序
         * 最优情况：时间复杂度：O(n^2)
         * 最差情况：时间复杂度：O(n^2)
         * 最佳解：偶尔出现
         */
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (var i = 0; i < source.Length; i++)
            {
                var smallest = i;
                for (var j = i + 1; j < source.Length; j++)
                {
                    if (source[j] < source[smallest])
                    {
                        smallest = j;
                    }
                }

                if(smallest != i)
                {
                    source[i] = source[i] + source[smallest];
                    source[smallest] = source[i] - source[smallest];
                    source[i] = source[i] - source[smallest];
                }
            }
            return source;
        }
    }
}
