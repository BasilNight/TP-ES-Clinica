using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaAppBO
{
    public class Fatura
    {

        private int id;
        private string nome;
        private int numero;
        private string morada;
        private int nif;
        private decimal valor;
        private float iva;
        private DateTime data;
        private int idUtilizador;

        public Fatura()
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

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public float Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public int IdUtilizador
        {
            get { return idUtilizador; }
            set { idUtilizador = value; }
        }

    }
}
