using LeetCode.Core;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.UnitTest
{
    public class ClimbStairsTest
    {
        [Theory]
        [MemberData(nameof(MinCostClimbStairsData.TestData), MemberType = typeof(MinCostClimbStairsData))]
        public void LongestCommonSubstringLengthTest(int[] cost, int expect)
        {
            //Arrange
            var sut = new ClimbStairs(); //sut: system under test

            //Act
            var result = sut.MinCostClimbingStairs(cost);

            //Assert
            Assert.Equal(expect, result);
        }
    }
    public class MinCostClimbStairsData
    {
        private static readonly IEnumerable<object[]> _data = new List<object[]>()
        {
            new object[]{ new int[] { 0, 0, 0, 0 }, 0 },
            new object[]{ new int[] { 10, 15, 20 }, 15 },
            new object[]{ new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6 }
        };

        public static IEnumerable<object[]> TestData => _data;
    }
}
