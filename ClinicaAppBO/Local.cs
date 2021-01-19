using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaAppBO
{
    public class Local
    {

        private int id;
        private string nome;

        public Local()
        {

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
