using DataStructure.Core.BinaryTree;
using Xunit;

namespace DataStructure.UnitTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void TestCreateBinaryTree()
        {
            //Arrange
            var sut = new BinaryTreeFunction(); //sut: system under test
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Act
            var head = sut.CreateBinaryTree(array);

            //Assert
            Assert.Equal(1, head.Value);
            Assert.Equal(2, head.LeftChild.Value);
            Assert.Equal(7, head.RightChild.RightChild.Value);
        }
    }
}
