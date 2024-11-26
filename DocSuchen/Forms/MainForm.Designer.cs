namespace DocSuchen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NameLabel = new Label();
            ButtonUploadFile = new Button();
            GroupBoxFileManager = new GroupBox();
            ButtonPerformOCR = new Button();
            LabelFileCounter = new Label();
            GroupBoxDirectories = new GroupBox();
            BoxDirectories = new ComboBox();
            LabelWorkingDirectory = new Label();
            GroupBoxFileManager.SuspendLayout();
            GroupBoxDirectories.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(1005, 25);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(177, 39);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "DocSuchen";
            // 
            // ButtonUploadFile
            // 
            ButtonUploadFile.ForeColor = Color.Black;
            ButtonUploadFile.Location = new Point(17, 35);
            ButtonUploadFile.Margin = new Padding(3, 4, 3, 4);
            ButtonUploadFile.Name = "ButtonUploadFile";
            ButtonUploadFile.Size = new Size(99, 45);
            ButtonUploadFile.TabIndex = 1;
            ButtonUploadFile.Text = "Upload File";
            ButtonUploadFile.UseVisualStyleBackColor = true;
            ButtonUploadFile.Click += ButtonUploadFile_Click;
            // 
            // GroupBoxFileManager
            // 
            GroupBoxFileManager.Controls.Add(ButtonPerformOCR);
            GroupBoxFileManager.Controls.Add(LabelFileCounter);
            GroupBoxFileManager.Controls.Add(ButtonUploadFile);
            GroupBoxFileManager.ForeColor = Color.White;
            GroupBoxFileManager.Location = new Point(14, 16);
            GroupBoxFileManager.Margin = new Padding(3, 4, 3, 4);
            GroupBoxFileManager.Name = "GroupBoxFileManager";
            GroupBoxFileManager.Padding = new Padding(3, 4, 3, 4);
            GroupBoxFileManager.Size = new Size(472, 153);
            GroupBoxFileManager.TabIndex = 2;
            GroupBoxFileManager.TabStop = false;
            GroupBoxFileManager.Text = "File Manager";
            // 
            // ButtonPerformOCR
            // 
            ButtonPerformOCR.ForeColor = Color.Black;
            ButtonPerformOCR.Location = new Point(128, 35);
            ButtonPerformOCR.Margin = new Padding(3, 4, 3, 4);
            ButtonPerformOCR.Name = "ButtonPerformOCR";
            ButtonPerformOCR.Size = new Size(118, 45);
            ButtonPerformOCR.TabIndex = 3;
            ButtonPerformOCR.Text = "Perform OCR";
            ButtonPerformOCR.UseVisualStyleBackColor = true;
            ButtonPerformOCR.Click += ButtonPerformOCR_Click;
            // 
            // LabelFileCounter
            // 
            LabelFileCounter.AutoSize = true;
            LabelFileCounter.Location = new Point(321, 35);
            LabelFileCounter.Name = "LabelFileCounter";
            LabelFileCounter.Size = new Size(145, 20);
            LabelFileCounter.TabIndex = 2;
            LabelFileCounter.Text = "Number of Files: 000";
            // 
            // GroupBoxDirectories
            // 
            GroupBoxDirectories.Controls.Add(BoxDirectories);
            GroupBoxDirectories.Controls.Add(LabelWorkingDirectory);
            GroupBoxDirectories.ForeColor = Color.White;
            GroupBoxDirectories.Location = new Point(520, 16);
            GroupBoxDirectories.Margin = new Padding(3, 4, 3, 4);
            GroupBoxDirectories.Name = "GroupBoxDirectories";
            GroupBoxDirectories.Padding = new Padding(3, 4, 3, 4);
            GroupBoxDirectories.Size = new Size(472, 99);
            GroupBoxDirectories.TabIndex = 4;
            GroupBoxDirectories.TabStop = false;
            GroupBoxDirectories.Text = "Directories";
            // 
            // BoxDirectories
            // 
            BoxDirectories.FormattingEnabled = true;
            BoxDirectories.Location = new Point(156, 33);
            BoxDirectories.Name = "BoxDirectories";
            BoxDirectories.Size = new Size(253, 28);
            BoxDirectories.TabIndex = 3;
            BoxDirectories.SelectedIndexChanged += BoxDirectories_SelectedIndexChanged;
            // 
            // LabelWorkingDirectory
            // 
            LabelWorkingDirectory.AutoSize = true;
            LabelWorkingDirectory.Location = new Point(18, 36);
            LabelWorkingDirectory.Name = "LabelWorkingDirectory";
            LabelWorkingDirectory.Size = new Size(132, 20);
            LabelWorkingDirectory.TabIndex = 2;
            LabelWorkingDirectory.Text = "Working Directory:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1195, 827);
            Controls.Add(GroupBoxDirectories);
            Controls.Add(GroupBoxFileManager);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "DocSuchen";
            GroupBoxFileManager.ResumeLayout(false);
            GroupBoxFileManager.PerformLayout();
            GroupBoxDirectories.ResumeLayout(false);
            GroupBoxDirectories.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NameLabel;
        private Button ButtonUploadFile;
        private GroupBox GroupBoxFileManager;
        private Label LabelFileCounter;
        private Button ButtonPerformOCR;
        private GroupBox GroupBoxDirectories;
        private Label LabelWorkingDirectory;
        private ComboBox BoxDirectories;
    }
}
