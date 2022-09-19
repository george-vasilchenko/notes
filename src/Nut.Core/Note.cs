using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Nut.Core
{
    public class Note
    {
        [JsonProperty("children")]
        private readonly Collection<Note> _children;

        public Note(string title, string content, Guid? parentId = null)
        {
            Id = Guid.NewGuid();
            Content = content;
            ParentId = parentId;
            Title = title;
            _children = new Collection<Note>();
        }

        private Note()
        {

        }

        [JsonIgnore]
        public IEnumerable<Note> Children => _children;

        [JsonProperty("content")]
        public string Content { get; private set; }

        [JsonProperty("id")]
        public Guid Id { get; private set; }

        [JsonProperty("parentId")]
        public Guid? ParentId { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        public void UpdateContent(string content) => Content = content;

        public void UpdateTitle(string title) => Title = title;

        internal void AddNote(Note note)
        {
            if (note is null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            _children.Add(note);
        }

        internal void RemoveNote(Note note)
        {
            if (note is null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            _children.Remove(note);
        }
    }
}
