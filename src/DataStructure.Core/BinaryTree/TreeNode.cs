namespace DataStructure.Core.BinaryTree
{
    public class TreeNode
    {
        public TreeNode() { }

        public TreeNode(int value)
        {
            Value = value;
        }

        public TreeNode(int value, TreeNode left, TreeNode right)
        {
            Value = value;
            LeftChild = left;
            RightChild = right;
        }

        public int Value { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }
    }
}
