using Nut.Core;

namespace Nut.Forms
{
    public static class NotesMapper
    {
        public static IEnumerable<TreeNode> MapToTreeNodes(IEnumerable<Note> notes)
        {
            if (notes is null)
            {
                throw new ArgumentNullException(nameof(notes));
            }

            return MapToTreeNodesIntern(notes);
        }

        private static IEnumerable<TreeNode> MapToTreeNodesIntern(IEnumerable<Note> notes)
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
                    Tag = note.Id
                };

                results.Add(node);
                node.Nodes.AddRange(MapToTreeNodesIntern(note.Children).ToArray());
            }

            return results;
        }
    }
}
