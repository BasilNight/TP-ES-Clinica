using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaAppBO
{
    public class Permissao
    {

        private int id;
        private string descricao;

        public Permissao()
        {

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
