namespace HackerWeUi
{
    partial class HackerWeLibraryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BooksButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.BorowingButton = new System.Windows.Forms.Button();
            this.ReturningButton = new System.Windows.Forms.Button();
            this.HackerWeLibraryPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MessageToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BooksButton
            // 
            this.BooksButton.Location = new System.Drawing.Point(3, 12);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(112, 52);
            this.BooksButton.TabIndex = 0;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = true;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Location = new System.Drawing.Point(121, 12);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(112, 52);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // BorowingButton
            // 
            this.BorowingButton.Location = new System.Drawing.Point(239, 12);
            this.BorowingButton.Name = "BorowingButton";
            this.BorowingButton.Size = new System.Drawing.Size(112, 52);
            this.BorowingButton.TabIndex = 2;
            this.BorowingButton.Text = "Borowing";
            this.BorowingButton.UseVisualStyleBackColor = true;
            this.BorowingButton.Click += new System.EventHandler(this.BorowingButton_Click);
            // 
            // ReturningButton
            // 
            this.ReturningButton.Location = new System.Drawing.Point(357, 12);
            this.ReturningButton.Name = "ReturningButton";
            this.ReturningButton.Size = new System.Drawing.Size(112, 52);
            this.ReturningButton.TabIndex = 3;
            this.ReturningButton.Text = "Returning";
            this.ReturningButton.UseVisualStyleBackColor = true;
            // 
            // HackerWeLibraryPanel
            // 
            this.HackerWeLibraryPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HackerWeLibraryPanel.Location = new System.Drawing.Point(3, 99);
            this.HackerWeLibraryPanel.Name = "HackerWeLibraryPanel";
            this.HackerWeLibraryPanel.Size = new System.Drawing.Size(939, 449);
            this.HackerWeLibraryPanel.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "HackerWeLibraryStatusStrip";
            // 
            // MessageToolStripStatusLabel
            // 
            this.MessageToolStripStatusLabel.Name = "MessageToolStripStatusLabel";
            this.MessageToolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.MessageToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // HackerWeLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.HackerWeLibraryPanel);
            this.Controls.Add(this.ReturningButton);
            this.Controls.Add(this.BorowingButton);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.BooksButton);
            this.Name = "HackerWeLibraryForm";
            this.Text = "HackerWe Library";
            this.Load += new System.EventHandler(this.HackerWeLibraryForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button BorowingButton;
        private System.Windows.Forms.Button ReturningButton;
        private System.Windows.Forms.Panel HackerWeLibraryPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MessageToolStripStatusLabel;
    }
}

