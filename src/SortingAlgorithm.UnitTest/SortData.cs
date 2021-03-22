using System.Collections.Generic;

namespace SortingAlgorithm.UnitTest
{
    public class SortData
    {
        private static readonly IEnumerable<object[]> _sortData = new List<object[]>()
        {
             new object[]{ new int[] { 42 }, "42"},
            new object[]{ new int[] { 3,1,2,5,4 }, "1,2,3,4,5"},
            new object[]{ new int[] { 3,1,2,5,6,2,4,1,9999999,123,0 }, "0,1,1,2,2,3,4,5,6,123,9999999"},
            new object[]{ new int[] { 1,2,3,4,5,6,7,8,9,10 }, "1,2,3,4,5,6,7,8,9,10"},
            new object[]{ new int[] { 10,9,8,7,6,5,4,3,2,1 }, "1,2,3,4,5,6,7,8,9,10"},
            new object[]{
                new int[] { 5, 9, 6, 4, 1, 7, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0 },
                "0,0,0,0,0,0,1,1,1,1,1,1,1,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,6,6,6,6,6,6,7,7,7,7,7,7,8,8,8,8,8,8,9,9,9,9,9,9"
            }
        };

        public static IEnumerable<object[]> TestData => _sortData;
    }
}
