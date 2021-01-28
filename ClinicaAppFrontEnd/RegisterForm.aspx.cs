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
    public partial class RegisterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            List<Perfil> listaPerfis = new List<Perfil>();

            listaPerfis = utilizadorRules.GetPerfils();

            DropDownList1.DataSource = listaPerfis;
            DropDownList1.DataTextField = "Titulo";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            Utilizador novoUtilizador = new Utilizador();

            novoUtilizador.Username = TextBox2.Text;
            novoUtilizador.Senha = TextBox3.Text;
            novoUtilizador.Email = TextBox5.Text;
            novoUtilizador.DataNasc = DateTime.Parse(date.Text);
            novoUtilizador.Nif = int.Parse(TextBox4.Text);
            novoUtilizador.IdPerfil = int.Parse(DropDownList1.SelectedValue);

            if(utilizadorRules.RegistarUtilizador(novoUtilizador) == true)
            {
                Response.Redirect("Default.aspx");
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}