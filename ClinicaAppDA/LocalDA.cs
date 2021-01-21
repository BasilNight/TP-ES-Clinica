using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using ClinicaAppBO;

namespace ClinicaAppDA
{
    class LocalDA
    {
        #region Atributos
        //Connection String para a nossa base de dados
        private readonly string connectionString = "Server=speedwayrental.database.windows.net;Database=Clinica; User Id = admn; password=Mememaster101; Trusted_Connection=False; Encrypt=True;";
        private SqlConnection connection;
        private SqlCommand command;
        #endregion

        #region Métodos

        /// <summary>
        /// Metodo que retorna uma lista de locais
        /// </summary>
        /// <returns></returns>
        /*public List<Local> GetLocais()
        {
            SqlDataReader dataReader;
            connection = new SqlConnection(connectionString);

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

                comando = "SELECT * FROM Local";
                cmdins.CommandText = comando;
            }
        }
        */

        #endregion
    }
}
