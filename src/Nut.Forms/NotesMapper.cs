using Nut.Core;

namespace Nut.Forms
{
    public static class NotesMapper
    {
        public static IEnumerable<TreeNode> MapToTreeNodes(
            IEnumerable<Note> notes,
            ContextMenuStrip contextMenu)
            => notes is null
                ? throw new ArgumentNullException(nameof(notes))
                : MapToTreeNodesIntern(notes, contextMenu);

        private static IEnumerable<TreeNode> MapToTreeNodesIntern(
            IEnumerable<Note> notes,
            ContextMenuStrip contextMenu)
        {
            var notesArray = notes.ToArray();
            if (notesArray.Length <= 0)
            {
                return Array.Empty<TreeNode>();
            }

            var results = new List<TreeNode>();
            foreach (var note in notes)
            {
                var node = new TreeNode(note.Title)
                {
                    Tag = note.Id,
                    ContextMenuStrip = contextMenu
                };

                results.Add(node);
                node.Nodes.AddRange(MapToTreeNodesIntern(note.Children, contextMenu).ToArray());
            }

            return results;
        }
    }
}
