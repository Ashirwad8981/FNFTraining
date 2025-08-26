using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class TranslationDisplay : System.Web.UI.Page
    {
        private static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // private Dictionary<string, string> translations;
            //private static Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //string word = txtBox1.Text.Trim().ToLower();

            //if (TranslationStore.Dictionary.ContainsKey(word))
            //{
            //    // Store word in session and redirect
            //    Session["Word"] = word;
            //    Session["Translation"] = TranslationStore.Dictionary[word];
            //    Response.Redirect("Result.aspx");
            //}
            //else
            //{
            //    lblMessage.Text = "Translation not found.";
            //}


            if (!IsPostBack && Request.QueryString["message"] != null)
            {
                lblMessage.Text = Request.QueryString["message"];
            }

        }

        protected void txtButton_Click(object sender, EventArgs e)
        {
            string word = txtBox1.Text.Trim().ToLower();

            if (TranslationStore.Dictionary.ContainsKey(word))
            {
                // Store word in session and redirect
                Session["Word"] = word;
                Session["Translation"] = TranslationStore.Dictionary[word];
                Response.Redirect("AddToMyWords.aspx");
            }
            else {

                {
                    // Redirect back with message
                    lblMessage.Text = "Translation not found";
                }
            }
        }
    }
}