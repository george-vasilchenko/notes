using Nut.Core;

namespace Nut.Forms
{
    public partial class EditorForm : Form
    {
        private readonly NotesRepository _repository;
        private readonly Selection _selection;

        public EditorForm()
        {
            _repository = new NotesRepository();
            _selection = new Selection();

            InitializeComponent();
            SubscribeTreeListeners();
            UpdateNotesTreeView();
            ProcessSelectedNodeChange(GetFirstOrDefaultNote());
        }

        public void UpdateNotesTreeView()
        {
            var notes = _repository.GetNotes();
            var nodes = NotesMapper.MapToTreeNodes(notes, noteContextMenu);

            notesTree.Nodes.Clear();
            notesTree.Nodes.AddRange(nodes.ToArray());

            notesTree.ExpandAll();
        }

        private static Guid GetNoteId(TreeNode node) => (Guid)node.Tag;

        private void ClearSelection() => _selection.Clear();

        private TreeNode? GetClickedNode()
        {
            var point = notesTree.PointToClient(Cursor.Position);
            var hitTest = notesTree.HitTest(point);

            return hitTest?.Node;
        }

        private TreeNode? GetFirstOrDefaultNote() => notesTree.Nodes.Count == 0 ? null : notesTree.Nodes[0];

        private void ProcessSelectedNodeChange(TreeNode? node)
        {
            if (node is null)
            {
                return;
            }

            var noteId = GetNoteId(node);
            var note = _repository.GetNoteById(noteId);

            SaveCurrentNote();
            UpdateSelection(node);
            UpdateDetails(note);
        }

        private void SaveCurrentNote()
        {
            if (_selection.IsEmpty())
            {
                return;
            }

            _selection.TreeNode!.Text = noteDetails.TitleTextBox.Text;

            var noteId = GetNoteId(_selection.TreeNode);
            var title = noteDetails.TitleTextBox.Text;
            var content = noteDetails.ContentTextBox.Text;

            _repository.UpdateById(noteId, title, content);
        }

        private void SubscribeTreeListeners()
        {
            notesTree.Click += OnNodeClickedHandler;
        }

        private void UpdateDetails(Note note)
        {
            noteDetails.TitleTextBox.Text = note.Title;
            noteDetails.ContentTextBox.Text = note.Content;
        }

        private void UpdateSelection(TreeNode node) => _selection.Update(node);

        #region Event handlers

        private void OnFileCloseMenuClick(object sender, EventArgs e) => Environment.Exit(0);

        private void OnNodeClickedHandler(object? sender, EventArgs e)
        {
            var node = GetClickedNode();
            if (node == null)
            {
                return;
            }

            ProcessSelectedNodeChange(node);
        }

        private void OnNoteAddNoteMenuClick(object sender, EventArgs e)
        {
            var selectedNode = _selection.TreeNode;
            if (selectedNode is null)
            {
                return;
            }

            var parentId = GetNoteId(selectedNode);
            var note = new Note("*", "", parentId);

            _repository.AddNote(parentId, note);
            UpdateNotesTreeView();
        }

        private void OnNoteDeleteNoteMenuClick(object sender, EventArgs e)
        {
            var selectedNode = _selection.TreeNode;
            if (selectedNode is null)
            {
                return;
            }

            var noteId = GetNoteId(selectedNode);
            _repository.DeleteById(noteId);

            ClearSelection();
            UpdateNotesTreeView();
        }

        private void OnNoteNewMenuClick(object sender, EventArgs e)
        {
            var note = new Note("*", "");
            _repository.AddNote(note);

            UpdateNotesTreeView();
        }

        private void OnSaveTimerTick(object sender, EventArgs e)
            => SaveCurrentNote();

        #endregion Event handlers
    }
}
