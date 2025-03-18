using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hashbrown
{
    public partial class Hashbrown : Form
    {
        public Hashbrown()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            clearState();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "All files (*) | *.*",
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameTxt.Text = openFileDialog1.FileName;
            }
        }

        private void verifyChecksumBtn_Click(object sender, EventArgs e)
        {
            clearState();
            if (hashOutput.Text != string.Empty && hashInput.Text != string.Empty)
            {
                bool isEqual = hashOutput.Text.Equals(hashInput.Text.Trim(), StringComparison.InvariantCultureIgnoreCase);
                if (isEqual)
                {
                    outputTextBox.BackColor = Color.LightGreen;
                    outputTextBox.Text = "Verification Passed! The checksums match.";
                }
                else
                {
                    outputTextBox.BackColor = Color.Red;
                    outputTextBox.Text = "Verification Failed! The checksums do not match.";
                }
            }
            else
            {
                outputTextBox.BackColor = Color.LightYellow;
                outputTextBox.Text = "Please provide a hash to compare to.";
            }
        }

        private void hashTypeMD5RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearState();
            bool isEmpty = isFileNameEmpty();
            if (hashTypeMD5RadioButton.Checked && !isEmpty)
            {
                hashOutput.Text = CalculateHash.CalculateMD5(fileNameTxt.Text);
                verifyChecksumBtn.Enabled = true;
            }
        }

        private void hashTypeSHA1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearState();
            bool isEmpty = isFileNameEmpty();
            if (hashTypeSHA1RadioButton.Checked && !isEmpty)
            {
                hashOutput.Text = CalculateHash.CalculateSHA1(fileNameTxt.Text);
                verifyChecksumBtn.Enabled = true;
            }
        }

        private void hashTypeSHA256RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearState();
            bool isEmpty = isFileNameEmpty();
            if (hashTypeSHA256RadioButton.Checked && !isEmpty)
            {
                hashOutput.Text = CalculateHash.CalculateSHA256(fileNameTxt.Text);
                verifyChecksumBtn.Enabled = true;
            }
        }

        private void hashTypeSHA512RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearState();
            bool isEmpty = isFileNameEmpty();
            if (hashTypeSHA512RadioButton.Checked && !isEmpty)
            {
                hashOutput.Text = CalculateHash.CalculateSHA512(fileNameTxt.Text);
                verifyChecksumBtn.Enabled = true;
            }
        }

        private void hashTypeCRC32RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearState();
            bool isEmpty = isFileNameEmpty();
            if (hashTypeCRC32RadioButton.Checked && !isEmpty)
            {
                hashOutput.Text = CalculateHash.CalculateCRC32(fileNameTxt.Text);
                verifyChecksumBtn.Enabled = true;
            }
        }

        private void clearState()
        {
            outputTextBox.Text = string.Empty;
            outputTextBox.BackColor = Color.Empty;
        }

        private bool isFileNameEmpty()
        {
            if (string.IsNullOrEmpty(fileNameTxt.Text))
            {
                outputTextBox.BackColor = Color.LightYellow;
                outputTextBox.Text = "Please browse for a file before selecting the hash type.";
                return true;
            }
            return false;
        }
    }
}
