using System;
using System.Data.SqlClient;
using ClinicaAppBO;
using System.Data;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ClinicaAppDA
{
    public class UtilizadorDA
    {
        #region Atributos
        //Connection String para a nossa base de dados
        private readonly string connectionString = "Server=speedwayrental.database.windows.net;Database=Clinica; User Id = admn; password=Mememaster101; Trusted_Connection=False; Encrypt=True;";
        private SqlConnection connection;
        private SqlCommand command;
        #endregion

        #region Métodos

        //get, insere, delete, bla bla

        /// <summary>
        /// Metodo que insere um novo utilizador na base de dados
        /// </summary>
        /// <param name="novoUtilizador"></param>
        /// <returns></returns>
        public bool InsereUtilizador(Utilizador novoUtilizador)
        {

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

            }
            catch
            {
                //Conexao falhou
                connection.Close();
                return false;
            }
            if (connection.State.ToString() == "Open")
            {

                //Verificar se a pessoa ja existe
                if (ExisteUtilizador(novoUtilizador.Email) == false)
                {
                    //Construçao da query...             
                    string comando;

                    comando = "insert into Consulta (Data, Descricao, Estado, ID_Local, ID_Tratamento) values (@data, @desc, @estado, @idlocal, @idtrat);"; 

                    SqlCommand cmdins = new SqlCommand(comando, connection);

                    cmdins.Parameters.AddWithValue("@data", novoUtilizador.Username); 
                    cmdins.Parameters.AddWithValue("@desc", novoUtilizador.Email);
                    cmdins.Parameters.AddWithValue("@estado", novoUtilizador.Senha);
                    cmdins.Parameters.AddWithValue("@idlocal", novoUtilizador.DataNasc);
                    cmdins.Parameters.AddWithValue("@idtrat", novoUtilizador.DataNasc);



                    //Executa a query
                    int res = cmdins.ExecuteNonQuery();
                    if (res > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;

        }

        /// <summary>
        /// Metodo que verifica a existencia de um utilizador na base de dados
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool ExisteUtilizador(string email)
        {
            connection = new SqlConnection(connectionString);
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return false;
            }
            if (connection.State.ToString() == "Open")
            {
                string comando = ""; // FAZER QUERY PARA ESTE METODO!

                SqlCommand cmd = new SqlCommand(comando, connection);

                cmd.Parameters.AddWithValue("", email); // TROCAR PARAMETROS

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Metodo que devolve uma lista de objetos tipo Utilizador armazenados na base de dados
        /// </summary>
        /// <returns></returns>
        public List<Utilizador> GetAllUtilizadores()
        {
            SqlDataReader dataReader;
            List<Utilizador> listaUtilizadores = new List<Utilizador>();
            DataSet ds = new DataSet();
            connection = new SqlConnection(connectionString);
            Utilizador utilizador;

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

                //Construçao da query
                SqlCommand cmdins = new SqlCommand();
                string comando;
                cmdins.Connection = connection;

                comando = "SELECT * FROM Utilizador";
                cmdins.CommandText = comando;

                dataReader = cmdins.ExecuteReader();

                while (dataReader.Read())
                {
                    utilizador = new Utilizador();

                    utilizador.ID = int.Parse(dataReader.GetValue(0).ToString());
                    utilizador.Username = dataReader.GetValue(1).ToString();
                    utilizador.Email = dataReader.GetValue(2).ToString();
                    utilizador.Senha = dataReader.GetValue(3).ToString(); // Se calhar temos de modificar isto para por em codigo hash ou o crlh que a stora disse nao tenho a certeza.
                    utilizador.DataNasc = DateTime.Parse(dataReader.GetValue(4).ToString()); // Formato capaz de estar errado
                    utilizador.Nif = int.Parse(dataReader.GetValue(5).ToString());
                    utilizador.IdPerfil = int.Parse(dataReader.GetValue(6).ToString());

                    listaUtilizadores.Add(utilizador);
                }

                connection.Close();
                return listaUtilizadores;
            }
            else return null;

        }

        /// <summary>
        /// Metodo que atualiza as informaçoes de um utilizador existente na base de dados (INCOMPLETO)
        /// </summary>
        /// <param name="utilizador"></param>
        /// <returns></returns>
        public bool UpdateUtilizador(Utilizador utilizador)
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return false;
            }
            if (connection.State.ToString() == "Open")
            {
                //Verificar se a pessoa ja existe
                if (ExisteUtilizador(utilizador.Email) == false)
                {
                    //Construçao da query...             
                    string comando;

                    comando = "update Utilizador set Username = @username, Senha = @senha, Data_Nascimento = @dataNasc, NIF = @nif, ID_Perfil = @idPerfil where [E-mail] = @email;";

                    SqlCommand cmdins = new SqlCommand(comando, connection);

                    cmdins.Parameters.AddWithValue("@username", utilizador.Username);
                    cmdins.Parameters.AddWithValue("@email", utilizador.Email);
                    cmdins.Parameters.AddWithValue("@senha", utilizador.Senha);
                    cmdins.Parameters.AddWithValue("@dataNasc", utilizador.DataNasc);
                    cmdins.Parameters.AddWithValue("@nif", utilizador.Nif);
                    cmdins.Parameters.AddWithValue("@idPerfil", utilizador.IdPerfil);


                    //Executa a query
                    int res = cmdins.ExecuteNonQuery();
                    if (res > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;

                }
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Metodo que elimina utilizador registado na base de dados
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool DeleteUtilizador(string email)
        {
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

            }
            catch
            {
                //Conexao falhou
                connection.Close();
                return false;
            }
            if (connection.State.ToString() == "Open")
            {
                //Construçao da query             
                string comando;

                comando = "Delete from Utilizador where Utilizador.[E-mail] = @email;";
                SqlCommand cmdins = new SqlCommand(comando, connection);
                cmdins.Parameters.AddWithValue("@email", email);

                int res = cmdins.ExecuteNonQuery();
                if (res > 0)
                {
                    connection.Close();
                    return true;
                }
                else return false;
            }
            else return false;
        }
        #endregion

    }
}
