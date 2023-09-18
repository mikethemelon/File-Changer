
namespace Debug
{
    partial class Form1
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
            this.AddOrdinalNumbers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrefixTextBox = new System.Windows.Forms.TextBox();
            this.RemovePrefixButton = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOrdinalNumbers
            // 
            this.AddOrdinalNumbers.Location = new System.Drawing.Point(704, 405);
            this.AddOrdinalNumbers.Name = "AddOrdinalNumbers";
            this.AddOrdinalNumbers.Size = new System.Drawing.Size(227, 50);
            this.AddOrdinalNumbers.TabIndex = 14;
            this.AddOrdinalNumbers.Text = "Change into Numbers (in order)";
            this.AddOrdinalNumbers.UseVisualStyleBackColor = true;
            this.AddOrdinalNumbers.Click += new System.EventHandler(this.AddOrdinalNumbers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "* Insert Prefix you want to remove from file(s)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "* Insert File(s) need to remove prefix:";
            // 
            // PrefixTextBox
            // 
            this.PrefixTextBox.Location = new System.Drawing.Point(21, 405);
            this.PrefixTextBox.Multiline = true;
            this.PrefixTextBox.Name = "PrefixTextBox";
            this.PrefixTextBox.Size = new System.Drawing.Size(525, 50);
            this.PrefixTextBox.TabIndex = 11;
            // 
            // RemovePrefixButton
            // 
            this.RemovePrefixButton.Location = new System.Drawing.Point(552, 405);
            this.RemovePrefixButton.Name = "RemovePrefixButton";
            this.RemovePrefixButton.Size = new System.Drawing.Size(146, 50);
            this.RemovePrefixButton.TabIndex = 10;
            this.RemovePrefixButton.Text = "Remove Prefix";
            this.RemovePrefixButton.UseVisualStyleBackColor = true;
            this.RemovePrefixButton.Click += new System.EventHandler(this.RemovePrefixButton_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(21, 118);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(525, 180);
            this.FilesListBox.TabIndex = 9;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(552, 270);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(74, 28);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 488);
            this.Controls.Add(this.AddOrdinalNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrefixTextBox);
            this.Controls.Add(this.RemovePrefixButton);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.BrowseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrdinalNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrefixTextBox;
        private System.Windows.Forms.Button RemovePrefixButton;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button BrowseButton;
    }
}

