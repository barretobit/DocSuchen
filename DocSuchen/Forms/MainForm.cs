using DocSuchen.Controllers;
using DocSuchen.Models;

namespace DocSuchen
{
    public partial class MainForm : Form
    {
        public readonly string PATH = @"C:\RandomBit\DocSuchen";
        public MainForm()
        {
            InitializeComponent();
            LabelFileCounter.Text = $"Number of Files: {FileController.CountFilesInFolder(PATH).ToString("D3")}";
            Config configFile = SystemController.LoadConfig(PATH);
            ManageBoxDirectoriesOnStartup(configFile);
        }

        private void ManageBoxDirectoriesOnStartup(Config configFile)
        {
            BoxDirectories.Items.Clear();
            BoxDirectories.Items.AddRange([.. configFile.AvailableDirectories!]);
            
            if (!string.IsNullOrEmpty(configFile.WorkingDirectory) && configFile.AvailableDirectories!.Contains(configFile.WorkingDirectory))
            {
                BoxDirectories.SelectedItem = configFile.WorkingDirectory;
            }

        }

        private void ButtonUploadFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog.Title = "Select a PDF file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    string sourceFilePath = openFileDialog.FileName;

                    if (!Directory.Exists(PATH))
                    {
                        Directory.CreateDirectory(PATH);
                    }

                    string uniqueFileName = Guid.NewGuid().ToString() + ".pdf";
                    string targetFilePath = Path.Combine(PATH, uniqueFileName);
                    System.IO.File.Copy(sourceFilePath, targetFilePath);

                    LabelFileCounter.Text = $"Number of Files: {FileController.CountFilesInFolder(PATH).ToString("D3")}";

                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("PDF uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonPerformOCR_Click(object sender, EventArgs e)
        {
            try
            {
                Task ocrResult = OCRController.ProcessPdfFolder(PATH);

                MessageBox.Show("OCR completed. Text files have been saved in the target folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during OCR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BoxDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config config = SystemController.LoadConfig(PATH);
            config.WorkingDirectory = BoxDirectories.SelectedItem!.ToString();
            SystemController.UpdateConfig(PATH, config);
        }
    }
}