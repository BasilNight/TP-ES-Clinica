using System;
using ClinicaAppBO;
using ClinicaAppDA;
using System.Collections.Generic;

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

        public Utilizador Login(string email, string senha)
        {
            UtilizadorDA utilizadorMetodos = new UtilizadorDA();
            Utilizador utilizador;
            utilizador = utilizadorMetodos.Login(email, senha);
            if (utilizador != null)
            {
                return utilizador;
            }
            else return null;
        }

        public List<Utilizador> GetFisioterapeutas()
        {
            UtilizadorDA utilizadorMetodos = new UtilizadorDA();
            List<Utilizador> listaFisioterapeutas = new List<Utilizador>();

            listaFisioterapeutas = utilizadorMetodos.GetFisioterapeutas();

            if (listaFisioterapeutas != null)
            {
                return listaFisioterapeutas;
            }
            else return null;
        }

        public Utilizador GetUtilizador(int id)
        {
            UtilizadorDA utilizadorMetodos = new UtilizadorDA();
            Utilizador utilizador = new Utilizador();

            utilizador = utilizadorMetodos.GetUtilizador(id);
            if (utilizador != null)
            {
                return utilizador;
            }
            else return null;
        }

        public List<Perfil> GetPerfils()
        {
            PerfilDA metodosPerfil = new PerfilDA();
            List<Perfil> listaPerfis = new List<Perfil>();

            listaPerfis = metodosPerfil.GetPerfis();
            if (listaPerfis != null)
            {
                return listaPerfis;
            }
            else return null;
        }
    }
}
