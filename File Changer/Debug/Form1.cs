using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Debug
{
    public partial class Form1 : Form
    {
        private int fileCounter = 1;
        private int currentImageIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "All Files|*.*",
                Title = "Select Files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    FilesListBox.Items.Add(filePath);
                }
            }
        }

        private void RemovePrefixButton_Click(object sender, EventArgs e)
        {
            string prefixToRemove = PrefixTextBox.Text.Trim();

            if (string.IsNullOrEmpty(prefixToRemove))
            {
                MessageBox.Show("Please enter a prefix to remove.");
                return;
            }

            foreach (object item in FilesListBox.Items)
            {
                string filePath = item.ToString();
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(fileName);

                // Check if the file name starts with the prefix (case insensitive)
                if (fileName.StartsWith(prefixToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    // Remove the prefix (including any leading hyphens)
                    fileName = fileName.Substring(prefixToRemove.Length).TrimStart('-');

                    // Combine the updated file name with the original extension
                    string newFileName = fileName + extension;

                    // Generate the new file path
                    string newFilePath = Path.Combine(directory, GetUniqueFileName(directory, newFileName, extension));

                    // Rename the file
                    File.Move(filePath, newFilePath);
                }
            }

            MessageBox.Show("Files renamed successfully.");
        }

        private string GetUniqueFileName(string directory, string fileName, string extension)
        {
            string newFileName = fileName;

            int counter = 1;
            while (File.Exists(Path.Combine(directory, newFileName + extension)))
            {
                newFileName = $"{fileName}_{counter}";
                counter++;
            }

            return newFileName + extension;

        }

        private void AddOrdinalNumbers_Click(object sender, EventArgs e)
        {
            fileCounter = 1;

            foreach (object item in FilesListBox.Items)
            {
                string filePath = item.ToString();
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(fileName);

                // Generate a new file name with an ordinal number
                string newFileName = fileCounter.ToString() + extension;
                fileCounter++;

                string newFilePath = Path.Combine(directory, GetUniqueFileName(directory, newFileName, extension));


                File.Move(filePath, newFilePath);
            }

            MessageBox.Show("Ordinal numbers added to filenames successfully.");
        }
    }
}
