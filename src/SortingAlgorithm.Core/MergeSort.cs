using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class MergeSort : IArraySort
    {
        /* 归并排序
         * 时间复杂度O(NlogN)，空间复杂度：O(N)，稳定排序
         */
        public int[] Sort(int[] source)
        {
            throw new NotImplementedException();
            //if (source == null) throw new ArgumentNullException();
            //Sort(source, 0, source.Length - 1);
            //return source;
        }

        //private void Sort(int[] source, int first, int last)
        //{
        //    if(first < last)
        //    {
        //    }
        //}

        //public int[] Merge(int[] array1, int[] array2)
        //{
        //    var merged = new int[array1.Length + array2.Length];

        //    return merged;
        //}
    }
}
