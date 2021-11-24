using System;

namespace _0700SearchInBST
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

    //accepted by leetcode
    class Program
    {
        TreeNode node;
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root != null)
            {
                if (root.val == val)
                {
                    node = root;
                }
                else
                {
                    if (root.left != null)
                    {
                        SearchBST(root.left, val);

                    }
                    if (root.right != null)
                    {
                        SearchBST(root.right, val);

                    }
                }

            }


            return node;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            TreeNode n1 = new TreeNode(1);
            TreeNode n3 = new TreeNode(3);
            TreeNode n7 = new TreeNode(7);
            TreeNode n2 = new TreeNode(2, n1, n3);
            TreeNode root = new TreeNode(4, n2, n7);


            var x = p.SearchBST(root, 2); // true

            Console.WriteLine(x.val);
        }
    }
}
