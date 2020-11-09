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


namespace ClientRestGsbRapports
{
    public partial class FrmNewFamille : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
		private string url;

		public FrmNewFamille(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
				this.url = this.site + "familles";
				NameValueCollection parametres = new NameValueCollection();
				parametres.Add("idFamille", this.txtId.Text);
				parametres.Add("libelle", this.txtLibelle.Text);
				parametres.Add("ticket", this.laSecretaire.getHashTicketMdp());
				byte[] tabByte = this.wb.UploadValues(url, "POST", parametres);
				string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
				MessageBox.Show("Ajouter une nouvelle famille est effectuée");
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
    }
}
