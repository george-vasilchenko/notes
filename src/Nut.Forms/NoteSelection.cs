using Nut.Core;

namespace Nut.Forms
{
    public class NoteSelection
    {
        public NoteSelection()
        {
            Note = null;
            TreeNode = null;
        }

        public Note? Note { get; private set; }

        public TreeNode? TreeNode { get; private set; }

        public bool IsEmpty()
        {
            return Note == null && TreeNode == null;
        }

        public void Update(Note note, TreeNode treeNode)
        {
            Note = note;
            TreeNode = treeNode;
        }
    }
}
