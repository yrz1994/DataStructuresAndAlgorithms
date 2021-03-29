using DataStructure.Core.BinaryTree;
using Xunit;

namespace DataStructure.UnitTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void ShouldByNull()
        {
            //Arrange
            var sut = new BuildBinary(); //sut: system under test
            var array = new int?[] { null };

            //Act
            var head = sut.CreateBinaryTree(array);

            //Assert
            Assert.Null(head);
        }

        [Fact]
        public void TestCreateBinaryTree()
        {
            //Arrange
            var sut = new BuildBinary(); //sut: system under test
            var array = new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Act
            var head = sut.CreateBinaryTree(array);

            //Assert
            Assert.Equal(1, head.Value);
            Assert.Equal(2, head.LeftChild.Value);
            Assert.Equal(3, head.RightChild.Value);
            Assert.Equal(4, head.LeftChild.LeftChild.Value);
            Assert.Equal(5, head.LeftChild.RightChild.Value);
            Assert.Equal(6, head.RightChild.LeftChild.Value);
            Assert.Equal(7, head.RightChild.RightChild.Value);
            Assert.Equal(8, head.LeftChild.LeftChild.LeftChild.Value);
            Assert.Equal(9, head.LeftChild.LeftChild.RightChild.Value);
            Assert.Equal(10, head.LeftChild.RightChild.LeftChild.Value);
        }

        [Fact]
        public void TestCreateBinaryTreeWithNull()
        {
            //Arrange
            var sut = new BuildBinary(); //sut: system under test
            var array = new int?[] {1, 2, 3, 4, null, 6, 7, 8, 9};

            //Act
            var head = sut.CreateBinaryTree(array);

            //Assert
            Assert.Equal(1, head.Value);
            Assert.Equal(2, head.LeftChild.Value);
            Assert.Equal(3, head.RightChild.Value);
        }

        /// <summary>
        /// ÖÐÐò±éÀú(µÝ¹é¡¢µü´ú)
        /// </summary>
        [Fact]
        public void TestMiddleOrderTraversal()
        {
            //Arrange
            var sut = new OrderTraversal(); //sut: system under test

            //Act
            var orderList1 = sut.InorderTraversal(new BuildBinary().CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            var orderList2 = sut.IterationInorderTraversal(new BuildBinary().CreateBinaryTree(new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            //Assert
            Assert.Equal("8,4,9,2,10,5,1,6,3,7", string.Join(",", orderList1));
            Assert.Equal("8,4,9,2,10,5,1,6,3,7", string.Join(",", orderList2));
        }


        /// <summary>
        /// ÏÈÐò±éÀú(µÝ¹é¡¢µü´ú)
        /// </summary>
        [Fact]
        public void TestPreOrderTraversal()
        {
            //Arrange
            var sut = new OrderTraversal(); //sut: system under test

            //Act
            var orderList1 = sut.PreOrderTraversal(new BuildBinary().CreateBinaryTree(new int?[] { 1, 2, 3, 4, null, 6, 7, 8, 9 }));
            var orderList2 = sut.IterationPreOrderTraversal(new BuildBinary().CreateBinaryTree(new int?[] { 1, 2, 3, 4, null, 6, 7, 8, 9 }));

            //Assert
            Assert.Equal("1,2,4,8,9,3,6,7", string.Join(",", orderList1));
            Assert.Equal("1,2,4,8,9,3,6,7", string.Join(",", orderList2));
        }

        /// <summary>
        /// ºóÐò±éÀú(µÝ¹é¡¢µü´ú)
        /// </summary>
        [Fact]
        public void TestPostOrderTraversal()
        {
            //Arrange
            var sut = new OrderTraversal(); //sut: system under test

            //Act
            var orderList1 = sut.PostOrderTraversal(new BuildBinary().CreateBinaryTree(new int?[] { 1, 2, 3, 4, null, 6, 7, 8, 9 }));
            var orderList2 = sut.IterationPostOrderTraversal(new BuildBinary().CreateBinaryTree(new int?[] { 1, 2, 3, 4, null, 6, 7, 8, 9 }));

            //Assert
            Assert.Equal("8,9,4,2,6,7,3,1", string.Join(",", orderList1));
            Assert.Equal("8,9,4,2,6,7,3,1", string.Join(",", orderList2));
        }
    }
}
