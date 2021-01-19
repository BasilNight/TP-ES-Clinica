using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaAppBO
{
    public class Tratamento
    {

        private int id;
        private string descricao;
        private decimal preco;

        public Tratamento()
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

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}
