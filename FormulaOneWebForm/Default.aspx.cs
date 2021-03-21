using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FormulaOneDLL;

namespace FormulaOneWebForm
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Inizializzazioni che vengono eseguite solo la prima volta che carico la pagina
                //lblMessaggio.Text = "DIGITA USERNAME E PASSWORD, POI PREMI IL PULSANTE INVIA";
                lblMessaggio.Text = "Selezionare una voce dalla lista";
                //List<string> names = DBUtils.getTables();
                //DropDownList.DataSource = names;
                //DropDownList.DataBind();
                //DropDownList.Text = "";
                GetCountry();
            }
            else
            {
                //Elaborazioni da eseguire ogni volta che la pagina viene caricata
                //lbxData.DataSource = null;
            }
        }

        public void GetCountry(string isoCode = "")
        {
            HttpWebRequest apiRequest = WebRequest.Create("https://localhost:44312/api/Country/" + isoCode + "") as HttpWebRequest;
            string apiResponse = "";
            try
            {
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();
                    Country[] oCountry = Newtonsoft.Json.JsonConvert.DeserializeObject<Country[]>(apiResponse);
                    lbxNazioni.DataSource = oCountry;
                    lbxNazioni.DataBind();
                    lbxNazioni.Visible = true;
                }
            }
            catch (System.Net.WebException ex)
            {
                Console.Write(ex.Message);
            }
        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DBUtils myUtils = new DBUtils();
            //gridViewData.DataSource = myUtils.GetData(DropDownList.SelectedValue);
            //gridViewData.DataBind();
        }
    }
}