using System;
using System.Collections.Generic;
using System.Text;



namespace ClinicaAppBO
{
    public class Consulta
    {

        private int id;
        private DateTime data;
        private string descricao;
        private int estado; //Talvez fazemos ENUM
        private int idLocal;
        private int idTratamento;


        public Consulta()
        {

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int IdLocal
        {
            get { return idLocal; }
            set { idLocal = value; }
        }

        public int IdTratamento
        {
            get { return idTratamento; }
            set { idTratamento = value; }
        }

        
    }
}
