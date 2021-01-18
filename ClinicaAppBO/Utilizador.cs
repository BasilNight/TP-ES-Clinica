using System;

namespace ClinicaAppBO
{
    public class Utilizador
    {
        private int id;
        private string username;
        private string email;
        private string senha;
        private DateTime dataNasc;
        private int nif;
        private int idPerfil;

        public Utilizador()
        {

        }

        #region Propriedades
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public int IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }


        #endregion


    }
}
