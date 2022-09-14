namespace Nut.Forms.Controls
{
    partial class NoteDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notePanel = new System.Windows.Forms.Panel();
            this.noteTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.notePanel.SuspendLayout();
            this.noteTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notePanel
            // 
            this.notePanel.Controls.Add(this.noteTableLayoutPanel);
            this.notePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notePanel.Location = new System.Drawing.Point(0, 0);
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(902, 814);
            this.notePanel.TabIndex = 1;
            // 
            // noteTableLayoutPanel
            // 
            this.noteTableLayoutPanel.ColumnCount = 2;
            this.noteTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.803612F));
            this.noteTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.19639F));
            this.noteTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.noteTableLayoutPanel.Controls.Add(this.titleTextBox, 1, 0);
            this.noteTableLayoutPanel.Controls.Add(this.contentTextBox, 0, 1);
            this.noteTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.noteTableLayoutPanel.Name = "noteTableLayoutPanel";
            this.noteTableLayoutPanel.RowCount = 2;
            this.noteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.135338F));
            this.noteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.86466F));
            this.noteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.noteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.noteTableLayoutPanel.Size = new System.Drawing.Size(902, 814);
            this.noteTableLayoutPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(3, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Location = new System.Drawing.Point(82, 3);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(817, 27);
            this.titleTextBox.TabIndex = 1;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTableLayoutPanel.SetColumnSpan(this.contentTextBox, 2);
            this.contentTextBox.Location = new System.Drawing.Point(3, 36);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(896, 775);
            this.contentTextBox.TabIndex = 2;
            this.contentTextBox.Text = "";
            // 
            // NoteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notePanel);
            this.Name = "NoteDetails";
            this.Size = new System.Drawing.Size(902, 814);
            this.notePanel.ResumeLayout(false);
            this.noteTableLayoutPanel.ResumeLayout(false);
            this.noteTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel notePanel;
        private TableLayoutPanel noteTableLayoutPanel;
        private Label titleLabel;
        private TextBox titleTextBox;
        private RichTextBox contentTextBox;
    }
}
