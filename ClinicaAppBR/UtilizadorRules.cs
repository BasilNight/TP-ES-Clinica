using System;
using ClinicaAppBO;
using ClinicaAppDA;

namespace ClinicaAppBR
{
    public class UtilizadorRules
    {

        public bool RegistarUtilizador(Utilizador novoUtilizador)
        {
            UtilizadorDA utilizadorMetodos = new UtilizadorDA();
            if (utilizadorMetodos.InsereUtilizador(novoUtilizador) == true)
            {
                return true;
            }
            else return false;
        }

        public Utilizador Login(string username, string senha)
        {
            UtilizadorDA utilizadorMetodos = new UtilizadorDA();
            Utilizador utilizador;
            utilizador = utilizadorMetodos.Login(username, senha);
            if (utilizador != null)
            {
                return utilizador;
            }
            else return null;
        }



    }
}
