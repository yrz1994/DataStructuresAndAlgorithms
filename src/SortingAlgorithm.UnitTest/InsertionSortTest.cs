﻿using SortingAlgorithm.Core;
using System;
using Xunit;
using Xunit.Abstractions;

namespace SortingAlgorithm.UnitTest
{
    public class InsertionSortTest
    {
        private readonly ITestOutputHelper _output;

        public InsertionSortTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [MemberData(nameof(SortData.TestData), MemberType =typeof(SortData))]
        public void ShouldBeSorted(int[] input, string expect)
        {
            //Arrange
            var sut = new InsertionSort(); //sut: system under test

            //Act
            var result = sut.Sort(input);
            _output.WriteLine(string.Join(',', result));

            //Assert
            Assert.Equal(expect, string.Join(',', result));
        }

        [Fact]
        public void ShouldNotBeNull()
        {
            var sut = new InsertionSort();

            Assert.Throws<ArgumentNullException>(() => sut.Sort(null));
        }
    }
}