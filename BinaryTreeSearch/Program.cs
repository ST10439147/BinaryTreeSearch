using BinaryTreeSearch.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        TreeNode<int> root = new TreeNode<int>(10);
        root.Left = new TreeNode<int>(5);
        root.Right = new TreeNode<int>(15);
        root.Left.Left = new TreeNode<int>(3);
        root.Left.Right = new TreeNode<int>(7);
        root.Right.Right = new TreeNode<int>(20);
        root.Right.Left = new TreeNode<int>(12);
        root.Left.Left.Left = new TreeNode<int>(1);
    }
}