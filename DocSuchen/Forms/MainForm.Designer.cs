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
            LabelFileCounter = new Label();
            ButtonPerformOCR = new Button();
            GroupBoxFileManager.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(890, 19);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(144, 31);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "DocSuchen";
            // 
            // ButtonUploadFile
            // 
            ButtonUploadFile.ForeColor = Color.Black;
            ButtonUploadFile.Location = new Point(15, 26);
            ButtonUploadFile.Name = "ButtonUploadFile";
            ButtonUploadFile.Size = new Size(87, 34);
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
            GroupBoxFileManager.Location = new Point(12, 12);
            GroupBoxFileManager.Name = "GroupBoxFileManager";
            GroupBoxFileManager.Size = new Size(413, 115);
            GroupBoxFileManager.TabIndex = 2;
            GroupBoxFileManager.TabStop = false;
            GroupBoxFileManager.Text = "File Manager";
            // 
            // LabelFileCounter
            // 
            LabelFileCounter.AutoSize = true;
            LabelFileCounter.Location = new Point(281, 26);
            LabelFileCounter.Name = "LabelFileCounter";
            LabelFileCounter.Size = new Size(115, 15);
            LabelFileCounter.TabIndex = 2;
            LabelFileCounter.Text = "Number of Files: 000";
            // 
            // ButtonPerformOCR
            // 
            ButtonPerformOCR.ForeColor = Color.Black;
            ButtonPerformOCR.Location = new Point(112, 26);
            ButtonPerformOCR.Name = "ButtonPerformOCR";
            ButtonPerformOCR.Size = new Size(103, 34);
            ButtonPerformOCR.TabIndex = 3;
            ButtonPerformOCR.Text = "Perform OCR";
            ButtonPerformOCR.UseVisualStyleBackColor = true;
            ButtonPerformOCR.Click += ButtonPerformOCR_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1046, 620);
            Controls.Add(GroupBoxFileManager);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "DocSuchen";
            GroupBoxFileManager.ResumeLayout(false);
            GroupBoxFileManager.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NameLabel;
        private Button ButtonUploadFile;
        private GroupBox GroupBoxFileManager;
        private Label LabelFileCounter;
        private Button ButtonPerformOCR;
    }
}
