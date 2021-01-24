using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using ClinicaAppBO;
using System.Data;
using System.Linq;


namespace ClinicaAppDA
{
    public class ConsultaDA
    {
        #region Atributos
        //Connection String para a nossa base de dados
        private readonly string connectionString = "Server=speedwayrental.database.windows.net;Database=Clinica; User Id = admn; password=Mememaster101; Trusted_Connection=False; Encrypt=True;";
        private SqlConnection connection;
        private SqlCommand command;
        #endregion

        #region Métodos

        /// <summary>
        /// Metodo que insere uma consulta nova na base de dados: Funciona
        /// </summary>
        /// <param name="novaConsulta"></param>
        /// <returns></returns>
        public bool InsereConsulta(Consulta novaConsulta, List<Utilizador> utilizadores)
        {
            #region para testes 

            #endregion

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

                //Construçao da query...             
                string comando;

                comando = "insert into Consulta (Data, Descricao, Estado, ID_Local, ID_Tratamento) values (@data, @desc, @estado, @idLocal, @idTrat); SELECT SCOPE_IDENTITY()";

                SqlCommand cmdins = new SqlCommand(comando, connection);

                cmdins.Parameters.AddWithValue("@data", novaConsulta.Data);
                cmdins.Parameters.AddWithValue("@desc", "");
                cmdins.Parameters.AddWithValue("@estado", novaConsulta.Estado);
                cmdins.Parameters.AddWithValue("@idLocal", novaConsulta.IdLocal);
                cmdins.Parameters.AddWithValue("@idTrat", novaConsulta.IdTratamento);


                //Executa a query
                int lastId = Convert.ToInt32(cmdins.ExecuteScalar());
                if (lastId > 0)
                {
                    foreach(Utilizador utilizador in utilizadores)
                    {
                        string comando2;

                        comando2 = "insert into Consulta_Utilizador (ConsultaID_Consulta, UtilizadorID_Utilizador) values ( @idConsulta, @idUtilizador);";
                        SqlCommand cmdins2 = new SqlCommand(comando2, connection);

                        cmdins2.Parameters.AddWithValue("@idConsulta", lastId);
                        cmdins2.Parameters.AddWithValue("@idUtilizador", utilizador.ID);

                        int res2 = cmdins2.ExecuteNonQuery();


                    }
                    connection.Close();
                    return true;
                }
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Metodo que devolve uma lista de utilizadores que vao participar na consulta
        /// </summary>
        /// <param name="ConsultaId"></param>
        /// <returns></returns>
        public List<Utilizador> GetUtilizadoresInConsulta(int ConsultaId)
        {
            int utilizadorId;
            UtilizadorDA utilizadorDA = new UtilizadorDA();
            DataTable dataTable = new DataTable();
            connection = new SqlConnection(connectionString);
            Utilizador utilizador;
            List<Utilizador> listaUtilizadores = new List<Utilizador>();

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

                comando = "select * from Consulta_Utilizador";
                cmdins.CommandText = comando;

                SqlDataAdapter da = new SqlDataAdapter(cmdins.CommandText, connection);
                da.Fill(dataTable);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (dataRow["ConsultaID_Consulta"].ToString() == ConsultaId.ToString())
                    {
                        utilizadorId = int.Parse(dataRow["UtilizadorID_Utilizador"].ToString());
                        utilizador = utilizadorDA.GetUtilizador(utilizadorId);
                        listaUtilizadores.Add(utilizador);
                    }
                }
                return listaUtilizadores;
            }
            else return null;
            
        }

