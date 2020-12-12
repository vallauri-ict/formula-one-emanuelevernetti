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
                lblMessaggio.Text = "Selezionare una voce dalla lista";
                DropDownList.Items.Add("");
                DropDownList.Items.Add("Countries");
                DropDownList.Items.Add("Teams");
                DropDownList.Items.Add("Drivers");
            }
            else {
                //Elaborazioni da eseguire ogni volta che la pagina viene caricata
                lbxNazioni.DataSource = null;
            }
        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e) {
            if (DropDownList.Items.Contains(DropDownList.Items.FindByText(""))) {
                DropDownList.Items.Remove("");
            }
            switch (DropDownList.SelectedValue) {
                case "Countries": {
                        DBUtils myUtils = new DBUtils();
                        lbxNazioni.DataSource = myUtils.GetCountries();
                        lbxNazioni.DataBind();
                        break;
                    }
                case "Teams": {
                        DBUtils myUtils = new DBUtils();
                        lbxNazioni.DataSource = myUtils.GetTeams();
                        lbxNazioni.DataBind();
                        break;
                    }
                case "Drivers": {
                        DBUtils myUtils = new DBUtils();
                        lbxNazioni.DataSource = myUtils.GetDrivers();
                        lbxNazioni.DataBind();
                        break;
                    }
            }
        }
    }
}