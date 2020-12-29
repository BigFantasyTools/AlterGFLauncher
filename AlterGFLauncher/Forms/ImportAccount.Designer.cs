
namespace AlterGFLauncher.Forms
{
    partial class ImportAccountForm
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
            this.importedStringRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // importedStringRichTextBox
            // 
            this.importedStringRichTextBox.Location = new System.Drawing.Point(12, 23);
            this.importedStringRichTextBox.Name = "importedStringRichTextBox";
            this.importedStringRichTextBox.Size = new System.Drawing.Size(295, 69);
            this.importedStringRichTextBox.TabIndex = 5;
            this.importedStringRichTextBox.Text = "";
            this.importedStringRichTextBox.TextChanged += new System.EventHandler(this.exportedStringRichTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(9, 7);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(96, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Texte d\'importation";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(151, 98);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Importer";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(232, 98);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ImportAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 129);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.importedStringRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importer un compte";
            this.Load += new System.EventHandler(this.ImportAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox importedStringRichTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button cancelButton;
    }
}