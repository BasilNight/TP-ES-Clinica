using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using ClinicaAppBO;
using System.Data;

namespace ClinicaAppDA
{
    public class LocalDA
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
        public List<Local> GetLocais()
        {
            SqlDataReader dataReader;
            connection = new SqlConnection(connectionString);
            Local local;
            List<Local> listaLocal = new List<Local>();

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

                dataReader = cmdins.ExecuteReader();

                while (dataReader.Read())
                {
                    local = new Local();

                    local.ID = int.Parse(dataReader.GetValue(0).ToString());
                    local.Nome = dataReader.GetValue(1).ToString();

                    listaLocal.Add(local);
                }

                return listaLocal;
            }
            else return null;
        }

        /// <summary>
        /// Metodo que retorna um unico local
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Local GetLocal(int id)
        {
            DataTable dataTable = new DataTable();
            Local local = new Local();
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }
            if (connection.State.ToString() == "Open")
            {
                string comando = "select ID_Local, Nome from Local where ID_Local = @Id;";

                SqlCommand cmd = new SqlCommand(comando, connection);

                cmd.Parameters.AddWithValue("@Id", id);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);

                // Verifica a existencia de um utilizador com estas credenciais
                if (dataTable.Rows.Count != 0)
                {
                    local.ID = int.Parse(dataTable.Rows[0]["ID_Local"].ToString());
                    local.Nome = dataTable.Rows[0]["Nome"].ToString();
                    

                    return local;
                }
                else return null;

            }
            else return null;
        }


        #endregion
    }
}
