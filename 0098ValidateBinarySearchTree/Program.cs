using System;

namespace _0098ValidateBinarySearchTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    //accepted by leetcode but code stolen from the answers
    class Program
    {
        private int? prev;
        public bool IsValidBST(TreeNode root)
        {
            prev = null;
            return InOrder(root);
        }

        public bool InOrder(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            if (!InOrder(root.left))
            {
                return false;
            }
            if (prev != null && root.val <= prev)
            {
                return false;
            }
            prev = root.val;
            return InOrder(root.right);

        }

        static void Main(string[] args)
        {
            Program p = new Program();

            TreeNode n3 = new TreeNode(3);
            TreeNode n1 = new TreeNode(1);
            TreeNode root = new TreeNode(2, n1, n3);

            TreeNode n6 = new TreeNode(7);
            TreeNode n33 = new TreeNode(3);
            TreeNode n4 = new TreeNode(6, n33, n6);
            TreeNode n11 = new TreeNode(4);
            TreeNode root2 = new TreeNode(5, n11, n4);

            TreeNode root3 = new TreeNode(1, n1);

            var x = p.IsValidBST(root); // true
            var y = p.IsValidBST(root2); //false
            var z = p.IsValidBST(root3); //false

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


        }
    }
}
