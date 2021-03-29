namespace DataStructure.Core.BinaryTree
{
    public class BinaryTreeFunction
    {
        public TreeNode CreateBinaryTree(int[] input)
        {
            if (input == null || input.Length == 0) return null;
            return CreateNode(input, 1);
        }

        private TreeNode CreateNode(int[] input, int current)
        {
            if (current > input.Length) return null;
            var head = new TreeNode(input[current-1]);
            head.LeftChild = CreateNode(input, current * 2);
            head.RightChild = CreateNode(input, current * 2 + 1);
            return head;
        }
    }
}
