using SortingAlgorithm.Core.Interface;
using System;

namespace SortingAlgorithm.Core
{
    public class ShellSort : IArraySort
    {
        public int[] Sort(int[] source)
        {
            if (source == null) throw new ArgumentNullException();
            for (int gap = source.Length / 2; gap > 0; gap = gap / 2)
            {
                for (var i = gap; i < source.Length; i++)
                {
                    var j = i;
                    var current = source[i];
                    while (j - gap >= 0 && current < source[j - gap])
                    {
                        source[j] = source[j - gap];
                        j = j - gap;
                    }
                    source[j] = current;
                }
            }
            return source;
        }
    }
}
