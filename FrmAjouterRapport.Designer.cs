namespace ClientRestGsbRapports
{
	partial class FrmAjouterRapport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjouterRapport));
			this.label1 = new System.Windows.Forms.Label();
			this.cmbVisiteur = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lstMedecin = new System.Windows.Forms.ListBox();
			this.txtMedecin = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbFamille = new System.Windows.Forms.ComboBox();
			this.btnValider = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbQuantitee = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.BtnChosir = new System.Windows.Forms.Button();
			this.GrindVMedicament = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.btnEffacer = new System.Windows.Forms.Button();
			this.btnOffrir = new System.Windows.Forms.Button();
			this.txtMedicament = new System.Windows.Forms.TextBox();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.GrVOffrir = new System.Windows.Forms.DataGridView();
			this.medicaments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GrindVMedicament)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GrVOffrir)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(266, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ajouter Rapport";
			// 
			// cmbVisiteur
			// 
			this.cmbVisiteur.FormattingEnabled = true;
			this.cmbVisiteur.Location = new System.Drawing.Point(42, 81);
			this.cmbVisiteur.Name = "cmbVisiteur";
			this.cmbVisiteur.Size = new System.Drawing.Size(121, 21);
			this.cmbVisiteur.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Visiteur";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(245, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Médecin";
			// 
			// lstMedecin
			// 
			this.lstMedecin.FormattingEnabled = true;
			this.lstMedecin.Location = new System.Drawing.Point(248, 121);
			this.lstMedecin.Name = "lstMedecin";
			this.lstMedecin.Size = new System.Drawing.Size(131, 199);
			this.lstMedecin.TabIndex = 6;
			// 
			// txtMedecin
			// 
			this.txtMedecin.Location = new System.Drawing.Point(248, 82);
			this.txtMedecin.Name = "txtMedecin";
			this.txtMedecin.Size = new System.Drawing.Size(121, 20);
			this.txtMedecin.TabIndex = 7;
			this.txtMedecin.TextChanged += new System.EventHandler(this.txtMedecin_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Motif";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(42, 121);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(179, 107);
			this.richTextBox1.TabIndex = 10;
			this.richTextBox1.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(43, 258);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Bilan";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(42, 274);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(180, 131);
			this.richTextBox2.TabIndex = 12;
			this.richTextBox2.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(406, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Famille de Médicaments";
			// 
			// cmbFamille
			// 
			this.cmbFamille.FormattingEnabled = true;
			this.cmbFamille.Location = new System.Drawing.Point(405, 82);
			this.cmbFamille.Name = "cmbFamille";
			this.cmbFamille.Size = new System.Drawing.Size(127, 21);
			this.cmbFamille.TabIndex = 14;
			// 
			// btnValider
			// 
			this.btnValider.Location = new System.Drawing.Point(1010, 239);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(99, 51);
			this.btnValider.TabIndex = 16;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(923, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Quantitées du Médicaments :";
			// 
			// cmbQuantitee
			// 
			this.cmbQuantitee.FormattingEnabled = true;
			this.cmbQuantitee.Location = new System.Drawing.Point(926, 118);
			this.cmbQuantitee.Name = "cmbQuantitee";
			this.cmbQuantitee.Size = new System.Drawing.Size(67, 21);
			this.cmbQuantitee.TabIndex = 18;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(425, 363);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
			this.dateTimePicker1.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(422, 341);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Date de la visite :";
			// 
			// BtnChosir
			// 
			this.BtnChosir.Location = new System.Drawing.Point(550, 80);
			this.BtnChosir.Name = "BtnChosir";
			this.BtnChosir.Size = new System.Drawing.Size(75, 23);
			this.BtnChosir.TabIndex = 21;
			this.BtnChosir.Text = "Choisir";
			this.BtnChosir.UseVisualStyleBackColor = true;
			this.BtnChosir.Click += new System.EventHandler(this.button1_Click);
			// 
			// GrindVMedicament
			// 
			this.GrindVMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GrindVMedicament.Location = new System.Drawing.Point(405, 121);
			this.GrindVMedicament.Name = "GrindVMedicament";
			this.GrindVMedicament.Size = new System.Drawing.Size(293, 189);
			this.GrindVMedicament.TabIndex = 22;
			this.GrindVMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrindVMedicament_CellContentClick);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(726, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Pour Ajouter";
			// 
			// btnEffacer
			// 
			this.btnEffacer.Location = new System.Drawing.Point(1010, 321);
			this.btnEffacer.Name = "btnEffacer";
			this.btnEffacer.Size = new System.Drawing.Size(75, 33);
			this.btnEffacer.TabIndex = 25;
			this.btnEffacer.Text = "Effacer";
			this.btnEffacer.UseVisualStyleBackColor = true;
			this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
			// 
			// btnOffrir
			// 
			this.btnOffrir.Location = new System.Drawing.Point(1034, 105);
			this.btnOffrir.Name = "btnOffrir";
			this.btnOffrir.Size = new System.Drawing.Size(75, 36);
			this.btnOffrir.TabIndex = 26;
			this.btnOffrir.Text = "Offrir";
			this.btnOffrir.UseVisualStyleBackColor = true;
			this.btnOffrir.Click += new System.EventHandler(this.btnOffrir_Click);
			// 
			// txtMedicament
			// 
			this.txtMedicament.Location = new System.Drawing.Point(729, 119);
			this.txtMedicament.Name = "txtMedicament";
			this.txtMedicament.Size = new System.Drawing.Size(133, 20);
			this.txtMedicament.TabIndex = 27;
			// 
			// GrVOffrir
			// 
			this.GrVOffrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GrVOffrir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicaments,
            this.quantite});
			this.GrVOffrir.Location = new System.Drawing.Point(743, 219);
			this.GrVOffrir.Name = "GrVOffrir";
			this.GrVOffrir.Size = new System.Drawing.Size(240, 150);
			this.GrVOffrir.TabIndex = 3;
			// 
			// medicaments
			// 
			this.medicaments.HeaderText = "Medicament";
			this.medicaments.Name = "medicaments";
			// 
			// quantite
			// 
			this.quantite.HeaderText = "Quantiée";
			this.quantite.Name = "quantite";
			// 
			// FrmAjouterRapport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 450);
			this.Controls.Add(this.GrVOffrir);
			this.Controls.Add(this.txtMedicament);
			this.Controls.Add(this.btnOffrir);
			this.Controls.Add(this.btnEffacer);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.GrindVMedicament);
			this.Controls.Add(this.BtnChosir);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cmbQuantitee);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.cmbFamille);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMedecin);
			this.Controls.Add(this.lstMedecin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbVisiteur);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAjouterRapport";
			this.Text = "tex";
			((System.ComponentModel.ISupportInitialize)(this.GrindVMedicament)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GrVOffrir)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbVisiteur;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lstMedecin;
		private System.Windows.Forms.TextBox txtMedecin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbFamille;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbQuantitee;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button BtnChosir;
		private System.Windows.Forms.DataGridView GrindVMedicament;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnEffacer;
		private System.Windows.Forms.Button btnOffrir;
		private System.Windows.Forms.TextBox txtMedicament;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
		private System.Windows.Forms.DataGridView GrVOffrir;
		private System.Windows.Forms.DataGridViewTextBoxColumn medicaments;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
	}
}