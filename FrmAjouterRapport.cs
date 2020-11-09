using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // pour WbClient
using mdlGsbRapports;
using Newtonsoft.Json;
using mdlGsbRapportsVisite;
using System.Collections.Specialized;

namespace ClientRestGsbRapports
{
	public partial class FrmAjouterRapport : Form
	{
		private string site;
		private WebClient wb;
		private Secretaire laSecretaire;
		private string url;
		private Famille laFamille;
		

		public FrmAjouterRapport(Secretaire s)
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
			this.cmbVisiteur.DataSource = l;
			this.cmbVisiteur.ValueMember= "id";
			this.cmbVisiteur.DisplayMember = "nom";
			this.laSecretaire.ticket = ticket;
			

			//charger le cmbFamille
			//gsbRapports / familles ? ticket =< ticket >
			h = this.laSecretaire.getHashTicketMdp();
			this.url = this.site + "familles?ticket=" + h;
			data = this.wb.DownloadString(url);
			d = JsonConvert.DeserializeObject(data);
			string familles = d.familles.ToString();
			ticket = d.ticket;
			List<Famille> list = JsonConvert.DeserializeObject<List<Famille>>(familles);
			this.cmbFamille.DataSource = list;
			this.cmbFamille.ValueMember = "id";
			this.cmbFamille.DisplayMember = "libelle";
			this.laSecretaire.ticket = ticket;

			//charger le cmbQuantitée
			for (int i = 1; i <= 15; i++)
			{
				this.cmbQuantitee.Items.Add(i);
				
			}

			

		}
	
		//Rechercher le Medecin
		private void txtMedecin_TextChanged(object sender, EventArgs e)
		{
			//gsbRapports/medecins?ticket=<ticket>&nom=<debutNom>
			//gsbRapports/medecin/<id>?ticket=<ticket>
			string ch = this.txtMedecin.Text;
			string h = this.laSecretaire.getHashTicketMdp();
			
			if (ch.Length >1)
			{
				this.url = this.site + "medecins?ticket=" + h + "&nom=" + ch;
				string data = this.wb.DownloadString(url);
				dynamic d = JsonConvert.DeserializeObject(data);
				string medecins = d.medecins.ToString();
				string ticket = d.ticket;
				List<Medecin> l = JsonConvert.DeserializeObject<List<Medecin>>(medecins);
				
				this.lstMedecin.DataSource = l;
				this.lstMedecin.DisplayMember = "nom";
				this.lstMedecin.ValueMember = "id";
				this.laSecretaire.ticket = ticket;
			}
			
		}

		

		private void btnValider_Click(object sender, EventArgs e)
		{
			try
			{
				this.url = this.site + "rapports";
				DateTime date = this.dateTimePicker1.Value;
				NameValueCollection parametres = new NameValueCollection();
				parametres.Add("motif", this.richTextBox1.Text);
				parametres.Add("bilan", this.richTextBox2.Text);
				string me = this.lstMedecin.SelectedValue.ToString();
				string v = this.cmbVisiteur.SelectedValue.ToString();
				parametres.Add("idMedecin", me);
				parametres.Add("idVisiteur", v);
				string d = date.ToString("yyyy-MM-dd");
				parametres.Add("date",d );
				parametres.Add("ticket", this.laSecretaire.getHashTicketMdp());


				
				NameValueCollection medicaments = new NameValueCollection();
				
				int nb = this.GrVOffrir.RowCount;

				for(int i =0; i <nb-1; i++)
				{
					string m = this.GrVOffrir.Rows[i].Cells[0].Value.ToString();
					string q = this.GrVOffrir.Rows[i].Cells[1].Value.ToString();
					string med = "medicaments[" + m + "]";
					medicaments.Add(med, q);
				}


				
				
				parametres.Add(medicaments);

				byte[] tabByte = this.wb.UploadValues(url, "POST", parametres);
				string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
				MessageBox.Show("Ajouter une nouvelle Rapport est effectuée");
				string ticket = reponse.Substring(2, reponse.Length - 2);
				this.laSecretaire.ticket = ticket;
				this.Close();
			}
			catch (WebException ex)
			{
				if (ex.Response is HttpWebResponse)
					MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			//gsbRapports/medicaments?ticket=<ticket>&idFamille<id>
			string h = this.laSecretaire.getHashTicketMdp();
			this.laFamille = (Famille)this.cmbFamille.SelectedItem;
			this.url = this.site + "medicaments?ticket=" + h + "&idFamille=" + this.laFamille.id;
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);
			string medicaments = d.medicaments.ToString();
			string ticket = d.ticket;
			List<Medicament> l = JsonConvert.DeserializeObject<List<Medicament>>(medicaments);
			this.GrindVMedicament.DataSource = l;

			
			this.laSecretaire.ticket = ticket;
		}

		
		private void btnEffacer_Click(object sender, EventArgs e)
		{
			this.GrVOffrir.Controls.Clear();
			
		}


		private void GrindVMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.GrindVMedicament.Rows[e.RowIndex];
				if (row.Cells != null)
					
					this.txtMedicament.Text = row.Cells["id"].Value.ToString();
			}
		}

		private void btnOffrir_Click(object sender, EventArgs e)
		{
			this.GrVOffrir.Rows.Add(this.txtMedicament.Text, this.cmbQuantitee.SelectedItem);
			this.txtMedicament.Clear();
			
		}
	}
}
