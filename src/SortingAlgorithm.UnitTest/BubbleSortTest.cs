using SortingAlgorithm.Core;
using System;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace SortingAlgorithm.UnitTest
{
    public class BubbleSortTest
    {
        private readonly ITestOutputHelper _output;

        public BubbleSortTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [MemberData(nameof(SortData.TestData), MemberType = typeof(SortData))]
        public void ShouldInOrder(int[] input, string expect)
        {
            //Arrange
            var sut = new BubbleSort(); //sut: system under test

            //Act
            var result = sut.Sort(input);

            //Assert
            Assert.Equal(expect, string.Join(',', result));
        }

        [Theory]
        [MemberData(nameof(SortData.TestData), MemberType = typeof(SortData))]
        public void ShouldInOrderOptimized(int[] input, string expect)
        {
            //Arrange
            var sut = new BubbleSort(); //sut: system under test

            //Act
            var result = sut.OptimizedSort(input);

            //Assert
            Assert.Equal(expect, string.Join(',', result));
        }

        [Fact]
        public void ShouldInOrderLoop()
        {
            //Arrange
            var sut = new BubbleSort(); //sut: system under test
            var array = new int[] { 1,2,3,4,5,6,7,8,9,10 };

            //Act
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] result = null;
            for (var i = 0; i < 100000; i++)
            {
                result = sut.Sort(array);
            }
            stopwatch.Stop();
            _output.WriteLine($"BubbleSort finished in {stopwatch.ElapsedMilliseconds}ms.");

            stopwatch.Reset();
            stopwatch.Start();
            int[] optimizedResult = null;
            for (var i = 0; i < 100000; i++)
            {
                //this array is in order already
                optimizedResult = sut.OptimizedSort(array);
            }
            stopwatch.Stop();
            _output.WriteLine($"Optimized bubbleSort finished in {stopwatch.ElapsedMilliseconds}ms.");


            //Assert
            Assert.Equal("1,2,3,4,5,6,7,8,9,10", string.Join(',', result));
            Assert.Equal("1,2,3,4,5,6,7,8,9,10", string.Join(',', optimizedResult));
        }

        [Fact]
        public void ShouldNotBeNull()
        {
            var sut = new BubbleSort();

            Assert.Throws<ArgumentNullException>(() => sut.Sort(null));
            Assert.Throws<ArgumentNullException>(() => sut.OptimizedSort(null));
        }
    }
}
