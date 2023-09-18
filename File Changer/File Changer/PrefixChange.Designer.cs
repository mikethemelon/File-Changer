
namespace File_Changer
{
    partial class PrefixChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrefixChange));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.RemovePrefixButton = new System.Windows.Forms.Button();
            this.PrefixTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddOrdinalNumbers = new System.Windows.Forms.Button();
            this.ImagePreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.SlideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.DeleteAllFilesButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(576, 249);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(74, 28);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(45, 97);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(525, 180);
            this.FilesListBox.TabIndex = 1;
            // 
            // RemovePrefixButton
            // 
            this.RemovePrefixButton.Location = new System.Drawing.Point(576, 384);
            this.RemovePrefixButton.Name = "RemovePrefixButton";
            this.RemovePrefixButton.Size = new System.Drawing.Size(146, 50);
            this.RemovePrefixButton.TabIndex = 2;
            this.RemovePrefixButton.Text = "Remove Prefix";
            this.RemovePrefixButton.UseVisualStyleBackColor = true;
            this.RemovePrefixButton.Click += new System.EventHandler(this.RemovePrefixButton_Click);
            // 
            // PrefixTextBox
            // 
            this.PrefixTextBox.Location = new System.Drawing.Point(45, 384);
            this.PrefixTextBox.Multiline = true;
            this.PrefixTextBox.Name = "PrefixTextBox";
            this.PrefixTextBox.Size = new System.Drawing.Size(525, 50);
            this.PrefixTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "* Insert File(s) need to remove prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "* Insert Prefix you want to remove from file(s)";
            // 
            // AddOrdinalNumbers
            // 
            this.AddOrdinalNumbers.Location = new System.Drawing.Point(728, 384);
            this.AddOrdinalNumbers.Name = "AddOrdinalNumbers";
            this.AddOrdinalNumbers.Size = new System.Drawing.Size(227, 50);
            this.AddOrdinalNumbers.TabIndex = 6;
            this.AddOrdinalNumbers.Text = "Change into Numbers (in order)";
            this.AddOrdinalNumbers.UseVisualStyleBackColor = true;
            this.AddOrdinalNumbers.Click += new System.EventHandler(this.AddOrdinalNumbers_Click);
            // 
            // ImagePreviewPictureBox
            // 
            this.ImagePreviewPictureBox.Location = new System.Drawing.Point(656, 12);
            this.ImagePreviewPictureBox.Name = "ImagePreviewPictureBox";
            this.ImagePreviewPictureBox.Size = new System.Drawing.Size(299, 347);
            this.ImagePreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePreviewPictureBox.TabIndex = 7;
            this.ImagePreviewPictureBox.TabStop = false;
            // 
            // SlideshowTimer
            // 
            this.SlideshowTimer.Enabled = true;
            this.SlideshowTimer.Interval = 2000;
            this.SlideshowTimer.Tick += new System.EventHandler(this.SlideshowTimer_Tick);
            // 
            // DeleteAllFilesButton
            // 
            this.DeleteAllFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAllFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllFilesButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteAllFilesButton.Location = new System.Drawing.Point(45, 283);
            this.DeleteAllFilesButton.Name = "DeleteAllFilesButton";
            this.DeleteAllFilesButton.Size = new System.Drawing.Size(219, 32);
            this.DeleteAllFilesButton.TabIndex = 8;
            this.DeleteAllFilesButton.Text = "Delete Directory Files";
            this.DeleteAllFilesButton.UseVisualStyleBackColor = true;
            this.DeleteAllFilesButton.Click += new System.EventHandler(this.DeleteAllFilesButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearListButton.Location = new System.Drawing.Point(351, 283);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(219, 32);
            this.ClearListButton.TabIndex = 9;
            this.ClearListButton.Text = "Delete Selected Files";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // PrefixChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 460);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.DeleteAllFilesButton);
            this.Controls.Add(this.ImagePreviewPictureBox);
            this.Controls.Add(this.AddOrdinalNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrefixTextBox);
            this.Controls.Add(this.RemovePrefixButton);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.BrowseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrefixChange";
            this.Text = "File Changer - Advance Files Rename";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button RemovePrefixButton;
        private System.Windows.Forms.TextBox PrefixTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddOrdinalNumbers;
        private System.Windows.Forms.PictureBox ImagePreviewPictureBox;
        private System.Windows.Forms.Timer SlideshowTimer;
        private System.Windows.Forms.Button DeleteAllFilesButton;
        private System.Windows.Forms.Button ClearListButton;
    }
}

