namespace Nut.Forms.Controls
{
    public delegate void OnTitleChanged(object sender, TitleChangedEventArgs args);

    public class TitleChangedEventArgs : EventArgs
    {
        public TitleChangedEventArgs(string newTitle)
        {
            NewTitle = newTitle;
        }

        public string NewTitle { get; }
    }
}
