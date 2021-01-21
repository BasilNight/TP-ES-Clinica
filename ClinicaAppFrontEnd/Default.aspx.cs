using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClinicaAppBO;
using ClinicaAppBR;


namespace ClinicaAppFrontEnd
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            string email = ((TextBox)Login1.FindControl("UserName")).Text;
            string senha = ((TextBox)Login1.FindControl("Password")).Text;

            if (utilizadorRules.Login(email, senha) != null)
            {
                Session["Valor"] = ((TextBox)Login1.FindControl("UserName")).Text;
                Response.Redirect("MenuPrincipal.aspx");
            }

            //Response.Redirect("RegisterForm.aspx");
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}