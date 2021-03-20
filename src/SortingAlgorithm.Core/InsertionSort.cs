using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class InsertionSort : IArraySort
    {
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (var i = 0; i < source.Length - 1; i++)
            {
                var current = source[i + 1];
                for (var j = i; j >= 0; j--)
                {
                    if (current < source[j])
                    {
                        source[j + 1] = source[j];
                        if(j == 0)
                        {
                            source[j] = current;
                        }
                    }
                    else
                    {
                        source[j + 1] = current;
                        break;
                    }
                }
            }
            return source;
        }
    }
}
