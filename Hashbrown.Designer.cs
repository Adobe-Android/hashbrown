namespace Hashbrown
{
    partial class Hashbrown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hashbrown));
            this.browseLabel = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.hashOutput = new System.Windows.Forms.TextBox();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.hashInput = new System.Windows.Forms.TextBox();
            this.verifyChecksumBtn = new System.Windows.Forms.Button();
            this.hashOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputTxtLabel = new System.Windows.Forms.Label();
            this.hashTypeMD5RadioButton = new System.Windows.Forms.RadioButton();
            this.hashTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.hashTypeSHA512RadioButton = new System.Windows.Forms.RadioButton();
            this.hashTypeCRC32RadioButton = new System.Windows.Forms.RadioButton();
            this.hashTypeSHA256RadioButton = new System.Windows.Forms.RadioButton();
            this.hashTypeSHA1RadioButton = new System.Windows.Forms.RadioButton();
            this.hashTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Location = new System.Drawing.Point(285, 35);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(202, 20);
            this.browseLabel.TabIndex = 0;
            this.browseLabel.Text = "Click Browse to Open a File";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(345, 90);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(80, 40);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // hashOutput
            // 
            this.hashOutput.Location = new System.Drawing.Point(10, 450);
            this.hashOutput.Multiline = true;
            this.hashOutput.Name = "hashOutput";
            this.hashOutput.ReadOnly = true;
            this.hashOutput.Size = new System.Drawing.Size(300, 150);
            this.hashOutput.TabIndex = 2;
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.AcceptsReturn = true;
            this.fileNameTxt.Location = new System.Drawing.Point(16, 160);
            this.fileNameTxt.MaxLength = 260;
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(750, 26);
            this.fileNameTxt.TabIndex = 3;
            // 
            // hashInput
            // 
            this.hashInput.Location = new System.Drawing.Point(460, 450);
            this.hashInput.Multiline = true;
            this.hashInput.Name = "hashInput";
            this.hashInput.Size = new System.Drawing.Size(300, 150);
            this.hashInput.TabIndex = 4;
            // 
            // verifyChecksumBtn
            // 
            this.verifyChecksumBtn.Enabled = false;
            this.verifyChecksumBtn.Location = new System.Drawing.Point(345, 500);
            this.verifyChecksumBtn.Name = "verifyChecksumBtn";
            this.verifyChecksumBtn.Size = new System.Drawing.Size(80, 40);
            this.verifyChecksumBtn.TabIndex = 5;
            this.verifyChecksumBtn.Text = "Verify";
            this.verifyChecksumBtn.UseVisualStyleBackColor = true;
            this.verifyChecksumBtn.Click += new System.EventHandler(this.verifyChecksumBtn_Click);
            // 
            // hashOutputLabel
            // 
            this.hashOutputLabel.AutoSize = true;
            this.hashOutputLabel.Location = new System.Drawing.Point(10, 410);
            this.hashOutputLabel.Name = "hashOutputLabel";
            this.hashOutputLabel.Size = new System.Drawing.Size(164, 20);
            this.hashOutputLabel.TabIndex = 6;
            this.hashOutputLabel.Text = "File Hash (Computed)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "File Hash (User Provided)";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(169, 690);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(480, 26);
            this.outputTextBox.TabIndex = 8;
            // 
            // outputTxtLabel
            // 
            this.outputTxtLabel.AutoSize = true;
            this.outputTxtLabel.Location = new System.Drawing.Point(355, 640);
            this.outputTxtLabel.Name = "outputTxtLabel";
            this.outputTxtLabel.Size = new System.Drawing.Size(58, 20);
            this.outputTxtLabel.TabIndex = 9;
            this.outputTxtLabel.Text = "Output";
            // 
            // hashTypeMD5RadioButton
            // 
            this.hashTypeMD5RadioButton.AutoSize = true;
            this.hashTypeMD5RadioButton.Location = new System.Drawing.Point(6, 25);
            this.hashTypeMD5RadioButton.Name = "hashTypeMD5RadioButton";
            this.hashTypeMD5RadioButton.Size = new System.Drawing.Size(68, 24);
            this.hashTypeMD5RadioButton.TabIndex = 10;
            this.hashTypeMD5RadioButton.Text = "MD5";
            this.hashTypeMD5RadioButton.UseVisualStyleBackColor = true;
            this.hashTypeMD5RadioButton.CheckedChanged += new System.EventHandler(this.hashTypeMD5RadioButton_CheckedChanged);
            // 
            // hashTypeGroupBox
            // 
            this.hashTypeGroupBox.Controls.Add(this.hashTypeSHA512RadioButton);
            this.hashTypeGroupBox.Controls.Add(this.hashTypeCRC32RadioButton);
            this.hashTypeGroupBox.Controls.Add(this.hashTypeSHA256RadioButton);
            this.hashTypeGroupBox.Controls.Add(this.hashTypeSHA1RadioButton);
            this.hashTypeGroupBox.Controls.Add(this.hashTypeMD5RadioButton);
            this.hashTypeGroupBox.Location = new System.Drawing.Point(289, 216);
            this.hashTypeGroupBox.Name = "hashTypeGroupBox";
            this.hashTypeGroupBox.Size = new System.Drawing.Size(200, 175);
            this.hashTypeGroupBox.TabIndex = 11;
            this.hashTypeGroupBox.TabStop = false;
            this.hashTypeGroupBox.Text = "Hash Type";
            // 
            // hashTypeSHA512RadioButton
            // 
            this.hashTypeSHA512RadioButton.AutoSize = true;
            this.hashTypeSHA512RadioButton.Location = new System.Drawing.Point(6, 115);
            this.hashTypeSHA512RadioButton.Name = "hashTypeSHA512RadioButton";
            this.hashTypeSHA512RadioButton.Size = new System.Drawing.Size(95, 24);
            this.hashTypeSHA512RadioButton.TabIndex = 14;
            this.hashTypeSHA512RadioButton.TabStop = true;
            this.hashTypeSHA512RadioButton.Text = "SHA512";
            this.hashTypeSHA512RadioButton.UseVisualStyleBackColor = true;
            this.hashTypeSHA512RadioButton.CheckedChanged += new System.EventHandler(this.hashTypeSHA512RadioButton_CheckedChanged);
            // 
            // hashTypeCRC32RadioButton
            // 
            this.hashTypeCRC32RadioButton.AutoSize = true;
            this.hashTypeCRC32RadioButton.Location = new System.Drawing.Point(6, 145);
            this.hashTypeCRC32RadioButton.Name = "hashTypeCRC32RadioButton";
            this.hashTypeCRC32RadioButton.Size = new System.Drawing.Size(86, 24);
            this.hashTypeCRC32RadioButton.TabIndex = 13;
            this.hashTypeCRC32RadioButton.Text = "CRC32";
            this.hashTypeCRC32RadioButton.UseVisualStyleBackColor = true;
            this.hashTypeCRC32RadioButton.CheckedChanged += new System.EventHandler(this.hashTypeCRC32RadioButton_CheckedChanged);
            // 
            // hashTypeSHA256RadioButton
            // 
            this.hashTypeSHA256RadioButton.AutoSize = true;
            this.hashTypeSHA256RadioButton.Location = new System.Drawing.Point(6, 85);
            this.hashTypeSHA256RadioButton.Name = "hashTypeSHA256RadioButton";
            this.hashTypeSHA256RadioButton.Size = new System.Drawing.Size(95, 24);
            this.hashTypeSHA256RadioButton.TabIndex = 12;
            this.hashTypeSHA256RadioButton.Text = "SHA256";
            this.hashTypeSHA256RadioButton.UseVisualStyleBackColor = true;
            this.hashTypeSHA256RadioButton.CheckedChanged += new System.EventHandler(this.hashTypeSHA256RadioButton_CheckedChanged);
            // 
            // hashTypeSHA1RadioButton
            // 
            this.hashTypeSHA1RadioButton.AutoSize = true;
            this.hashTypeSHA1RadioButton.Location = new System.Drawing.Point(6, 55);
            this.hashTypeSHA1RadioButton.Name = "hashTypeSHA1RadioButton";
            this.hashTypeSHA1RadioButton.Size = new System.Drawing.Size(77, 24);
            this.hashTypeSHA1RadioButton.TabIndex = 11;
            this.hashTypeSHA1RadioButton.Text = "SHA1";
            this.hashTypeSHA1RadioButton.UseVisualStyleBackColor = true;
            this.hashTypeSHA1RadioButton.CheckedChanged += new System.EventHandler(this.hashTypeSHA1RadioButton_CheckedChanged);
            // 
            // Hashbrown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Hashbrown.Properties.Resources.hashbrown_tiled;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.hashTypeGroupBox);
            this.Controls.Add(this.outputTxtLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hashOutputLabel);
            this.Controls.Add(this.verifyChecksumBtn);
            this.Controls.Add(this.hashInput);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.hashOutput);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.browseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hashbrown";
            this.Text = "Hashbrown";
            this.hashTypeGroupBox.ResumeLayout(false);
            this.hashTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox hashOutput;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.TextBox hashInput;
        private System.Windows.Forms.Button verifyChecksumBtn;
        private System.Windows.Forms.Label hashOutputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputTxtLabel;
        private System.Windows.Forms.RadioButton hashTypeMD5RadioButton;
        private System.Windows.Forms.GroupBox hashTypeGroupBox;
        private System.Windows.Forms.RadioButton hashTypeSHA1RadioButton;
        private System.Windows.Forms.RadioButton hashTypeSHA256RadioButton;
        private System.Windows.Forms.RadioButton hashTypeCRC32RadioButton;
        private System.Windows.Forms.RadioButton hashTypeSHA512RadioButton;
    }
}

