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
using Newtonsoft.Json;          // pour la gestion du format Json
using mdlGsbRapportsVisite;

namespace ClientRestGsbRapports
{
    public partial class FrmVoirFamilles : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
		private string url;

		public FrmVoirFamilles(Secretaire s)
        {
            InitializeComponent();
			this.laSecretaire = s;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
			string h = this.laSecretaire.getHashTicketMdp();
			this.url = this.site + "familles?ticket=" + h;
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);
			//dynamic connais pas son type.
			//je separe les données du ticket et c"est avec le dynamic. 
			//Dynamic est le seul qui peut donner une type (d.familles et d.ticket)
			string familles = d.familles.ToString();
			string ticket = d.ticket;

			List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
			this.dataGridView2.DataSource = l;
			this.laSecretaire.ticket = ticket;
			
		}
    }
}
