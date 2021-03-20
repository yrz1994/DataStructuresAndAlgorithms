using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class SelectionSort : IArraySort
    {
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (var i = 0; i < source.Length; i++)
            {
                var small = i;
                for (var j = i + 1; j < source.Length; j++)
                {
                    if (source[j] < source[small])
                    {
                        small = j;
                    }
                }
                var temp = source[i];
                source[i] = source[small];
                source[small] = temp;
            }
            return source;
        }
    }
}
