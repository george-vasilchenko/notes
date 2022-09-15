using System.Configuration;

namespace Nut.Core
{
    public class NotesRepository
    {
        private readonly List<Note> _notes;
        private readonly FileStore _store;

        public NotesRepository()
        {
            _store = new FileStore(ConfigurationManager.AppSettings["fileStorePath"]!);
            _notes = _store.ReadStore<List<Note>>();
        }

        public void AddNote(Note note)
        {
            if (note is null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            _notes.Add(note);
            Save();
        }

        public void AddNote(Guid parentId, Note note)
        {
            if (note is null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            var parentNote = GetNoteById(parentId);
            parentNote.AddNote(note);

            Save();
        }

        public void DeleteById(Guid noteId)
        {
            var note = GetNoteById(noteId);
            if(note.ParentId == null)
            {
                _notes.Remove(note);
            }
            else
            {
                var parentNote = GetNoteById((Guid)note.ParentId);
                parentNote.RemoveNote(note);
            }

            Save();
        }

        public Note GetNoteById(Guid id)
        {
            var result = FindNote(id, _notes);

            return result == null
                ? throw new InvalidOperationException($"Requested note with id {id} was not found")
                : result;
        }

        public IEnumerable<Note> GetNotes() => _notes;

        public void Save() => _store.WriteStore(_notes);

        public void UpdateById(Guid id, string title, string content)
        {
            var note = FindNote(id, _notes)!;

            note.UpdateTitle(title);
            note.UpdateContent(content);

            Save();
        }

        private Note? FindNote(Guid id, IEnumerable<Note> notes)
        {
            var notesArray = notes.ToArray();
            if (notesArray.Length == 0)
            {
                return null;
            }

            var result = default(Note);
            foreach (var note in notesArray)
            {
                if (note.Id == id)
                {
                    result = note;
                    break;
                }

                result = FindNote(id, note.Children);
                if (result != null)
                {
                    break;
                }
            }

            return result;
        }
    }
}
