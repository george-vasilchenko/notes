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
            this.editorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.notesGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTree = new System.Windows.Forms.TreeView();
            this.contentGroupBox = new System.Windows.Forms.GroupBox();
            this.noteDetails = new Nut.Forms.Controls.NoteDetails();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.editorSplitContainer)).BeginInit();
            this.editorSplitContainer.Panel1.SuspendLayout();
            this.editorSplitContainer.Panel2.SuspendLayout();
            this.editorSplitContainer.SuspendLayout();
            this.notesGroupBox.SuspendLayout();
            this.contentGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            this.editorSplitContainer.Panel1.Controls.Add(this.notesGroupBox);
            // 
            // editorSplitContainer.Panel2
            // 
            this.editorSplitContainer.Panel2.Controls.Add(this.contentGroupBox);
            this.editorSplitContainer.Size = new System.Drawing.Size(1594, 1187);
            this.editorSplitContainer.SplitterDistance = 400;
            this.editorSplitContainer.TabIndex = 0;
            // 
            // notesGroupBox
            // 
            this.notesGroupBox.Controls.Add(this.notesTree);
            this.notesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.notesGroupBox.Name = "notesGroupBox";
            this.notesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.notesGroupBox.Size = new System.Drawing.Size(400, 1187);
            this.notesGroupBox.TabIndex = 1;
            this.notesGroupBox.TabStop = false;
            this.notesGroupBox.Text = "Notes";
            // 
            // notesTree
            // 
            this.notesTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesTree.Location = new System.Drawing.Point(4, 28);
            this.notesTree.Margin = new System.Windows.Forms.Padding(4);
            this.notesTree.Name = "notesTree";
            this.notesTree.Size = new System.Drawing.Size(392, 1155);
            this.notesTree.TabIndex = 0;
            // 
            // contentGroupBox
            // 
            this.contentGroupBox.Controls.Add(this.noteDetails);
            this.contentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentGroupBox.Location = new System.Drawing.Point(0, 0);
            this.contentGroupBox.Name = "contentGroupBox";
            this.contentGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.contentGroupBox.Size = new System.Drawing.Size(1190, 1187);
            this.contentGroupBox.TabIndex = 1;
            this.contentGroupBox.TabStop = false;
            this.contentGroupBox.Text = "Editor";
            // 
            // noteDetails
            // 
            this.noteDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteDetails.Location = new System.Drawing.Point(4, 28);
            this.noteDetails.Name = "noteDetails";
            this.noteDetails.Size = new System.Drawing.Size(1182, 1155);
            this.noteDetails.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1594, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.noteToolStripMenuItem.Text = "Note";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 1223);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.editorSplitContainer);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "EditorForm";
            this.Text = "Notes";
            this.editorSplitContainer.Panel1.ResumeLayout(false);
            this.editorSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorSplitContainer)).EndInit();
            this.editorSplitContainer.ResumeLayout(false);
            this.notesGroupBox.ResumeLayout(false);
            this.contentGroupBox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer editorSplitContainer;
        private TreeView notesTree;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem noteToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private GroupBox notesGroupBox;
        private GroupBox contentGroupBox;
        private Controls.NoteDetails noteDetails;
    }
}