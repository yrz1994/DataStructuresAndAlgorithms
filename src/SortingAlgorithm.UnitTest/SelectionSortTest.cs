using SortingAlgorithm.Core;
using System;
using Xunit;

namespace SortingAlgorithm.UnitTest
{
    public class SelectionSortTest
    {
        [Fact]
        public void ShouldBeSorted()
        {
            //Arrange
            var sut = new SelectionSort(); //sut: system under test
            var array = new int[] { 5, 9, 6, 4, 1, 7, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0, 5, 9, 6, 4, 1, 7, 3, 8, 2, 0 };

            //Act
            var result = sut.Sort(array);

            //Assert
            Assert.Equal("0,0,0,0,0,0,1,1,1,1,1,1,1,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,6,6,6,6,6,6,7,7,7,7,7,7,8,8,8,8,8,8,9,9,9,9,9,9", string.Join(',', result));
        }

        [Fact]
        public void ShouldNotBeNull()
        {
            var sut = new SelectionSort();

            Assert.Throws<ArgumentNullException>(() => sut.Sort(null));
        }
    }
}
