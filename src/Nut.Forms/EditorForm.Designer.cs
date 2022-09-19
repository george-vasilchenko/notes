namespace Nut.Forms
{
    partial class EditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.editorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.notesTree = new System.Windows.Forms.TreeView();
            this.noteDetails = new Nut.Forms.Controls.NoteDetails();
            this.applicationMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.noteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.noteNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.noteContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noteAddNoteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.noteDeleteNoteMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.editorSplitContainer)).BeginInit();
            this.editorSplitContainer.Panel1.SuspendLayout();
            this.editorSplitContainer.Panel2.SuspendLayout();
            this.editorSplitContainer.SuspendLayout();
            this.applicationMenu.SuspendLayout();
            this.noteContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorSplitContainer
            // 
            this.editorSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorSplitContainer.Location = new System.Drawing.Point(0, 36);
            this.editorSplitContainer.Margin = new System.Windows.Forms.Padding(100);
            this.editorSplitContainer.Name = "editorSplitContainer";
            // 
            // editorSplitContainer.Panel1
            // 
            this.editorSplitContainer.Panel1.Controls.Add(this.notesTree);
            // 
            // editorSplitContainer.Panel2
            // 
            this.editorSplitContainer.Panel2.Controls.Add(this.noteDetails);
            this.editorSplitContainer.Size = new System.Drawing.Size(811, 856);
            this.editorSplitContainer.SplitterDistance = 141;
            this.editorSplitContainer.TabIndex = 0;
            // 
            // notesTree
            // 
            this.notesTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesTree.Location = new System.Drawing.Point(0, 0);
            this.notesTree.Margin = new System.Windows.Forms.Padding(4);
            this.notesTree.Name = "notesTree";
            this.notesTree.Size = new System.Drawing.Size(141, 856);
            this.notesTree.TabIndex = 0;
            // 
            // noteDetails
            // 
            this.noteDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteDetails.Location = new System.Drawing.Point(0, 0);
            this.noteDetails.Name = "noteDetails";
            this.noteDetails.Size = new System.Drawing.Size(666, 856);
            this.noteDetails.TabIndex = 0;
            // 
            // applicationMenu
            // 
            this.applicationMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.applicationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.noteMenu});
            this.applicationMenu.Location = new System.Drawing.Point(0, 0);
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Size = new System.Drawing.Size(811, 33);
            this.applicationMenu.TabIndex = 1;
            this.applicationMenu.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCloseMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 29);
            this.fileMenu.Text = "File";
            // 
            // fileCloseMenu
            // 
            this.fileCloseMenu.Name = "fileCloseMenu";
            this.fileCloseMenu.Size = new System.Drawing.Size(157, 34);
            this.fileCloseMenu.Text = "Close";
            this.fileCloseMenu.Click += new System.EventHandler(this.OnFileCloseMenuClick);
            // 
            // noteMenu
            // 
            this.noteMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteNewMenu});
            this.noteMenu.Name = "noteMenu";
            this.noteMenu.Size = new System.Drawing.Size(67, 29);
            this.noteMenu.Text = "Note";
            // 
            // noteNewMenu
            // 
            this.noteNewMenu.Name = "noteNewMenu";
            this.noteNewMenu.Size = new System.Drawing.Size(149, 34);
            this.noteNewMenu.Text = "New";
            this.noteNewMenu.Click += new System.EventHandler(this.OnNoteNewMenuClick);
            // 
            // saveTimer
            // 
            this.saveTimer.Enabled = true;
            this.saveTimer.Interval = 500;
            this.saveTimer.Tick += new System.EventHandler(this.OnSaveTimerTick);
            // 
            // noteContextMenu
            // 
            this.noteContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.noteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteAddNoteMenu,
            this.noteDeleteNoteMenu});
            this.noteContextMenu.Name = "noteContextMenu";
            this.noteContextMenu.Size = new System.Drawing.Size(163, 68);
            // 
            // noteAddNoteMenu
            // 
            this.noteAddNoteMenu.Name = "noteAddNoteMenu";
            this.noteAddNoteMenu.Size = new System.Drawing.Size(162, 32);
            this.noteAddNoteMenu.Text = "Add Note";
            this.noteAddNoteMenu.Click += new System.EventHandler(this.OnNoteAddNoteMenuClick);
            // 
            // noteDeleteNoteMenu
            // 
            this.noteDeleteNoteMenu.Name = "noteDeleteNoteMenu";
            this.noteDeleteNoteMenu.Size = new System.Drawing.Size(162, 32);
            this.noteDeleteNoteMenu.Text = "Delete";
            this.noteDeleteNoteMenu.Click += new System.EventHandler(this.OnNoteDeleteNoteMenuClick);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 892);
            this.Controls.Add(this.applicationMenu);
            this.Controls.Add(this.editorSplitContainer);
            this.MainMenuStrip = this.applicationMenu;
            this.MaximizeBox = false;
            this.Name = "EditorForm";
            this.Text = "Notes";
            this.editorSplitContainer.Panel1.ResumeLayout(false);
            this.editorSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorSplitContainer)).EndInit();
            this.editorSplitContainer.ResumeLayout(false);
            this.applicationMenu.ResumeLayout(false);
            this.applicationMenu.PerformLayout();
            this.noteContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer editorSplitContainer;
        private TreeView notesTree;
        private MenuStrip applicationMenu;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem fileCloseMenu;
        private Controls.NoteDetails noteDetails;
        private System.Windows.Forms.Timer saveTimer;
        private ContextMenuStrip noteContextMenu;
        private ToolStripMenuItem noteAddNoteMenu;
        private ToolStripMenuItem noteDeleteNoteMenu;
        private ToolStripMenuItem noteMenu;
        private ToolStripMenuItem noteNewMenu;
    }
}