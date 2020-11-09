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
	public partial class FrmVoirParMedecins : Form
	{
		private string site;
		private WebClient wb;
		private Secretaire laSecretaire;
		private string url;

		public FrmVoirParMedecins(Secretaire s)
		{
			InitializeComponent();
			this.laSecretaire = s;
			this.wb = new WebClient();
			this.site = "http://localhost/restGSB/";
			//URL : <nom domaine>/gsbRapports/medecins?ticket=<ticket>&nom=<debutNom>

		}

		private void txtMedecin_TextChanged(object sender, EventArgs e)
		{
			//gsbRapports/medecins?ticket=<ticket>&nom=<debutNom>
			string ch = this.txtMedecin.Text;
			string h = this.laSecretaire.getHashTicketMdp();

			if (ch.Length > 1)
			{
				this.url = this.site + "medecins?ticket=" + h + "&nom=" + ch;
				string data = this.wb.DownloadString(url);
				dynamic d = JsonConvert.DeserializeObject(data);
				string medecins = d.medecins.ToString();
				string ticket = d.ticket;
				List<Medecin> l = JsonConvert.DeserializeObject<List<Medecin>>(medecins);

				this.listMedecins.DataSource = l;
				this.listMedecins.DisplayMember = "nom";
				this.listMedecins.ValueMember = "id";
				this.laSecretaire.ticket = ticket;
			}
		}

		private void btnCharger_Click(object sender, EventArgs e)
		{
			//URL : <nom domaine>/gsbRapports/rapports?ticket=<ticket>&idMedecin=<id>
			string ch = this.listMedecins.SelectedValue.ToString();
			string h = this.laSecretaire.getHashTicketMdp();
			this.url = this.site + "rapports?ticket=" + h + "&idMedecin=" + ch;
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);
			string rapports = d.rapports.ToString();
			string ticket = d.ticket;
			List<Rapport> l = JsonConvert.DeserializeObject<List<Rapport>>(rapports);
			this.GridViewRapports.DataSource = l;
			this.laSecretaire.ticket = ticket;
		}

		private void btnEffacer_Click(object sender, EventArgs e)
		{
			this.GridViewRapports.DataSource = null;
			this.listMedecins.DataSource = null;
			this.txtMedecin.Clear();
			this.listMedecins.Items.Clear();
		}
	}
}
