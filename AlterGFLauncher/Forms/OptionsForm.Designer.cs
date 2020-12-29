
namespace AlterGFLauncher.Forms
{
    partial class OptionsForm
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
            this.IdClientLabel = new System.Windows.Forms.Label();
            this.ExeGFLabel = new System.Windows.Forms.Label();
            this.ExeGFTextBox = new System.Windows.Forms.TextBox();
            this.browseExeGFButton = new System.Windows.Forms.Button();
            this.timeoutBeforeCodeLabel = new System.Windows.Forms.Label();
            this.timeoutBeforeCodeLabelNumeric = new System.Windows.Forms.NumericUpDown();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.saveOptionsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptionPasswordTextBox = new System.Windows.Forms.TextBox();
            this.encryptionCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutBeforeCodeLabelNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // IdClientLabel
            // 
            this.IdClientLabel.AutoSize = true;
            this.IdClientLabel.Location = new System.Drawing.Point(12, 13);
            this.IdClientLabel.Name = "IdClientLabel";
            this.IdClientLabel.Size = new System.Drawing.Size(59, 13);
            this.IdClientLabel.TabIndex = 0;
            this.IdClientLabel.Text = "Id du client";
            // 
            // ExeGFLabel
            // 
            this.ExeGFLabel.AutoSize = true;
            this.ExeGFLabel.Location = new System.Drawing.Point(12, 55);
            this.ExeGFLabel.Name = "ExeGFLabel";
            this.ExeGFLabel.Size = new System.Drawing.Size(77, 13);
            this.ExeGFLabel.TabIndex = 1;
            this.ExeGFLabel.Text = "Exécutable GF";
            // 
            // ExeGFTextBox
            // 
            this.ExeGFTextBox.Location = new System.Drawing.Point(16, 71);
            this.ExeGFTextBox.Name = "ExeGFTextBox";
            this.ExeGFTextBox.Size = new System.Drawing.Size(257, 20);
            this.ExeGFTextBox.TabIndex = 2;
            // 
            // browseExeGFButton
            // 
            this.browseExeGFButton.Location = new System.Drawing.Point(279, 70);
            this.browseExeGFButton.Name = "browseExeGFButton";
            this.browseExeGFButton.Size = new System.Drawing.Size(27, 23);
            this.browseExeGFButton.TabIndex = 3;
            this.browseExeGFButton.Text = "...";
            this.browseExeGFButton.UseVisualStyleBackColor = true;
            this.browseExeGFButton.Click += new System.EventHandler(this.browseExeGFButton_Click);
            // 
            // timeoutBeforeCodeLabel
            // 
            this.timeoutBeforeCodeLabel.AutoSize = true;
            this.timeoutBeforeCodeLabel.Location = new System.Drawing.Point(13, 95);
            this.timeoutBeforeCodeLabel.Name = "timeoutBeforeCodeLabel";
            this.timeoutBeforeCodeLabel.Size = new System.Drawing.Size(199, 13);
            this.timeoutBeforeCodeLabel.TabIndex = 4;
            this.timeoutBeforeCodeLabel.Text = "Temps maximal d\'attente pour connexion";
            // 
            // timeoutBeforeCodeLabelNumeric
            // 
            this.timeoutBeforeCodeLabelNumeric.Location = new System.Drawing.Point(16, 111);
            this.timeoutBeforeCodeLabelNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.timeoutBeforeCodeLabelNumeric.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.timeoutBeforeCodeLabelNumeric.Name = "timeoutBeforeCodeLabelNumeric";
            this.timeoutBeforeCodeLabelNumeric.Size = new System.Drawing.Size(290, 20);
            this.timeoutBeforeCodeLabelNumeric.TabIndex = 5;
            this.timeoutBeforeCodeLabelNumeric.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(16, 30);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(290, 20);
            this.idClientTextBox.TabIndex = 6;
            // 
            // saveOptionsButton
            // 
            this.saveOptionsButton.Location = new System.Drawing.Point(134, 176);
            this.saveOptionsButton.Name = "saveOptionsButton";
            this.saveOptionsButton.Size = new System.Drawing.Size(75, 23);
            this.saveOptionsButton.TabIndex = 7;
            this.saveOptionsButton.Text = "Enregistrer";
            this.saveOptionsButton.UseVisualStyleBackColor = true;
            this.saveOptionsButton.Click += new System.EventHandler(this.saveOptionsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(229, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mot de passe de sécurité";
            // 
            // encryptionPasswordTextBox
            // 
            this.encryptionPasswordTextBox.Location = new System.Drawing.Point(15, 151);
            this.encryptionPasswordTextBox.Name = "encryptionPasswordTextBox";
            this.encryptionPasswordTextBox.PasswordChar = '*';
            this.encryptionPasswordTextBox.Size = new System.Drawing.Size(197, 20);
            this.encryptionPasswordTextBox.TabIndex = 10;
            // 
            // encryptionCheckBox
            // 
            this.encryptionCheckBox.AutoSize = true;
            this.encryptionCheckBox.Location = new System.Drawing.Point(229, 153);
            this.encryptionCheckBox.Name = "encryptionCheckBox";
            this.encryptionCheckBox.Size = new System.Drawing.Size(59, 17);
            this.encryptionCheckBox.TabIndex = 11;
            this.encryptionCheckBox.Text = "Activer";
            this.encryptionCheckBox.UseVisualStyleBackColor = true;
            this.encryptionCheckBox.CheckedChanged += new System.EventHandler(this.encryptionCheckBox_CheckedChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 208);
            this.ControlBox = false;
            this.Controls.Add(this.encryptionCheckBox);
            this.Controls.Add(this.encryptionPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveOptionsButton);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.timeoutBeforeCodeLabelNumeric);
            this.Controls.Add(this.timeoutBeforeCodeLabel);
            this.Controls.Add(this.browseExeGFButton);
            this.Controls.Add(this.ExeGFTextBox);
            this.Controls.Add(this.ExeGFLabel);
            this.Controls.Add(this.IdClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeoutBeforeCodeLabelNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdClientLabel;
        private System.Windows.Forms.Label ExeGFLabel;
        private System.Windows.Forms.TextBox ExeGFTextBox;
        private System.Windows.Forms.Button browseExeGFButton;
        private System.Windows.Forms.Label timeoutBeforeCodeLabel;
        private System.Windows.Forms.NumericUpDown timeoutBeforeCodeLabelNumeric;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.Button saveOptionsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptionPasswordTextBox;
        private System.Windows.Forms.CheckBox encryptionCheckBox;
    }
}