namespace ClientRestGsbRapports
{
	partial class FrmVoirParMedecins
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVoirParMedecins));
			this.label1 = new System.Windows.Forms.Label();
			this.txtMedecin = new System.Windows.Forms.TextBox();
			this.btnCharger = new System.Windows.Forms.Button();
			this.GridViewRapports = new System.Windows.Forms.DataGridView();
			this.listMedecins = new System.Windows.Forms.ListBox();
			this.btnEffacer = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GridViewRapports)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Le Médecin :";
			// 
			// txtMedecin
			// 
			this.txtMedecin.Location = new System.Drawing.Point(48, 59);
			this.txtMedecin.Name = "txtMedecin";
			this.txtMedecin.Size = new System.Drawing.Size(100, 20);
			this.txtMedecin.TabIndex = 1;
			this.txtMedecin.TextChanged += new System.EventHandler(this.txtMedecin_TextChanged);
			// 
			// btnCharger
			// 
			this.btnCharger.Location = new System.Drawing.Point(48, 247);
			this.btnCharger.Name = "btnCharger";
			this.btnCharger.Size = new System.Drawing.Size(75, 23);
			this.btnCharger.TabIndex = 3;
			this.btnCharger.Text = "Charger";
			this.btnCharger.UseVisualStyleBackColor = true;
			this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
			// 
			// GridViewRapports
			// 
			this.GridViewRapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridViewRapports.Location = new System.Drawing.Point(205, 59);
			this.GridViewRapports.Name = "GridViewRapports";
			this.GridViewRapports.Size = new System.Drawing.Size(410, 200);
			this.GridViewRapports.TabIndex = 4;
			// 
			// listMedecins
			// 
			this.listMedecins.FormattingEnabled = true;
			this.listMedecins.Location = new System.Drawing.Point(48, 106);
			this.listMedecins.Name = "listMedecins";
			this.listMedecins.Size = new System.Drawing.Size(127, 121);
			this.listMedecins.TabIndex = 5;
			// 
			// btnEffacer
			// 
			this.btnEffacer.Location = new System.Drawing.Point(48, 276);
			this.btnEffacer.Name = "btnEffacer";
			this.btnEffacer.Size = new System.Drawing.Size(75, 23);
			this.btnEffacer.TabIndex = 6;
			this.btnEffacer.Text = "Effacer";
			this.btnEffacer.UseVisualStyleBackColor = true;
			this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(201, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Les Rapports :";
			// 
			// FrmVoirParMedecins
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 331);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEffacer);
			this.Controls.Add(this.listMedecins);
			this.Controls.Add(this.GridViewRapports);
			this.Controls.Add(this.btnCharger);
			this.Controls.Add(this.txtMedecin);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmVoirParMedecins";
			this.Text = "FormVoirParMedecins";
			((System.ComponentModel.ISupportInitialize)(this.GridViewRapports)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMedecin;
		private System.Windows.Forms.Button btnCharger;
		private System.Windows.Forms.DataGridView GridViewRapports;
		private System.Windows.Forms.ListBox listMedecins;
		private System.Windows.Forms.Button btnEffacer;
		private System.Windows.Forms.Label label2;
	}
}