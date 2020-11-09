using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mdlGsbRapports;
using System.Net; // pour WbClient
using Newtonsoft.Json;


namespace ClientRestGsbRapports
{
	public partial class FrmVoirVisiteurs : Form
	{
		private Secretaire laSecretaire;
		private string site;
		private WebClient wb;
		private string url;
	
		public FrmVoirVisiteurs(Secretaire s)
		{
			InitializeComponent();
			this.laSecretaire = s;
			this.wb = new WebClient();
			this.site = "http://localhost/restGSB/";
			string h = this.laSecretaire.getHashTicketMdp();
			this.url = this.site + "visiteurs&ticket=" + h;
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);
			//dynamic connais pas son type.
			//je separe dynamic d et donner une type (d.familles et d.ticket)
			string visiteurs = d.visiteurs.ToString();
			string ticket = d.ticket;

			List<Visiteur> l = JsonConvert.DeserializeObject<List<Visiteur>>(visiteurs);
			this.dataGridView1.DataSource = l;
			this.laSecretaire.ticket = ticket;
		}
	}
}
