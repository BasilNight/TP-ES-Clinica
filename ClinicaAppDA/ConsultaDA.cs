using System;
using System.Collections.Generic;
using System.Text;
using clinicaAppBO;
using System.Data.SqlClient;

namespace ClinicaAppDA
{
    class ConsultaDA
    {
        #region Atributos
        //Connection String para a nossa base de dados
        private readonly string connectionString = "Server=speedwayrental.database.windows.net;Database=Clinica; User Id = admn; password=Mememaster101; Trusted_Connection=False; Encrypt=True;";
        private SqlConnection connection;
        private SqlCommand command;
        #endregion
    }
}
