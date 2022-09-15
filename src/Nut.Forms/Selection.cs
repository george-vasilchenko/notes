namespace Nut.Forms
{
    public class Selection
    {
        public Selection() => TreeNode = null;

        public TreeNode? TreeNode { get; private set; }

        public void Clear() => TreeNode = null;

        public bool IsEmpty() => TreeNode == null;

        public void Update(TreeNode treeNode) => TreeNode = treeNode;
    }
}
