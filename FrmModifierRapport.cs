using mdlGsbRapports;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRestGsbRapports
{
	public partial class FrmModifierRapport : Form
	{
		private string site;
		private WebClient wb;
		private Secretaire laSecretaire;
		private string url;
		private Visiteur levisiteur;

		public FrmModifierRapport(Secretaire s)
		{
			InitializeComponent();
			this.laSecretaire = s;
			this.wb = new WebClient();
			this.site = "http://localhost/restGSB/";
			string h = this.laSecretaire.getHashTicketMdp();

			//charger le cmbVisiteur
			this.url = this.site + "visiteurs&ticket=" + h;
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);
			string visiteurs = d.visiteurs.ToString();
			string ticket = d.ticket;
			List<Visiteur> l = JsonConvert.DeserializeObject<List<Visiteur>>(visiteurs);
			this.cmbVisiteurs.DataSource = l;
			this.cmbVisiteurs.ValueMember = "id";
			this.cmbVisiteurs.DisplayMember = "nom";
			this.laSecretaire.ticket = ticket;

			
		}

		private void btnValider_Click(object sender, EventArgs e)
		{
			FrmRapportAmodifier l = new FrmRapportAmodifier(this.laSecretaire);
			l.txtDate.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
			l.txtVisiteur.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString() + " " + this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
			l.richTextBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
			l.rTBbilan.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
			l.Show();
		}

		


		private void btnCharger_Click(object sender, EventArgs e)
		{
			string h = this.laSecretaire.getHashTicketMdp();
			/*
			 * charger le gridview
			 * Sélectionner tous les rapports fait entre deux dates par un visiteur
				URL : <nom domaine>/gsbRapports/rapports?ticket=<ticket>&dateDebut=<date1>&dateFin=<date2>
				exemple :/rapports?ticket=4nblbv5zttybtvd3ygx&idVisiteur=A131&dateDebut=2018-9-1&dateFin=2019-1-1
			 */
			this.levisiteur = (Visiteur)this.cmbVisiteurs.SelectedItem;
			this.url = this.site + "rapports?ticket=" + h + "&idVisiteur=" + this.levisiteur.id + "&dateDebut=" + this.StartDate.Value.ToString()
				+ "&dateFin=" + this.EndDate.Value.ToString();
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);
			string rapports = d.rapports.ToString();
			string ticket = d.ticket;
			List<Rapport> l = JsonConvert.DeserializeObject<List<Rapport>>(rapports);
			this.dataGridView1.DataSource = l;
			this.laSecretaire.ticket = ticket;
		}
	}
}
