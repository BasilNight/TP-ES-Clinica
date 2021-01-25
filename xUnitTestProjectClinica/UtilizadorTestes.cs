using System;
using System.Linq;
using Xunit;
using ClinicaAppBO;
using ClinicaAppDA;
using System.Collections.Generic;

namespace xUnitTestProjectClinica
{
    public class UtilizadorTestes
    {

        [Theory]
        [InlineData("nomeTeste", "mailtest", "senhateste", "2015-06-19 10:03:06", 12342, 1, true)]

        public void UtilizadorInsertTeste(string username, string email, string senha, string dataNasc, int nif, int idPerfil, bool expected)
        {
            //Arrange
            UtilizadorDA metodos = new UtilizadorDA();
            Utilizador uti = new Utilizador();
            uti.Username = username;
            uti.DataNasc = DateTime.Parse(dataNasc);
            uti.Email = email;
            uti.Senha = senha;
            uti.Nif = nif;
            uti.IdPerfil = idPerfil;

            //Act
            bool resultado = metodos.InsereUtilizador(uti);


            //Assert
            Assert.Equal(expected, resultado);

        }


        [Theory]
        [InlineData("nomeTesteUpdated", "mailtest", "senhatesteUpdated", "2015-06-19 10:03:08", 12342, 1, true)]
        public void UtilizadorUpdateTeste(string username, string email, string senha, string dataNasc, int nif, int idPerfil, bool expected)
        {
            //Arrange
            UtilizadorDA metodos = new UtilizadorDA();
            Utilizador uti = new Utilizador();
            uti.Username = username;
            uti.DataNasc = DateTime.Parse(dataNasc);
            uti.Email = email;
            uti.Senha = senha;
            uti.Nif = nif;
            uti.IdPerfil = idPerfil;

            //Act
            bool resultado = metodos.UpdateUtilizador(uti);

            //Assert
            Assert.Equal(expected, resultado);
        }

        
        [Theory]
        [InlineData(21)] // Verificar id atual na base de dados

        public void UtilizadorGetTeste(int id)
        {
            //Arrange
            UtilizadorDA metodos = new UtilizadorDA();

            Utilizador utilizadorEsperado = new Utilizador();

            utilizadorEsperado.ID = 21;
            utilizadorEsperado.Username = "nomeTesteUpdated";
            utilizadorEsperado.Email = "mailtest";
            utilizadorEsperado.Senha = "senhatesteUpdated";
            utilizadorEsperado.DataNasc = DateTime.Parse("19/06/2015 10:03:08");
            utilizadorEsperado.Nif = 12342;
            utilizadorEsperado.IdPerfil = 1;

            //Act
            Utilizador utilizadorAtual = metodos.GetUtilizador(id);

            //Assert
            Assert.Equal(id, utilizadorAtual.ID);


        }
        
        
        [Theory]
        [InlineData("mailtest", true)]
        public void UtilizadorDeleteTeste(string email, bool expected)
        {
            //Arrange
            UtilizadorDA metodos = new UtilizadorDA();

            //Act
            bool resultado = metodos.DeleteUtilizador(email);

            //Assert
            Assert.Equal(resultado, expected);
        }
        
        /// <summary>
        /// Verifica se um elemento tem um perfil de fisioterapeuta
        /// </summary>
        [Fact]
        public void GetFisioterapeutasTeste()
        {
            //Arrange
            UtilizadorDA metodos = new UtilizadorDA();
            List<Utilizador> listFisioterapeutas = new List<Utilizador>();

            //Act
            listFisioterapeutas = metodos.GetFisioterapeutas();


            //Assert
            Assert.True(listFisioterapeutas[1].IdPerfil == 2);

        }

    }
}

