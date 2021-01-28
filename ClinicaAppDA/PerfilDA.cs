using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using ClinicaAppBO;

namespace ClinicaAppDA
{
    public class PerfilDA
    {
        #region Atributos
        //Connection String para a nossa base de dados
        private readonly string connectionString = "Server=speedwayrental.database.windows.net;Database=Clinica; User Id = admn; password=Mememaster101; Trusted_Connection=False; Encrypt=True;";
        private SqlConnection connection;
        private SqlCommand command;
        #endregion

        /// <summary>
        /// Metodo que devolve lista de perfis
        /// </summary>
        /// <returns></returns>
        public List<Perfil> GetPerfis()
        {
            SqlDataReader dataReader;
            connection = new SqlConnection(connectionString);
            Perfil perfil;
            List<Perfil> listaPerfil = new List<Perfil>();

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

                comando = "select * from Perfil;";
                cmdins.CommandText = comando;

                dataReader = cmdins.ExecuteReader();

                while (dataReader.Read())
                {
                    perfil = new Perfil();

                    perfil.ID = int.Parse(dataReader.GetValue(0).ToString());
                    perfil.Titulo = dataReader.GetValue(1).ToString();
                    perfil.Descricao = dataReader.GetValue(2).ToString();

                    listaPerfil.Add(perfil);
                }

                return listaPerfil;
            }
            else return null;
        }

    }
}
