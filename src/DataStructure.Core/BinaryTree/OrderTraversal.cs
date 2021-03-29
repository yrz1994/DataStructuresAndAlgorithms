using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Core.BinaryTree
{
    public class OrderTraversal
    {
        #region>中序遍历

        /// <summary>
        /// 中序递归遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            Inorder(result, root);
            return result;
        }

        /// <summary>
        /// 递归遍历
        /// </summary>
        /// <param name="list"></param>
        /// <param name="root"></param>
        private void Inorder(List<int> list, TreeNode root)
        {
            if (root.LeftChild != null) Inorder(list, root.LeftChild);
            list.Add(root.Value);
            if (root.RightChild != null) Inorder(list, root.RightChild);
        }

        /// <summary>
        /// 中序迭代遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> IterationInorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.LeftChild;
                }
                root = stack.Pop();
                result.Add(root.Value);
                root = root.RightChild;
            }
            return result;
        }

        #endregion

        #region>先序遍历

        /// <summary>
        /// 先序递归遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            PreOrder(result, root);
            return result;
        }

        /// <summary>
        /// 递归遍历
        /// </summary>
        /// <param name="list"></param>
        /// <param name="root"></param>
        private void PreOrder(List<int> list, TreeNode root)
        {
            list.Add(root.Value);
            if (root.LeftChild != null) PreOrder(list, root.LeftChild);
            if (root.RightChild != null) PreOrder(list, root.RightChild);
        }

        /// <summary>
        /// 先序迭代遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> IterationPreOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    result.Add(root.Value);
                    stack.Push(root);
                    root = root.LeftChild;
                }
                root = stack.Pop();
                root = root.RightChild;
            }
            return result;
        }

        #endregion

        #region>后序遍历

        /// <summary>
        /// 后序递归遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            PostOrder(result, root);
            return result;
        }

        /// <summary>
        /// 递归遍历
        /// </summary>
        /// <param name="list"></param>
        /// <param name="root"></param>
        private void PostOrder(List<int> list, TreeNode root)
        {
            if (root.LeftChild != null) PostOrder(list, root.LeftChild);
            if (root.RightChild != null) PostOrder(list, root.RightChild);
            list.Add(root.Value);
        }

        /// <summary>
        /// 先序迭代遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> IterationPostOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            TreeNode preNode = null;
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.LeftChild;
                }
                root = stack.Pop();
                if (root.RightChild == null || root.RightChild == preNode)
                {
                    result.Add(root.Value);
                    preNode = root;
                    root = null;
                }
                else
                {
                    stack.Push(root);
                    root = root.RightChild;
                }
            }
            return result;
        }

        #endregion

        #region>层序遍历

        /// <summary>
        /// 递归层序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
            var result = new List<IList<int>>();
            LevelOrder(result, root, 0);
            return result;
        }

        private void LevelOrder(List<IList<int>> list, TreeNode root, int depth)
        {
            if (root != null)
            {
                if (list.Count == depth)
                {
                    list.Add(new List<int>());
                }
                list[depth].Add(root.Value);
                LevelOrder(list, root.LeftChild, depth + 1);
                LevelOrder(list, root.RightChild, depth + 1);
            }
        }

        /// <summary>
        /// 利用队列实现广度优先遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderTraversalBFS(TreeNode root)
        {
            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            if (root != null)
            {
                queue.Enqueue(root); 
            }
            while (queue.Count != 0)
            {
                var list = new List<int>();
                var count = queue.Count;
                for(var i = 0; i < count; i++)
                {
                    root = queue.Dequeue();
                    list.Add(root.Value);
                    if (root.LeftChild != null) queue.Enqueue(root.LeftChild);
                    if (root.RightChild != null) queue.Enqueue(root.RightChild);
                }
                result.Add(list);
            }
            return result;
        }

        #endregion
    }
}
