using mdlGsbRapports;
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
using Newtonsoft.Json;

namespace ClientRestGsbRapports
{
	public partial class FrmVoirRapport : Form
	{
		private string site;
		private WebClient wb;
		private Secretaire laSecretaire;
		private string url;

		public FrmVoirRapport(Secretaire s)
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

		private void cmbVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void btnCharger_Click(object sender, EventArgs e)
		{
			//<nom domaine>/gsbRapports/rapports?ticket=<ticket>&idVisiteur=<id>
			string h = this.laSecretaire.getHashTicketMdp();
			Visiteur v = (Visiteur)this.cmbVisiteurs.SelectedItem;
			this.url = this.site + "rapports&ticket=" + h + "&idVisiteur=" + v.id;
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);
			string rapports = d.rapports.ToString();
			string ticket = d.ticket;
			List<Rapport> l = JsonConvert.DeserializeObject<List<Rapport>>(rapports);
			this.dataGridView3.DataSource = l;

			this.laSecretaire.ticket = ticket;
		}
	}
}
