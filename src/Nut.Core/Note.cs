namespace Nut.Core
{
    public class Note
    {
        public Note(string title, string content, IEnumerable<Note>? children = null)
        {
            Id = Guid.NewGuid();
            Content = content;
            Title = title;
            Children = children ?? Array.Empty<Note>();
        }

        public IEnumerable<Note> Children { get; }
        public string Content { get; private set; }
        public Guid Id { get; }
        public string Title { get; private set; }

        public void UpdateContent(string content)
        {
            Content = content;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}
