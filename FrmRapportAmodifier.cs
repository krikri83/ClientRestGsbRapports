using mdlGsbRapports;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
	public partial class FrmRapportAmodifier : Form
	{
		private string site;
		private WebClient wb;
		private Secretaire laSecretaire;
		private string url;

		public FrmRapportAmodifier(Secretaire s)
		{
			InitializeComponent();
			this.laSecretaire = s;
			this.wb = new WebClient();
			this.site = "http://localhost/restGSB/";
			string h = this.laSecretaire.getHashTicketMdp();
			this.url = this.site + h;
		}

		private void btnValider_Click(object sender, EventArgs e)
		{
			try
			{
				this.url = this.site + "rapports";
			
			NameValueCollection parametres = new NameValueCollection();
			parametres.Add("motif", this.rTBbilan.Text);
			parametres.Add("bilan", this.richTextBox2.Text);
			parametres.Add("ticket", this.laSecretaire.getHashTicketMdp());

			

			byte[] tabByte = this.wb.UploadValues(url, "POST", parametres);
			string reponse = UnicodeEncoding.UTF8.GetString(tabByte);
			MessageBox.Show("Une rapport est modifié.");
			string ticket = reponse.Substring(2, reponse.Length - 2);
			this.laSecretaire.ticket = ticket;
			this.Close();
			}
			catch (WebException ex)
			{
				if (ex.Response is HttpWebResponse)
					MessageBox.Show(((HttpWebResponse) ex.Response).StatusCode.ToString());

			}
		}
	}
}
