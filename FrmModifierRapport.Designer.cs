namespace ClientRestGsbRapports
{
	partial class FrmModifierRapport
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnValider = new System.Windows.Forms.Button();
			this.cmbVisiteurs = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.StartDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.EndDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCharger = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(174, 106);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(401, 120);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(170, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Chosir un Rapport";
			// 
			// btnValider
			// 
			this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnValider.Location = new System.Drawing.Point(454, 244);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(121, 41);
			this.btnValider.TabIndex = 2;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
			// 
			// cmbVisiteurs
			// 
			this.cmbVisiteurs.FormattingEnabled = true;
			this.cmbVisiteurs.Location = new System.Drawing.Point(22, 106);
			this.cmbVisiteurs.Name = "cmbVisiteurs";
			this.cmbVisiteurs.Size = new System.Drawing.Size(122, 21);
			this.cmbVisiteurs.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Start date";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Visiteurs";
			// 
			// StartDate
			// 
			this.StartDate.Location = new System.Drawing.Point(105, 30);
			this.StartDate.Name = "StartDate";
			this.StartDate.Size = new System.Drawing.Size(200, 20);
			this.StartDate.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(331, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "End date";
			// 
			// EndDate
			// 
			this.EndDate.Location = new System.Drawing.Point(411, 32);
			this.EndDate.Name = "EndDate";
			this.EndDate.Size = new System.Drawing.Size(200, 20);
			this.EndDate.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(129, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Chosir les dates et le visiteur";
			// 
			// btnCharger
			// 
			this.btnCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCharger.Location = new System.Drawing.Point(22, 185);
			this.btnCharger.Name = "btnCharger";
			this.btnCharger.Size = new System.Drawing.Size(92, 41);
			this.btnCharger.TabIndex = 12;
			this.btnCharger.Text = "Charger";
			this.btnCharger.UseVisualStyleBackColor = true;
			this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
			// 
			// FrmModifierRapport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 326);
			this.Controls.Add(this.btnCharger);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.EndDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.StartDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbVisiteurs);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FrmModifierRapport";
			this.Text = "FrmModifierRapport";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.ComboBox cmbVisiteurs;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker StartDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker EndDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCharger;
	}
}