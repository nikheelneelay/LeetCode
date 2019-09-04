namespace LeetCode
{
    internal class MaxDepthBT
    {
        private static void Main1(string[] args)
        {
            var sampleData = GetSampleData();

            var output = MaxDepth(sampleData);

            System.Console.WriteLine(output);

        }

        public static TreeNode GetSampleData()
        {
            var rightNode = new TreeNode(20)
            {
                left = new TreeNode(15),
                right = new TreeNode(7)
            };

            var rootNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = rightNode
            };

            return rootNode;
        }

        public static int MaxDepth(TreeNode root)
        {
            int o = 0;
            if (root != null)
            {
                o += 1;
            }
            if (root.left != null || root.right != null)
            {
                o += 1;
            }

            var temp = root.left;

            if (temp.left != null || temp.right != null)
            {
                o += 1;
            }

            var temp2 = root.right;

            if (temp2.left != null || temp2.right != null)
            {
                o += 1;
            }


            return o;
        }

        public static int GetNodeCount(TreeNode node)
        {
            if (node == null) return 0;

            if (node.left == null && node.right == null) return 1;

            return 2;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class BinaryTree
    {
        private readonly TreeNode root;

        public BinaryTree(TreeNode node)
        {
            root = node;
        }

        public void AddNode(TreeNode node)
        {
            root.left = node;
        }
    }
}