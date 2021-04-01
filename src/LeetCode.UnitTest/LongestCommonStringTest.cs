using LeetCode.Core;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.UnitTest
{
    public class LongestCommonStringTest
    {
        [Theory]
        [MemberData(nameof(LongestCommonSubstringData.TestData), MemberType = typeof(LongestCommonSubstringData))]
        public void LongestCommonSubstringLengthTest(string a, string b, int expect)
        {
            //Arrange
            var sut = new LongestCommonString(); //sut: system under test

            //Act
            var result = sut.LongestCommonSubstringLength(a, b);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void LongestCommonSubsequenceTest()
        {
            //Arrange
            var sut = new LongestCommonString(); //sut: system under test

            //Act
            var result = sut.LongestCommonSubsequence("abcde", "ace");

            //Assert
            Assert.Equal(3, result);
        }
    }

    public class LongestCommonSubstringData
    {
        private static readonly IEnumerable<object[]> _data = new List<object[]>()
        {
            new object[]{ "", "", 0},
            new object[]{ null, null, 0},
            new object[]{ null, "", 0},
            new object[]{ "a", "a", 1},
            new object[]{ "abc", "cdabcf", 3},
            new object[]{ "abc", "caba", 2},
            new object[]{ "aaa1234567890000abcdefghigklmnopqrstuvwxyz", "aaa12345678900d00zabcdefghigklmnopqrstuvwxyz", 26},
            new object[]{ "aaaaaaaaaa1234567890bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb", "1111111111111123456789000000000000000", 10},
        };

        public static IEnumerable<object[]> TestData => _data;
    }
}
