using SortingAlgorithm.Core;
using System;
using Xunit;

namespace SortingAlgorithm.UnitTest
{
    public class ShellSortTest
    {
        [Theory]
        [MemberData(nameof(SortData.TestData), MemberType = typeof(SortData))]
        public void ShouldBeSorted(int[] input, string expect)
        {
            //Arrange
            var sut = new ShellSort(); //sut: system under test

            //Act
            var result = sut.Sort(input);

            //Assert
            Assert.Equal(expect, string.Join(',', result));
        }

        [Fact]
        public void ShouldNotBeNull()
        {
            var sut = new ShellSort();

            Assert.Throws<ArgumentNullException>(() => sut.Sort(null));
        }
    }
}
