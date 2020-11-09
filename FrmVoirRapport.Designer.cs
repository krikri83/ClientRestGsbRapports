namespace ClientRestGsbRapports
{
	partial class FrmVoirRapport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVoirRapport));
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbVisiteurs = new System.Windows.Forms.ComboBox();
			this.btnCharger = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(244, 114);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(544, 311);
			this.dataGridView3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Visiteurs";
			// 
			// cmbVisiteurs
			// 
			this.cmbVisiteurs.FormattingEnabled = true;
			this.cmbVisiteurs.Location = new System.Drawing.Point(32, 121);
			this.cmbVisiteurs.Name = "cmbVisiteurs";
			this.cmbVisiteurs.Size = new System.Drawing.Size(121, 21);
			this.cmbVisiteurs.TabIndex = 2;
			this.cmbVisiteurs.SelectedIndexChanged += new System.EventHandler(this.cmbVisiteurs_SelectedIndexChanged);
			// 
			// btnCharger
			// 
			this.btnCharger.Location = new System.Drawing.Point(32, 177);
			this.btnCharger.Name = "btnCharger";
			this.btnCharger.Size = new System.Drawing.Size(81, 27);
			this.btnCharger.TabIndex = 3;
			this.btnCharger.Text = "Charger";
			this.btnCharger.UseVisualStyleBackColor = true;
			this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(161, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(247, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Liste des rapports par visiteur";
			// 
			// FrmVoirRapport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCharger);
			this.Controls.Add(this.cmbVisiteurs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmVoirRapport";
			this.Text = "Voir Rapport";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbVisiteurs;
		private System.Windows.Forms.Button btnCharger;
		private System.Windows.Forms.Label label2;
	}
}