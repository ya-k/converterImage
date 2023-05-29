namespace Convert_Color_Picture_to_Grayscale
{
    partial class Form1
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
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBoxOpenFile = new System.Windows.Forms.PictureBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.pictureBoxSaveFile = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaveFile)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(912, 437);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(139, 49);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBoxOpenFile
            // 
            this.pictureBoxOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxOpenFile.BackColor = System.Drawing.Color.White;
            this.pictureBoxOpenFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOpenFile.Location = new System.Drawing.Point(45, 49);
            this.pictureBoxOpenFile.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxOpenFile.Name = "pictureBoxOpenFile";
            this.pictureBoxOpenFile.Size = new System.Drawing.Size(492, 339);
            this.pictureBoxOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpenFile.TabIndex = 3;
            this.pictureBoxOpenFile.TabStop = false;
            // 
            // convertButton
            // 
            this.convertButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.convertButton.Location = new System.Drawing.Point(552, 437);
            this.convertButton.Margin = new System.Windows.Forms.Padding(6);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(186, 68);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // pictureBoxSaveFile
            // 
            this.pictureBoxSaveFile.AccessibleDescription = "";
            this.pictureBoxSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSaveFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxSaveFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSaveFile.Location = new System.Drawing.Point(735, 49);
            this.pictureBoxSaveFile.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxSaveFile.Name = "pictureBoxSaveFile";
            this.pictureBoxSaveFile.Size = new System.Drawing.Size(492, 354);
            this.pictureBoxSaveFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSaveFile.TabIndex = 7;
            this.pictureBoxSaveFile.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.Location = new System.Drawing.Point(223, 437);
            this.openButton.Margin = new System.Windows.Forms.Padding(6);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(139, 49);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 557);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pictureBoxSaveFile);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.pictureBoxOpenFile);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(1278, 560);
            this.Name = "Form1";
            this.Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaveFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button saveButton;
        private PictureBox pictureBoxOpenFile;
        private Button convertButton;
        private PictureBox pictureBoxSaveFile;
        private Button openButton;
    }
}