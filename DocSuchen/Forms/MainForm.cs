using DocSuchen.Controllers;

namespace DocSuchen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string targetFolder = @"C:\RandomBit\DocSuchen";
            LabelFileCounter.Text = $"Number of Files: {FileController.CountFilesInFolder(targetFolder).ToString("D3")}";
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
                    string targetFolder = @"C:\RandomBit\DocSuchen";

                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    string uniqueFileName = Guid.NewGuid().ToString() + ".pdf";
                    string targetFilePath = Path.Combine(targetFolder, uniqueFileName);
                    File.Copy(sourceFilePath, targetFilePath);

                    LabelFileCounter.Text = $"Number of Files: {FileController.CountFilesInFolder(targetFolder).ToString("D3")}";

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
                string targetFolder = @"C:\RandomBit\DocSuchen";

                Task ocrResult = OCRController.ProcessPdfFolder(targetFolder);

                MessageBox.Show("OCR completed. Text files have been saved in the target folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during OCR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}