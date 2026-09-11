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

    }
}
