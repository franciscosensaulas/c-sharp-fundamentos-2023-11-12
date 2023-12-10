using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    internal class Aluno
    {
        // Refatoração
        public Materia Logica { get; set; }
        public Materia BancoDados { get; set; }

        public string ObterStatus()
        {
            string statusLogica = Logica.ObterStatus();
            string statusBancoDados = BancoDados.ObterStatus();

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
