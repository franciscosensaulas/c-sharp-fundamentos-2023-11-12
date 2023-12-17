using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp17ListaObjetos
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        // Método com retorno para calcular a média das notas
        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}
