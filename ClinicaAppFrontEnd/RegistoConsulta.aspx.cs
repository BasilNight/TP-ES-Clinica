using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClinicaAppBO;
using ClinicaAppDA;
using ClinicaAppBR;

namespace ClinicaAppFrontEnd
{
    public partial class RegistoConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            Utilizador utilizadorExistente = new Utilizador();
            string email = Session["email"].ToString();
            string senha = Session["password"].ToString();

            if (email != null || senha != null)
            {
                utilizadorExistente = utilizadorRules.Login(email, senha);
                Label1.Text = "Agendar uma Consulta para: " + utilizadorExistente.Username;

            }
            
            Label6.Visible = false;
            if (Calendar1.SelectedDate.Date < DateTime.Today)
            {
                Label6.Visible = true;
            }

            List<Tratamento> listaTratamentos = new List<Tratamento>();
            List<Local> listaLocais = new List<Local>();

            TratamentoDA tratamento = new TratamentoDA(); // Trocar para business rules dps
            LocalDA local = new LocalDA();
            listaLocais = local.GetLocais();
            listaTratamentos = tratamento.GetTratamentos();


            DropDownList3.DataSource = listaLocais;
            DropDownList3.DataTextField = "Nome";
            DropDownList3.DataValueField = "ID";
            DropDownList3.DataBind();

            DropDownList4.DataSource = listaTratamentos;
            DropDownList4.DataTextField = "Descricao";
            DropDownList4.DataValueField = "ID";
            DropDownList4.DataBind();


        }
        

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate.Date < DateTime.Today)
            {
                Label6.Visible = true;
            }
            else
            {

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}