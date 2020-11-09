namespace ClientRestGsbRapports
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.LblLogin = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMdp = new System.Windows.Forms.TextBox();
			this.btnValider = new System.Windows.Forms.Button();
			this.lblNom = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.médecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.voirLesRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voirParMedecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(95, 86);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(100, 20);
			this.txtLogin.TabIndex = 1;
			// 
			// LblLogin
			// 
			this.LblLogin.AutoSize = true;
			this.LblLogin.Location = new System.Drawing.Point(12, 93);
			this.LblLogin.Name = "LblLogin";
			this.LblLogin.Size = new System.Drawing.Size(33, 13);
			this.LblLogin.TabIndex = 2;
			this.LblLogin.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mot de passe";
			// 
			// txtMdp
			// 
			this.txtMdp.Location = new System.Drawing.Point(95, 133);
			this.txtMdp.Name = "txtMdp";
			this.txtMdp.Size = new System.Drawing.Size(100, 20);
			this.txtMdp.TabIndex = 4;
			// 
			// btnValider
			// 
			this.btnValider.Location = new System.Drawing.Point(95, 198);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(75, 23);
			this.btnValider.TabIndex = 5;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
			// 
			// lblNom
			// 
			this.lblNom.AutoSize = true;
			this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNom.Location = new System.Drawing.Point(15, 33);
			this.lblNom.Name = "lblNom";
			this.lblNom.Size = new System.Drawing.Size(2, 15);
			this.lblNom.TabIndex = 6;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.médecinsToolStripMenuItem,
            this.rapportsToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.visiteursToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.rapportToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(697, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
			// 
			// médecinsToolStripMenuItem
			// 
			this.médecinsToolStripMenuItem.Name = "médecinsToolStripMenuItem";
			this.médecinsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.médecinsToolStripMenuItem.Text = "Médecins";
			// 
			// rapportsToolStripMenuItem
			// 
			this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
			this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.rapportsToolStripMenuItem.Text = "Visites";
			// 
			// médicamentsToolStripMenuItem
			// 
			this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
			this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.médicamentsToolStripMenuItem.Text = "Médicaments";
			// 
			// visiteursToolStripMenuItem
			// 
			this.visiteursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem1});
			this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
			this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.visiteursToolStripMenuItem.Text = "Visiteurs";
			// 
			// voirToolStripMenuItem1
			// 
			this.voirToolStripMenuItem1.Name = "voirToolStripMenuItem1";
			this.voirToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
			this.voirToolStripMenuItem1.Text = "Voir";
			this.voirToolStripMenuItem1.Click += new System.EventHandler(this.voirToolStripMenuItem1_Click);
			// 
			// familleToolStripMenuItem
			// 
			this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.ajouterToolStripMenuItem});
			this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
			this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.familleToolStripMenuItem.Text = "Famille";
			// 
			// voirToolStripMenuItem
			// 
			this.voirToolStripMenuItem.Name = "voirToolStripMenuItem";
			this.voirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.voirToolStripMenuItem.Text = "Voir";
			this.voirToolStripMenuItem.Click += new System.EventHandler(this.voirToolStripMenuItem_Click);
			// 
			// modifierToolStripMenuItem
			// 
			this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
			this.modifierToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.modifierToolStripMenuItem.Text = "Modifier";
			this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
			// 
			// ajouterToolStripMenuItem
			// 
			this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
			this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.ajouterToolStripMenuItem.Text = "Ajouter";
			this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
			// 
			// aideToolStripMenuItem
			// 
			this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
			this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
			this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.aideToolStripMenuItem.Text = "&Aide";
			// 
			// sommaireToolStripMenuItem
			// 
			this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
			this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.sommaireToolStripMenuItem.Text = "&Sommaire";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.indexToolStripMenuItem.Text = "&Index";
			// 
			// rechercherToolStripMenuItem
			// 
			this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
			this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.rechercherToolStripMenuItem.Text = "&Rechercher";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
			// 
			// àproposdeToolStripMenuItem
			// 
			this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
			this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.àproposdeToolStripMenuItem.Text = "À &propos de...";
			// 
			// rapportToolStripMenuItem
			// 
			this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1,
            this.voirLesRapportToolStripMenuItem,
            this.voirParMedecinsToolStripMenuItem});
			this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
			this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.rapportToolStripMenuItem.Text = "Rapport";
			// 
			// ajouterToolStripMenuItem1
			// 
			this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
			this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.ajouterToolStripMenuItem1.Text = "Ajouter";
			this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
			// 
			// modifierToolStripMenuItem1
			// 
			this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
			this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.modifierToolStripMenuItem1.Text = "Modifier";
			this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
			// 
			// voirLesRapportToolStripMenuItem
			// 
			this.voirLesRapportToolStripMenuItem.Name = "voirLesRapportToolStripMenuItem";
			this.voirLesRapportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.voirLesRapportToolStripMenuItem.Text = "Voir les rapport";
			this.voirLesRapportToolStripMenuItem.Click += new System.EventHandler(this.voirLesRapportToolStripMenuItem_Click);
			// 
			// voirParMedecinsToolStripMenuItem
			// 
			this.voirParMedecinsToolStripMenuItem.Name = "voirParMedecinsToolStripMenuItem";
			this.voirParMedecinsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.voirParMedecinsToolStripMenuItem.Text = "Voir par Medecins";
			this.voirParMedecinsToolStripMenuItem.Click += new System.EventHandler(this.voirParMedecinsToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 261);
			this.Controls.Add(this.lblNom);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.txtMdp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LblLogin);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Gestion des rapports de visite";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem voirLesRapportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem voirParMedecinsToolStripMenuItem;
	}
}

