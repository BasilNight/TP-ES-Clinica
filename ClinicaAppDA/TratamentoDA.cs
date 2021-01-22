using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using ClinicaAppBO;

namespace ClinicaAppDA
{
    public class TratamentoDA
    {
        #region Atributos
        //Connection String para a nossa base de dados
        private readonly string connectionString = "Server=speedwayrental.database.windows.net;Database=Clinica; User Id = admn; password=Mememaster101; Trusted_Connection=False; Encrypt=True;";
        private SqlConnection connection;
        private SqlCommand command;
        #endregion

        /// <summary>
        /// Metodo que retorna uma lista de locais
        /// </summary>
        /// <returns></returns>
        public List<Tratamento> GetTratamentos()
        {
            SqlDataReader dataReader;
            connection = new SqlConnection(connectionString);
            Tratamento tratamento;
            List<Tratamento> listaTratamento = new List<Tratamento>();

            try
            {
                connection.Open();

            }
            catch
            {
                //Conexao falhou
                connection.Close();
                return null;
            }
            if (connection.State.ToString() == "Open")
            {
                //Construçao da query
                SqlCommand cmdins = new SqlCommand();
                string comando;
                cmdins.Connection = connection;

                comando = "SELECT * FROM Tratamento";
                cmdins.CommandText = comando;

                dataReader = cmdins.ExecuteReader();

                while (dataReader.Read())
                {
                    tratamento = new Tratamento();

                    tratamento.ID = int.Parse(dataReader.GetValue(0).ToString());
                    tratamento.Descricao = dataReader.GetValue(1).ToString();

                    listaTratamento.Add(tratamento);
                }

                return listaTratamento;
            }
            else return null;
        }
    }
}
