using System;
using System.Linq;
using Xunit;

namespace xUnitTestProjectClinica
{
    public class UtilizadorTestes
    {

        [Theory]
        [InlineData("nomeTeste", "mailtest", "senhateste", "19/06/2015 10:03:06", 12342, 1, true)]
        public void UtilizadorInsertTeste(string username, string email, string senha, string dataNasc, int nif, int idPerfil, bool expected)
        {
            //Arrange



            //Act


            //Assert


        }
    }
}
