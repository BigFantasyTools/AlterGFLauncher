
namespace AlterGFLauncher.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accountControlFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ajouterUnCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importerUnCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountControlFlowLayoutPanel
            // 
            this.accountControlFlowLayoutPanel.AutoScroll = true;
            this.accountControlFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountControlFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.accountControlFlowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.accountControlFlowLayoutPanel.Name = "accountControlFlowLayoutPanel";
            this.accountControlFlowLayoutPanel.Size = new System.Drawing.Size(303, 336);
            this.accountControlFlowLayoutPanel.TabIndex = 5;
            this.accountControlFlowLayoutPanel.WrapContents = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnCompteToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(303, 24);
            this.MenuStrip.TabIndex = 6;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ajouterUnCompteToolStripMenuItem
            // 
            this.ajouterUnCompteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.importerUnCompteToolStripMenuItem});
            this.ajouterUnCompteToolStripMenuItem.Name = "ajouterUnCompteToolStripMenuItem";
            this.ajouterUnCompteToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ajouterUnCompteToolStripMenuItem.Text = "Ajouter un compte";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Ajouter un compte";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // importerUnCompteToolStripMenuItem
            // 
            this.importerUnCompteToolStripMenuItem.Name = "importerUnCompteToolStripMenuItem";
            this.importerUnCompteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.importerUnCompteToolStripMenuItem.Text = "Importer un compte";
            this.importerUnCompteToolStripMenuItem.Click += new System.EventHandler(this.importerUnCompteToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 360);
            this.Controls.Add(this.accountControlFlowLayoutPanel);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterGFLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel accountControlFlowLayoutPanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importerUnCompteToolStripMenuItem;
    }
}

