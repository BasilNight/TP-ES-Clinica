using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaAppBO
{
    public class Perfil
    {

        private int id;
        private string titulo;
        private string descricao;

        public Perfil()
        {

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
