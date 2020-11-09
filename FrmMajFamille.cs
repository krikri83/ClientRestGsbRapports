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
using System.Collections.Specialized;
using mdlGsbRapportsVisite;

namespace ClientRestGsbRapports
{
    public partial class FrmMajFamille : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private Famille laFamille;
		private string url;

        public FrmMajFamille(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
			string h = this.laSecretaire.getHashTicketMdp();
			this.url = this.site + "familles?ticket=" + h;
			string data = this.wb.DownloadString(url);
			dynamic d = JsonConvert.DeserializeObject(data);

			string familles = d.familles.ToString();
			string ticket = d.ticket;

			List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
			this.cmbFamille.DataSource = l;
			this.cmbFamille.DisplayMember = "libelle";
			this.laSecretaire.ticket = ticket;

		}

        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
			this.laFamille = (Famille)this.cmbFamille.SelectedItem; 
			this.txtFamille.Text = this.laFamille.libelle;
		}

		private void btnMaj_Click(object sender, EventArgs e)
        {
            try
            {
				this.url = this.site + "famille";
				NameValueCollection parametres = new NameValueCollection();
				parametres.Add("idFamille", this.laFamille.id);
				parametres.Add("libelle", this.txtFamille.Text);
				parametres.Add("ticket", this.laSecretaire.getHashTicketMdp());
				byte[] tabByte = this.wb.UploadValues(url, "POST", parametres);
				string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
				MessageBox.Show("Mise à jour effectuée");
				string ticket = reponse.Substring(2, reponse.Length-2);
				this.laSecretaire.ticket = ticket;
				this.Close();

			}
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());

            }
        }
    }
}
