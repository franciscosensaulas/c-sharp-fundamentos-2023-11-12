using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    internal class Aluno
    {
        public double LogicaNota1 { get; set; }
        public double LogicaNota2 { get; set; }
        public double LogicaNota3 { get; set; }
        public double BancoDadosNota1 { get; set; }
        public double BancoDadosNota2 { get; set; }
        public double BancoDadosNota3 { get; set; }

        public double CalcularMediaLogica()
        {
            double soma = LogicaNota1 + LogicaNota2 + LogicaNota3;
            double media = soma / 3;

            return media;
        }

        public double CalcularMediaBancoDados()
        {
            double soma = BancoDadosNota1 + BancoDadosNota2 + BancoDadosNota3;
            double media = soma / 3;

            return media;
        }

        public string ObterStatusLogica()
        {
            double media = CalcularMediaLogica();

            string status = "";
            if (media < 5)
            {
                status = "Reprovado";
            }
            else if (media < 7)
            {
                status = "Em exame";
            }
            else
            {
                status = "Aprovado";
            }

            return status;
        }

        public string ObterStatusBancoDados()
        {
            double media = CalcularMediaBancoDados();

            string status = "";
            if (media < 5)
            {
                status = "Reprovado";
            }
            else if (media < 7)
            {
                status = "Em exame";
            }
            else
            {
                status = "Aprovado";
            }

            return status;
        }

        public string ObterStatus()
        {
            string statusLogica = ObterStatusLogica();
            string statusBancoDados = ObterStatusBancoDados();

            string status = "";
            if (statusLogica == "Aprovado" && statusBancoDados == "Aprovado")
            {
                status = "Aprovado";
            }
            else
            {
                status = "Reprovado";
            }
            return status;
        }
    }
}
