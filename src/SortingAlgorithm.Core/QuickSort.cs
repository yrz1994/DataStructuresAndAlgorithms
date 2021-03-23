using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    /* 快速排序
     * 平均时间复杂度：O(nlogn)
     * 空间复杂度：根据实现的方式不同而不同，最佳情况O(nlog)
     * 不稳定排序
     * 最优情况时间复杂度：O(nlogn)
     * 最坏情况时间复杂度：O(n^2)
     * 最佳解：	有时是
     */
    public class QuickSort : IArraySort
    {
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            if (source.Length <= 1) return source;
            DoSort(source, 0, source.Length - 1);
            return source;
        }

        public void DoSort(int[] source, int first, int last)
        {
            if (first >= last) return;
            int i = first, j = last;
            var key = source[first];
            bool isSearchFront = true;
            while (i < j)
            {
                if (isSearchFront)
                {
                    if (source[j] < key)
                    {
                        source[i] = source[j];
                        source[j] = key;
                        isSearchFront = false;
                    }
                    else
                    {
                        j--;
                    }
                }
                else
                {
                    if (source[i] > key)
                    {
                        source[j] = source[i];
                        source[i] = key;
                        isSearchFront = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            DoSort(source, first, i);
            DoSort(source, i + 1, last);

        }
    }
}
