using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class AddToMyWords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["Word"] != null && Session["Translation"] != null)
            {
                lbl1.Text = $"Word: {Session["Word"]}";
                lbl2.Text = $"Translation: {Session["Translation"]}";
            }
            else
            {
               // Response.Redirect("TranslationDisplay.aspx");
            }


        }
    }
}