using System.ComponentModel;

namespace Nut.Forms.Controls
{
    [ToolboxItem(true)]
    public partial class NoteDetails : UserControl
    {
        public NoteDetails()
        {
            InitializeComponent();

            contentTextBox.TextChanged += OnContentChangedHandler;
            titleTextBox.TextChanged += OnTitleChangedHandler;
        }

        public event OnContentChanged OnContentChanged;

        public event OnTitleChanged OnTitleChanged;

        public RichTextBox ContentTextBox => contentTextBox;

        public TextBox TitleTextBox => titleTextBox;

        private void OnContentChangedHandler(object? sender, EventArgs e)
        {
            var text = ((RichTextBox)sender!).Text;
            OnContentChanged?.Invoke(sender, new ContentChangedEventArgs(text));
        }

        private void OnTitleChangedHandler(object? sender, EventArgs e)
        {
            var text = ((TextBox)sender!).Text;
            OnTitleChanged?.Invoke(sender, new TitleChangedEventArgs(text));
        }
    }
}
