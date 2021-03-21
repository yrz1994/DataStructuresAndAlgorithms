using SortingAlgorithm.Core;
using System;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace SortingAlgorithm.UnitTest
{
    public class ShellSortTest
    {
        private readonly ITestOutputHelper _output;

        public ShellSortTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [MemberData(nameof(SortData.TestData), MemberType = typeof(SortData))]
        public void ShouldBeSorted(int[] input, string expect)
        {
            //Arrange
            var sut = new ShellSort(); //sut: system under test

            //Act
            var result = sut.Sort(input);
            _output.WriteLine(string.Join(',', result));

            //Assert
            Assert.Equal(expect, string.Join(',', result));
        }

        [Fact]
        public void ShouldInOrderWithLargeArray()
        {
            //Arrange
            var sut = new ShellSort(); //sut: system under test
            var array = new int[] { 5, 9, 6, 4, 1, 7, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0 };

            //Act
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] result = null;
            for (var i = 0; i < 10000; i++)
            {
                result = sut.Sort(array);
            }
            stopwatch.Stop();
            _output.WriteLine($"ShellSort finished in {stopwatch.ElapsedMilliseconds}ms.");

            //Assert
            Assert.Equal("0,0,0,0,0,0,1,1,1,1,1,1,1,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,6,6,6,6,6,6,7,7,7,7,7,7,8,8,8,8,8,8,9,9,9,9,9,9", string.Join(',', result));
        }

        [Fact]
        public void ShouldNotBeNull()
        {
            var sut = new ShellSort();

            Assert.Throws<ArgumentNullException>(() => sut.Sort(null));
        }
    }
}
