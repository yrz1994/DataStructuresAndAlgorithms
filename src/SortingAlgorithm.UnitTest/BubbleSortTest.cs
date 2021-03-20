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

        [Fact]
        public void ShouldInOrder()
        {
            //Arrange
            var sut = new BubbleSort(); //sut: system under test

            //Act
            var result = sut.Sort(new int[] { 3, 1, 2, 0, 9, 5, 8 });
            var optimizedResult = sut.OptimizedSort(new int[] { 3, 1, 2, 0, 9, 5, 8 });

            //Assert
            Assert.Equal("0,1,2,3,5,8,9", string.Join(',', result));
            Assert.Equal("0,1,2,3,5,8,9", string.Join(',', optimizedResult));
        }

        [Fact]
        public void ShouldInOrderWithLargeArray()
        {
            //Arrange
            var sut = new BubbleSort(); //sut: system under test
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
            _output.WriteLine($"BubbleSort finished in {stopwatch.ElapsedMilliseconds}ms.");

            stopwatch.Reset();
            stopwatch.Start();
            int[] optimizedResult = null;
            for (var i = 0; i < 10000; i++)
            {
                //this array is in order already
                optimizedResult = sut.OptimizedSort(array);
            }
            stopwatch.Stop();
            _output.WriteLine($"Optimized bubbleSort finished in {stopwatch.ElapsedMilliseconds}ms.");


            //Assert
            Assert.Equal("0,0,0,0,0,0,1,1,1,1,1,1,1,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,6,6,6,6,6,6,7,7,7,7,7,7,8,8,8,8,8,8,9,9,9,9,9,9", string.Join(',', result));
            Assert.Equal("0,0,0,0,0,0,1,1,1,1,1,1,1,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,6,6,6,6,6,6,7,7,7,7,7,7,8,8,8,8,8,8,9,9,9,9,9,9", string.Join(',', optimizedResult));
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
