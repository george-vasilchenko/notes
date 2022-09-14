namespace Nut.Forms.Controls
{
    public delegate void OnContentChanged(object sender, ContentChangedEventArgs args);

    public class ContentChangedEventArgs : EventArgs
    {
        public ContentChangedEventArgs(string newContent)
        {
            NewContent = newContent;
        }

        public string NewContent { get; }
    }
}
