using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSearch.Classes
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
//----------------------------------------------------------------------------------------------------------------------//
        public TreeNode<T>? SearchRecursive(TreeNode<T>? root, T key)
        {
            // Base Case: root is null or key is found
            if (root == null || root.Data.CompareTo(key) == 0)
                return root;

            // Key is smaller than root's data -> search left subtree
            if (key.CompareTo(root.Data) < 0)
                return SearchRecursive(root.Left, key);

            // Key is greater than root's data -> search right subtree
            return SearchRecursive(root.Right, key);
        }
//----------------------------------------------------------------------------------------------------------------------//
        public TreeNode<T>? SearchIterative(TreeNode<T>? root, T key)
        {
            TreeNode<T>? current = root;

            while (current != null)
            {
                int comparison = key.CompareTo(current.Data);

                if (comparison == 0)
                    return current; // Found

                // Navigate left or right depending on value
                current = comparison < 0 ? current.Left : current.Right;
            }

            return null; // Not found
        }
        //----------------------------------------------------------------------------------------------------------------------//

        public TreeNode<T>? SearchUnsortedDFS(TreeNode<T>? root, T key)
        {
            if (root == null) return null;
            if (EqualityComparer<T>.Default.Equals(root.Data, key)) return root;

            // Search left branch
            var leftResult = SearchUnsortedDFS(root.Left, key);
            if (leftResult != null) return leftResult;

            // Search right branch
            return SearchUnsortedDFS(root.Right, key);
        }
//----------------------------------------------------------------------------------------------------------------------//
        public TreeNode<T>? SearchUnsortedBFS(TreeNode<T>? root, T key)
        {
            if (root == null) return null;

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode<T> current = queue.Dequeue();

                if (EqualityComparer<T>.Default.Equals(current.Data, key))
                    return current;

                if (current.Left != null) queue.Enqueue(current.Left);
                if (current.Right != null) queue.Enqueue(current.Right);
            }

            return null;
        }

    }
}
