using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class BubbleSort : IArraySort
    {
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = i + 1; j < source.Length; j++)
                {
                    if (source[i] > source[j])
                    {
                        int temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                    }
                }
            }
            return source;
        }

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
                        int temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                        isSwap = true;
                    }
                }
                if (!isSwap) break;
            }
            return source;
        }
    }
}
