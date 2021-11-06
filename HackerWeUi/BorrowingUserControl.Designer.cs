namespace HackerWeUi
{
    partial class BorrowingUserControl
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
            this.BorrowingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BorrowingDateLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.BookLabel = new System.Windows.Forms.Label();
            this.DueReturningDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BorrowingDateTimePicker
            // 
            this.BorrowingDateTimePicker.Location = new System.Drawing.Point(135, 25);
            this.BorrowingDateTimePicker.Name = "BorrowingDateTimePicker";
            this.BorrowingDateTimePicker.Size = new System.Drawing.Size(222, 23);
            this.BorrowingDateTimePicker.TabIndex = 0;
            this.BorrowingDateTimePicker.ValueChanged += new System.EventHandler(this.BorrowingDateTimePicker_ValueChanged);
            // 
            // BorrowingDateLabel
            // 
            this.BorrowingDateLabel.AutoSize = true;
            this.BorrowingDateLabel.Location = new System.Drawing.Point(22, 33);
            this.BorrowingDateLabel.Name = "BorrowingDateLabel";
            this.BorrowingDateLabel.Size = new System.Drawing.Size(89, 15);
            this.BorrowingDateLabel.TabIndex = 1;
            this.BorrowingDateLabel.Text = "Borrowing Date";
            this.BorrowingDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(22, 71);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(38, 15);
            this.ClientLabel.TabIndex = 2;
            this.ClientLabel.Text = "Client";
            this.ClientLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(135, 63);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(222, 23);
            this.ClientComboBox.TabIndex = 3;
            this.ClientComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientComboBox_SelectedIndexChanged);
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(135, 104);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(222, 23);
            this.BookComboBox.TabIndex = 5;
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Location = new System.Drawing.Point(22, 112);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(34, 15);
            this.BookLabel.TabIndex = 4;
            this.BookLabel.Text = "Book";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DueReturningDateLabel
            // 
            this.DueReturningDateLabel.AutoSize = true;
            this.DueReturningDateLabel.Location = new System.Drawing.Point(141, 164);
            this.DueReturningDateLabel.Name = "DueReturningDateLabel";
            this.DueReturningDateLabel.Size = new System.Drawing.Size(113, 15);
            this.DueReturningDateLabel.TabIndex = 6;
            this.DueReturningDateLabel.Text = "Due Returning Date:";
            this.DueReturningDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Due Returning Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(258, 186);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 44);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(382, 25);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 15);
            this.MessageLabel.TabIndex = 9;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BorrowingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DueReturningDateLabel);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.BorrowingDateLabel);
            this.Controls.Add(this.BorrowingDateTimePicker);
            this.Name = "BorrowingUserControl";
            this.Size = new System.Drawing.Size(663, 319);
            this.Load += new System.EventHandler(this.BorrowingUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BorrowingDateTimePicker;
        private System.Windows.Forms.Label BorrowingDateLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label DueReturningDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}
