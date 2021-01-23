using System;
using System.Collections.Generic;
using System.Text;
using ClinicaAppDA;
using ClinicaAppBO;

namespace ClinicaAppBR
{
    public class ConsultaRules
    {
        public bool MarcaConsulta(Consulta novaConsulta, List<Utilizador> utilizadores)
        {
            ConsultaDA consultaMetodos = new ConsultaDA();

            if (consultaMetodos.InsereConsulta(novaConsulta, utilizadores) == true)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<DateTime> GetConsultasDisp(DateTime data) // DEPOIS DEFINIR REGRAS
        {
            ConsultaDA consultaMetodos = new ConsultaDA();
            List<DateTime> datasDisp = new List<DateTime>();
            datasDisp = consultaMetodos.GetAllConsultasDisp(data);

            if (datasDisp != null)
            {
                return datasDisp;
            }
            else return null;
        }

        public List<Local> GetLocais()
        {
            LocalDA metodosLocal = new LocalDA();
            List<Local> listaLocal = new List<Local>();

            listaLocal = metodosLocal.GetLocais();
            if (listaLocal != null)
            {
                return listaLocal;
            }
            else return null;
        }

        public List<Tratamento> GetTratamentos()
        {
            TratamentoDA metodosTratamento = new TratamentoDA();
            List<Tratamento> listaTratamentos = new List<Tratamento>();
            listaTratamentos = metodosTratamento.GetTratamentos();

            if (listaTratamentos != null)
            {
                return listaTratamentos;
            }
            else return null;
        }
    }
}
