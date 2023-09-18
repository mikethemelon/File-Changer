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

namespace File_Changer
{
    public partial class PrefixChange : Form
    {
        private int fileCounter = 1;
        private int currentImageIndex = -1;

        // Add a boolean flag to track the slideshow state
        private bool isSlideshowRunning = false;
        private bool stopSlideshow = false; // Add this flag

        public PrefixChange()
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
                    UpdatePictureBox(filePath); // Update the PictureBox with the selected image
                }
            }
        }

        

        private async void RemovePrefixButton_Click(object sender, EventArgs e)
        {
            if (isSlideshowRunning)
            {
                // Stop the slideshow
                SlideshowTimer.Enabled = false;

                // Wait for the slideshow to stop
                while (SlideshowTimer.Enabled)
                {
                    await Task.Delay(100);
                }
            }

            string prefixToRemove = PrefixTextBox.Text.Trim();

            if (string.IsNullOrEmpty(prefixToRemove))
            {
                MessageBox.Show("Please enter a prefix to remove.");
                return;
            }

            foreach (object item in FilesListBox.Items)
            {
                ReleaseImage(currentImageIndex);
                await Task.Delay(200);

                string filePath = item.ToString();
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath); // Get the file name without extension
                string extension = Path.GetExtension(filePath);

                // Check if the file name contains the prefix (case insensitive)
                int index = fileName.IndexOf(prefixToRemove, StringComparison.OrdinalIgnoreCase);
                if (index >= 0)
                {
                    // Remove the prefix from the file name
                    fileName = fileName.Remove(index, prefixToRemove.Length);

                    // Combine the updated file name with the original extension
                    string newFileName = fileName;

                    // Generate the new file path
                    string newFilePath = Path.Combine(directory, GetUniqueFileName(directory, newFileName, extension));

                    // Rename the file
                    File.Move(filePath, newFilePath);
                }
            }

            MessageBox.Show("Files renamed successfully.");

            /*if (isSlideshowRunning)
            {
                // Stop the slideshow
                SlideshowTimer.Enabled = false;

                // Wait for the slideshow to stop
                while (SlideshowTimer.Enabled)
                {
                    await Task.Delay(100);
                }
            }

            string prefixToRemove = PrefixTextBox.Text.Trim();

            if (string.IsNullOrEmpty(prefixToRemove))
            {
                MessageBox.Show("Please enter a prefix to remove.");
                return;
            }

            foreach (object item in FilesListBox.Items)
            {
                ReleaseImage(currentImageIndex);
                await Task.Delay(200);

                string filePath = item.ToString();
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);

                // Check if the file name starts with the prefix (case insensitive)
                if (fileName.StartsWith(prefixToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    // Remove the prefix (including any leading hyphens)
                    fileName = fileName.Substring(prefixToRemove.Length).TrimStart('-');

                    // Change the file extension (if any) using Path.ChangeExtension
                    fileName = Path.ChangeExtension(fileName, null);

                    // Generate the new file path with the original extension
                    string newFilePath = Path.Combine(directory, GetUniqueFileName(directory, fileName, Path.GetExtension(filePath)));

                    // Rename the file
                    File.Move(filePath, newFilePath);
                }
            }

            MessageBox.Show("Files renamed successfully.");*/

            /* if (isSlideshowRunning)
             {
                 // Stop the slideshow
                 SlideshowTimer.Enabled = false;

                 // Wait for the slideshow to stop
                 while (SlideshowTimer.Enabled)
                 {
                     await Task.Delay(100);
                 }
             }

             string prefixToRemove = PrefixTextBox.Text.Trim();

             if (string.IsNullOrEmpty(prefixToRemove))
             {
                 MessageBox.Show("Please enter a prefix to remove.");
                 return;
             }

             foreach (object item in FilesListBox.Items)
             {
                 ReleaseImage(currentImageIndex);
                 await Task.Delay(200);

                 string filePath = item.ToString();
                 string directory = Path.GetDirectoryName(filePath);
                 string fileName = Path.GetFileName(filePath);

                 // Process the file name without the extension
                 string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

                 // Check if the file name starts with the prefix (case insensitive)
                 if (fileNameWithoutExtension.StartsWith(prefixToRemove, StringComparison.OrdinalIgnoreCase))
                 {
                     string extension = Path.GetExtension(fileName);

                     // Remove the prefix (including any leading hyphens)
                     fileNameWithoutExtension = fileNameWithoutExtension.Substring(prefixToRemove.Length).TrimStart('-');

                     // Combine the updated file name with the original extension
                     string newFileName = fileNameWithoutExtension + extension;

                     // Generate the new file path
                     string newFilePath = Path.Combine(directory, GetUniqueFileName(directory, newFileName, extension));

                     // Rename the file
                     File.Move(filePath, newFilePath);
                 }
             }

             MessageBox.Show("Files renamed successfully.");*/
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

        private void UpdatePictureBox(string imagePath)
        {
            if (File.Exists(imagePath) && IsImageFile(imagePath))
            {
                ImagePreviewPictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                ImagePreviewPictureBox.Image = null;
            }
        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp";
        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedIndex >= 0)
            {
                string selectedFilePath = FilesListBox.SelectedItem.ToString();
                UpdatePictureBox(selectedFilePath);
            }
        }

        private async void AddOrdinalNumbers_Click(object sender, EventArgs e)
        {
            // Check if the slideshow is running
            if (isSlideshowRunning)
            {
                // Stop the slideshow
                SlideshowTimer.Enabled = false;

                // Wait for the slideshow to stop
                while (SlideshowTimer.Enabled)
                {
                    await Task.Delay(100);
                }
            }

            fileCounter = 1; // Initialize fileCounter to 1

            foreach (object item in FilesListBox.Items)
            {
                string filePath = item.ToString();
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(fileName);

                // Release the currently displayed image
                ReleaseImage(currentImageIndex);

                // Wait for the image resources to be released
                await Task.Delay(200); // Adjust the delay as needed

                // Generate a new file name with an ordinal number
                string newFileName = fileCounter.ToString();

                string newFilePath = Path.Combine(directory, GetUniqueFileName(directory, newFileName, extension));

                // Change the file extension (if any) using Path.ChangeExtension
                fileName = Path.ChangeExtension(fileName, null);

                File.Move(filePath, newFilePath);

                // Increment the file counter for the next file
                fileCounter++;
            }

            MessageBox.Show("Ordinal numbers added to filenames successfully.");

            /*// Check if the slideshow is running
            if (isSlideshowRunning)
            {
                // Stop the slideshow
                SlideshowTimer.Enabled = false;

                // Wait for the slideshow to stop
                while (SlideshowTimer.Enabled)
                {
                    await Task.Delay(100);
                }
            }

            fileCounter = 1;

            foreach (object item in FilesListBox.Items)
            {
                string filePath = item.ToString();
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(fileName);

                // Release the currently displayed image
                ReleaseImage(currentImageIndex);

                // Wait for the image resources to be released
                await Task.Delay(200); // Adjust the delay as needed

                // Generate a new file name with an ordinal number
                string newFileName = fileCounter.ToString() + extension;
                fileCounter++;

                string newFilePath = Path.Combine(directory, GetUniqueFileName(directory, newFileName, extension));

                File.Move(filePath, newFilePath);
            }

            MessageBox.Show("Ordinal numbers added to filenames successfully.");*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartSlideshowButton_Click(object sender, EventArgs e)
        {
            currentImageIndex = 0;
            SlideshowTimer.Enabled = true; // Start the slideshow timer

            // Update the flag to indicate that the slideshow is running
            isSlideshowRunning = true;
        }

        private void StopSlideshowButton_Click(object sender, EventArgs e)
        {
            // Set the flag to stop the slideshow
            stopSlideshow = true;

            // Update the flag to indicate that the slideshow is stopped
            isSlideshowRunning = false;
        }

        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            if (stopSlideshow)
            {
                // Stop the slideshow by disabling the timer
                SlideshowTimer.Enabled = false;
                stopSlideshow = false; // Reset the flag

                // Release the currently displayed image
                ReleaseImage(currentImageIndex);

                return;
            }

            if (FilesListBox.Items.Count > 0)
            {
                // Increment the current image index
                currentImageIndex++;

                // Check if we have reached the end of the list of images
                if (currentImageIndex >= FilesListBox.Items.Count)
                {
                    currentImageIndex = 0; // Reset to the first image
                }

                // Display the next image in the PictureBox
                string nextImagePath = FilesListBox.Items[currentImageIndex].ToString();
                UpdatePictureBox(nextImagePath);

            }
        }
        private void ReleaseImage(int index)
        {
            if (index >= 0 && index < FilesListBox.Items.Count)
            {
                string imagePath = FilesListBox.Items[index].ToString();
                if (ImagePreviewPictureBox.Image != null)
                {
                    ImagePreviewPictureBox.Image.Dispose();
                    ImagePreviewPictureBox.Image = null;
                }

                GC.Collect(); // Explicitly request garbage collection to release the file lock
            }
        }

        private async void DeleteAllFilesButton_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Do you want to delete all files? \n(This will move your files into Recycle Bin.)",
                                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (isSlideshowRunning)
                {
                    // Stop the slideshow
                    SlideshowTimer.Enabled = false;

                    // Wait for the slideshow to stop
                    while (SlideshowTimer.Enabled)
                    {
                        await Task.Delay(100);
                    }
                }

                foreach (object item in FilesListBox.Items)
                {
                    ReleaseImage(currentImageIndex);
                    await Task.Delay(200);

                    string filePath = item.ToString();

                    try
                    {
                        File.Delete(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting file {filePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Clear the items from FilesListBox after deleting all files
                FilesListBox.Items.Clear();

                // Optionally, clear the PictureBox or do any other necessary cleanup
                ImagePreviewPictureBox.Image = null;

                MessageBox.Show("All files have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            FilesListBox.Items.Clear();
        }
    }
}
