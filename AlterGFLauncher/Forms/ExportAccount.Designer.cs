
namespace AlterGFLauncher.Forms
{
    partial class ExportAccountForm
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
            this.components = new System.ComponentModel.Container();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportedStringRichTextBox = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(9, 7);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(291, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Importez le texte ci-dessous dans un autre AlterGFLauncher.\r\n";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // exportedStringRichTextBox
            // 
            this.exportedStringRichTextBox.Location = new System.Drawing.Point(12, 23);
            this.exportedStringRichTextBox.Name = "exportedStringRichTextBox";
            this.exportedStringRichTextBox.ReadOnly = true;
            this.exportedStringRichTextBox.Size = new System.Drawing.Size(291, 69);
            this.exportedStringRichTextBox.TabIndex = 3;
            this.exportedStringRichTextBox.Text = "";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(228, 97);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ExportAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 129);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.exportedStringRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExportAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exporter le compte";
            this.Load += new System.EventHandler(this.ExportAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox exportedStringRichTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}