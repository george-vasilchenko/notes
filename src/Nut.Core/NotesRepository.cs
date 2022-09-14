namespace Nut.Core
{
    public class NotesRepository
    {
        private static readonly List<Note> notes = new List<Note>()
        {
            new Note("A", "A"),
            new Note("B", "B", new[]
            {
                new Note("BB", "BB")
            }),
            new Note("C", "C", new[]
            {
                new Note("CC", "CC", new[]
                {
                    new Note("CCC", "CCC")
                })
            }),
        };

        public Note? GetNoteById(Guid id)
        {
            return FindNote(id, notes);
        }

        public IEnumerable<Note> GetNotes()
        {
            return notes;
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
