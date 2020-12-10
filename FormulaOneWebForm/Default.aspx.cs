using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormulaOneDLL;

namespace FormulaOneWebForm {
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            if (!Page.IsPostBack) {
                //Inizializzazioni che vengono eseguite solo la prima volta che carico la pagina
                //lblMessaggio.Text = "DIGITA USERNAME E PASSWORD, POI PREMI IL PULSANTE INVIA";
                lblMessaggio.Text = "PREMI IL PULSANTE INVIA, apparirà la lista delle nazioni gestite.";
            }
            else {
                //Elaborazioni da eseguire ogni volta che la pagina viene caricata
                //lblMessaggio.Text = "Benvenuto al sig. " + txtUserName.Text;
                //Riempio la lista delle nazioni
                DBUtils myUtils = new DBUtils();
                lbxNazioni.DataSource = myUtils.GetCountries();
                lbxNazioni.DataBind();
            }
        }
    }
}