        /// <summary>
        /// Metodo que devolve uma lista de todas as consultas registadas na base de dados
        /// </summary>
        /// <returns></returns>
        public List<Consulta> GetAllConsultas()
        {
            SqlDataReader dataReader;
            List<Consulta> listaConsultas = new List<Consulta>();
            DataSet ds = new DataSet();
            connection = new SqlConnection(connectionString);
            Consulta consulta;

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

                comando = "SELECT * FROM Consulta";
                cmdins.CommandText = comando;

                dataReader = cmdins.ExecuteReader();

                while (dataReader.Read())
                {
                    consulta = new Consulta();

                    consulta.ID = int.Parse(dataReader.GetValue(0).ToString());
                    consulta.Data = DateTime.Parse(dataReader.GetValue(1).ToString());
                    consulta.Descricao = dataReader.GetValue(2).ToString();
                    consulta.Estado = int.Parse(dataReader.GetValue(3).ToString());
                    consulta.IdLocal = int.Parse(dataReader.GetValue(4).ToString());
                    consulta.IdTratamento = int.Parse(dataReader.GetValue(5).ToString());
                    //consulta.Utilizadores = GetUtilizadoresInConsulta(consulta.ID); // Teste, talvez nao final

                    listaConsultas.Add(consulta);
                }

                connection.Close();
                return listaConsultas;
            }
            else return null;
        }

        /// <summary>
        /// Metodo que devolve todas as consultas disponiveis - FUNCIONA kinda
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<DateTime> GetAllConsultasDisp(DateTime date, int idLocal, int idFisioterapeuta)
        {
            SqlDataReader dataReader;
            List<DateTime> horasTodas = new List<DateTime>();
            List<Consulta> listaConsultas = new List<Consulta>();
            List<Utilizador> fisioterapeutas = new List<Utilizador>();
            

            UtilizadorDA utilizadorMetodos = new UtilizadorDA();
            

            connection = new SqlConnection(connectionString);
            Consulta consulta;
            
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
                
                const int lastHour = 19; // Hora final/hora de encerramento da clinica

                DateTime data = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0); // Hora inicial da data escolhida.

                while (data.Hour < lastHour)
                {
                    horasTodas.Add(data);
                    data = data.AddHours(1);
                }
                listaConsultas = GetAllConsultas();

                // So verifica se as datas sao iguais ainda nao ve locais
                foreach(DateTime date1 in horasTodas.ToList()) //To list porque senao dava erro
                {
                    foreach(Consulta consulta1 in listaConsultas)
                    {

                        int result = DateTime.Compare(date1, consulta1.Data);

                        if (result == 0)
                        {
                            fisioterapeutas = GetUtilizadoresInConsulta(consulta1.ID);
                            foreach(Utilizador utilizador in fisioterapeutas)
                            {
                                if(idFisioterapeuta == utilizador.ID && idLocal == consulta1.IdLocal)
                                {
                                    horasTodas.Remove(date1);
                                }
                            }
                            //horasTodas.Remove(date1);
                        }

                        /* int result = DateTime.Compare(date1, consulta1.Data); // So isto funciona

                         if (result == 0)
                         {
                             horasTodas.Remove(date1);
                         }
                        */

                    }

                    
                }

                return horasTodas;
            }
            else return null;
        }



        /// <summary>
        /// Metodo que atualiza uma consulta registada na base de dados
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public bool UpdateConsulta(Consulta consulta)
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

                //Construçao da query...             
                string comando;

                comando = "update Consulta set Data = @data, Descricao = @desc, Estado = @estado, ID_Local = @idLocal, ID_Tratamento = @idTrat, where ID_Consulta = @ID;";

                SqlCommand cmdins = new SqlCommand(comando, connection);

                cmdins.Parameters.AddWithValue("@data", consulta.Data);
                cmdins.Parameters.AddWithValue("@desc", consulta.Descricao);
                cmdins.Parameters.AddWithValue("@estado", consulta.Estado);
                cmdins.Parameters.AddWithValue("@idLocal", consulta.IdLocal);
                cmdins.Parameters.AddWithValue("@idTrat", consulta.IdTratamento);
                cmdins.Parameters.AddWithValue("@ID", consulta.ID);


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

        /// <summary>
        /// Metodo que elimina uma consulta registada na Base de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteConsulta(int id)
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

                comando = "delete from Consulta where ID_Consulta = @ID;";
                SqlCommand cmdins = new SqlCommand(comando, connection);
                cmdins.Parameters.AddWithValue("@ID", id);

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
