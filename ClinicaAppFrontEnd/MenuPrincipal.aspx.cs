using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClinicaAppBR;
using ClinicaAppBO;

namespace ClinicaAppFrontEnd
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        Utilizador utilizadorExistente;

        protected void Page_Load(object sender, EventArgs e)
        {
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            this.utilizadorExistente = new Utilizador();
            string email = Session["email_login"].ToString();
            string senha = Session["password_login"].ToString();

            if (email != null || senha != null)
            {
                this.utilizadorExistente = utilizadorRules.Login(email, senha);
                Label2.Text = "Bem Vindo " + utilizadorExistente.Username;

            }
            //Session["Valor"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            string email = utilizadorExistente.Email;
            string senha = utilizadorExistente.Senha;

            Session["email"] = email;
            Session["password"] = senha;
            Server.Transfer("RegistoConsulta.aspx");
            Response.Redirect("RegistoConsulta.aspx");
        }
    }
}