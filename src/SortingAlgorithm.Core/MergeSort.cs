using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class MergeSort : IArraySort
    {
        /* 归并排序
         * 时间复杂度O(nlogn)，空间复杂度：O(n)，稳定排序
         * 最优时间复杂度：O(nlogn)
         * 最坏时间复杂度：O(nlogn)
         * 最佳解：有时是
         */
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            Sort(source, 0, source.Length - 1);
            return source;
        }

        private void Sort(int[] source, int first, int last)
        {
            if (first < last)
            {
                var mid = first + ((last - first) / 2);
                Sort(source, first, mid);
                Sort(source, mid + 1, last);
                Merge(source, first, mid, last);
            }
        }

        private void Merge(int[] source, int first, int mid, int last)
        {
            var merged = new int[last - first + 1];
            int leftHead = first, rightHead = mid + 1;
            for (var i = 0; i < merged.Length; i++)
            {
                if(leftHead > mid)
                {
                    merged[i] = source[rightHead];
                    rightHead++;
                }
                else if(rightHead > last)
                {
                    merged[i] = source[leftHead];
                    leftHead++;
                }
                else
                {
                    if (source[leftHead] <= source[rightHead])
                    {
                        merged[i] = source[leftHead];
                        leftHead++;
                    }
                    else
                    {
                        merged[i] = source[rightHead];
                        rightHead++;
                    }
                }
            }
            for(int i = first, j = 0; i <= last; i++, j++)
            {
                source[i] = merged[j];
            }
        }
    }
}
