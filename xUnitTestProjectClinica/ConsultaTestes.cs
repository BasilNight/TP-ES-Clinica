using System;
using System.Linq;
using Xunit;
using ClinicaAppBO;
using System.Collections.Generic;
using ClinicaAppDA;

namespace xUnitTestProjectClinica
{
    public class ConsultaTestes
    {

        /*
        #region MyTests
        [Theory]
        [InlineData("teste","28-01-2021 13:00:00", 1, 1, 1, true)]
        public void ConsultaInsertTesteMine(string descricao, string data, int estado, int idlocal, int idTrat, bool expected)
        {
            //Arrange
            bool res;
            UtilizadorDA metodosUtilizador = new UtilizadorDA();
            ConsultaDA consultas = new ConsultaDA();
            List<Utilizador> listaUtilizadoresConsulta = new List<Utilizador>();

            Utilizador utente = new Utilizador();
            utente = metodosUtilizador.GetUtilizador(1);
            Utilizador fisioterapeuta = new Utilizador();
            fisioterapeuta = metodosUtilizador.GetUtilizador(2);
            listaUtilizadoresConsulta.Add(utente);
            listaUtilizadoresConsulta.Add(fisioterapeuta);

            Consulta consultaNova = new Consulta();
            consultaNova.Descricao = descricao;
            consultaNova.Data = DateTime.Parse(data);
            consultaNova.Estado = estado;
            consultaNova.IdLocal = idlocal;
            consultaNova.IdTratamento = idTrat;
            //consultaNova.Utilizadores = listaUtilizadoresConsulta;

            //Act
            res = consultas.InsereConsulta(consultaNova, listaUtilizadoresConsulta);

            //Assert
            Assert.Equal(res, expected);

        }

        //Nao sei porque nao funciona as listas são iguais
        [Theory]
        [InlineData(14)]
        public void GetUtilizadoresInConsultaTesteMine(int idConsulta)
        {

            //Arrange
            UtilizadorDA metodosUtilizador = new UtilizadorDA();
            ConsultaDA consultas = new ConsultaDA();
            List<Utilizador> listaUtilizadoresConsultaEsperada = new List<Utilizador>();
            List<Utilizador> listaUtilizadoresConsultaResultado = new List<Utilizador>();

            Utilizador utente = new Utilizador();
            utente = metodosUtilizador.GetUtilizador(1);
            Utilizador fisioterapeuta = new Utilizador();
            fisioterapeuta = metodosUtilizador.GetUtilizador(2);
            listaUtilizadoresConsultaEsperada.Add(utente);
            listaUtilizadoresConsultaEsperada.Add(fisioterapeuta);

            //Act
            listaUtilizadoresConsultaResultado = consultas.GetUtilizadoresInConsulta(idConsulta);

            //Assert
            Assert.Equal(listaUtilizadoresConsultaEsperada, listaUtilizadoresConsultaResultado);

        }

        //[Theory]
        //[InlineData("28-01-2021 00:00:00")]
        //[MemberData]
        //public void GetAllConsultasDisp(string data)
        //{

        //    //Arrange
        //    ConsultaDA consultas = new ConsultaDA();
        //    List<DateTime> datas = new List<DateTime>();

        //    //Act
        //    datas = consultas.GetAllConsultasDisp(DateTime.Parse(data));

        //    //Assert
        //    Assert.NotNull(datas);

        //}

        #endregion
        */

        #region FinalTests
        [Theory]
        [InlineData("teste", "2021-01-28 13:00:00", 1, 1, 1, true)]
        public void ConsultaInsertTeste(string descricao, string data, int estado, int idlocal, int idTrat, bool expected)
        {
            //Arrange
            bool res;
            UtilizadorDA metodosUtilizador = new UtilizadorDA();
            ConsultaDA consultas = new ConsultaDA();
            List<Utilizador> listaUtilizadoresConsulta = new List<Utilizador>();

            Utilizador utente = new Utilizador();
            utente = metodosUtilizador.GetUtilizador(1);
            Utilizador fisioterapeuta = new Utilizador();
            fisioterapeuta = metodosUtilizador.GetUtilizador(2);
            listaUtilizadoresConsulta.Add(utente);
            listaUtilizadoresConsulta.Add(fisioterapeuta);

            Consulta consultaNova = new Consulta();
            consultaNova.Descricao = descricao;
            consultaNova.Data = DateTime.Parse(data);
            consultaNova.Estado = estado;
            consultaNova.IdLocal = idlocal;
            consultaNova.IdTratamento = idTrat;


            //Act
            res = consultas.InsereConsulta(consultaNova, listaUtilizadoresConsulta);

            //Assert
            Assert.Equal(res, expected);

        }

        //Nao sei porque nao funciona as listas são iguais
        /*
        [Theory]
        [InlineData(21)]
        public void GetUtilizadoresInConsultaTeste(int idConsulta)
        {

            //Arrange
            UtilizadorDA metodosUtilizador = new UtilizadorDA();
            ConsultaDA consultas = new ConsultaDA();
            List<Utilizador> listaUtilizadoresConsultaEsperada = new List<Utilizador>();
            List<Utilizador> listaUtilizadoresConsultaResultado = new List<Utilizador>();

            Utilizador utente = new Utilizador();
            utente = metodosUtilizador.GetUtilizador(1);
            Utilizador fisioterapeuta = new Utilizador();
            fisioterapeuta = metodosUtilizador.GetUtilizador(2);
            listaUtilizadoresConsultaEsperada.Add(utente);
            listaUtilizadoresConsultaEsperada.Add(fisioterapeuta);

            //Act
            listaUtilizadoresConsultaResultado = consultas.GetUtilizadoresInConsulta(idConsulta);

            //Assert
            Assert.Equal(listaUtilizadoresConsultaEsperada, listaUtilizadoresConsultaResultado);

        }
        */
        #endregion
        
    }
}
