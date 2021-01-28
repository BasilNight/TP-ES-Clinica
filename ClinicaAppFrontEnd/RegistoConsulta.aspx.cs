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
        Utilizador utilizadorExistente;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label9.Visible = false;
            Label8.Visible = false;
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            this.utilizadorExistente = new Utilizador();
            string email = Session["email"].ToString();
            string senha = Session["password"].ToString();

            if (email != null || senha != null)
            {
                this.utilizadorExistente = utilizadorRules.Login(email, senha);
                Label1.Text = "Agendar uma Consulta para: " + utilizadorExistente.Username;

            }
            
            Label6.Visible = false;
            if (Calendar1.SelectedDate.Date < DateTime.Today)
            {
                Label6.Visible = true;
            }

            List<Tratamento> listaTratamentos = new List<Tratamento>();
            List<Local> listaLocais = new List<Local>();
            List<Utilizador> listaFisioterapeutas = new List<Utilizador>();

            
            ConsultaRules consultaRules = new ConsultaRules();
            listaLocais = consultaRules.GetLocais();
            listaTratamentos = consultaRules.GetTratamentos();

            if (!Page.IsPostBack)
            {
                DropDownList2.DataSource = listaLocais;
                DropDownList2.DataTextField = "Nome";
                DropDownList2.DataValueField = "ID";
                DropDownList2.DataBind();

                DropDownList4.DataSource = listaTratamentos;
                DropDownList4.DataTextField = "Descricao";
                DropDownList4.DataValueField = "ID";
                DropDownList4.DataBind();

                listaFisioterapeutas = utilizadorRules.GetFisioterapeutas();
                DropDownList1.DataSource = listaFisioterapeutas;
                DropDownList1.DataTextField = "Username";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
            }
        }
        

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label9.Visible = false;
            Label8.Visible = false;
            List<DateTime> listaDatasDisp = new List<DateTime>();
            List<string> listaHorasDisp = new List<string>();
            listaDatasDisp.Clear();
            listaHorasDisp.Clear();
            DropDownList5.Items.Clear();
            
            if (Calendar1.SelectedDate.Date <= DateTime.Today)
            {
                Label6.Visible = true;
            }
            else
            {
                ConsultaRules consultaRules = new ConsultaRules();


                listaDatasDisp = consultaRules.GetConsultasDisp(Calendar1.SelectedDate, Convert.ToInt32(DropDownList2.SelectedValue), Convert.ToInt32(DropDownList1.SelectedValue));

                foreach(DateTime data in listaDatasDisp)
                {
                    listaHorasDisp.Add(data.ToShortTimeString());
                }

                DropDownList5.DataSource = listaHorasDisp;
                DropDownList5.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label9.Visible = false;
            Label8.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            UtilizadorRules utilizadorRules = new UtilizadorRules();
            ConsultaRules consultaRules = new ConsultaRules();
            Consulta novaConsulta = new Consulta();
            Utilizador fisioterapeuta = new Utilizador();
            fisioterapeuta = utilizadorRules.GetUtilizador(Convert.ToInt32(DropDownList1.SelectedValue));
            
            List<Utilizador> listaUtilizadores = new List<Utilizador>();
            listaUtilizadores.Add(this.utilizadorExistente);
            listaUtilizadores.Add(fisioterapeuta);

            var data = new DateTime(Calendar1.SelectedDate.Year, Calendar1.SelectedDate.Month, Calendar1.SelectedDate.Day);
            string datastring = data.ToShortDateString() + " " + DropDownList5.Text;


            novaConsulta.IdLocal = Convert.ToInt32(DropDownList2.SelectedValue);
            novaConsulta.IdTratamento = Convert.ToInt32(DropDownList4.SelectedValue);
            novaConsulta.Data = DateTime.Parse(datastring);
            novaConsulta.Estado = 1;

            if (Label6.Visible != true && DropDownList5.SelectedValue.Equals(null) != true)
            {
                if (consultaRules.MarcaConsulta(novaConsulta, listaUtilizadores) == true)
                {
                    Label8.Visible = true;
                }
                else Label9.Visible = true;
            }
            else Label9.Visible = true;
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}