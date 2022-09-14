using Nut.Core;

namespace Nut.Forms
{
    public partial class EditorForm : Form
    {
        private readonly NoteSelection _currentSelection;
        private readonly NotesRepository _repository;

        public EditorForm()
        {
            _repository = new NotesRepository();
            _currentSelection = new NoteSelection();

            InitializeComponent();
            SubscribeTreeListeners();
            SyncTreeWithNotes();
        }

        public void SyncTreeWithNotes()
        {
            var notes = _repository.GetNotes();
            var nodes = NotesMapper.MapToTreeNodes(notes);

            notesTree.Nodes.Clear();
            notesTree.Nodes.AddRange(nodes.ToArray());
        }

        private void OnNodeClickedHandler(object? sender, EventArgs e)
        {
            var treeView = (TreeView)sender!;
            SelectNode(treeView.SelectedNode);
        }

        private void SaveCurrentNote()
        {
            if (_currentSelection.IsEmpty())
            {
                return;
            }

            _currentSelection.Note!.UpdateTitle(noteDetails.TitleTextBox.Text);
            _currentSelection.Note!.UpdateContent(noteDetails.ContentTextBox.Text);

            _currentSelection.TreeNode!.Text = noteDetails.TitleTextBox.Text;
        }

        private void SelectNode(TreeNode node)
        {
            var noteId = (Guid)node.Tag;
            var note = _repository.GetNoteById(noteId);

            SaveCurrentNote();
            UpdateSelection(node, note!);
            UpdateDetails(note!);
        }

        private void SubscribeTreeListeners()
        {
            notesTree.AfterSelect += OnNodeClickedHandler;
        }

        private void UpdateDetails(Note note)
        {
            noteDetails.TitleTextBox.Text = note.Title;
            noteDetails.ContentTextBox.Text = note.Content;
        }

        private void UpdateSelection(TreeNode node, Note note)
        {
            _currentSelection.Update(note!, node);
        }
    }
}
