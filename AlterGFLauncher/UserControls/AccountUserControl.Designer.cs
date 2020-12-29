
namespace AlterGFLauncher
{
    partial class AccountUserControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomDeCompte = new System.Windows.Forms.Label();
            this.ButtonDemarrerJeu = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomDeCompte
            // 
            this.nomDeCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomDeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomDeCompte.Location = new System.Drawing.Point(0, 2);
            this.nomDeCompte.Name = "nomDeCompte";
            this.nomDeCompte.Size = new System.Drawing.Size(297, 30);
            this.nomDeCompte.TabIndex = 1;
            this.nomDeCompte.Text = "nomDeCompte";
            this.nomDeCompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonDemarrerJeu
            // 
            this.ButtonDemarrerJeu.Location = new System.Drawing.Point(12, 35);
            this.ButtonDemarrerJeu.Name = "ButtonDemarrerJeu";
            this.ButtonDemarrerJeu.Size = new System.Drawing.Size(83, 23);
            this.ButtonDemarrerJeu.TabIndex = 2;
            this.ButtonDemarrerJeu.Text = "Démarrer";
            this.ButtonDemarrerJeu.UseVisualStyleBackColor = true;
            this.ButtonDemarrerJeu.Click += new System.EventHandler(this.ButtonDemarrerJeu_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.ForeColor = System.Drawing.Color.Red;
            this.deletebutton.Location = new System.Drawing.Point(106, 35);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(83, 23);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "Supprimer";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exportButton.Location = new System.Drawing.Point(200, 35);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(83, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Exporter";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // AccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.ButtonDemarrerJeu);
            this.Controls.Add(this.nomDeCompte);
            this.MaximumSize = new System.Drawing.Size(297, 73);
            this.MinimumSize = new System.Drawing.Size(297, 73);
            this.Name = "AccountUserControl";
            this.Size = new System.Drawing.Size(297, 73);
            this.Load += new System.EventHandler(this.CompteUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nomDeCompte;
        private System.Windows.Forms.Button ButtonDemarrerJeu;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button exportButton;
    }
}
