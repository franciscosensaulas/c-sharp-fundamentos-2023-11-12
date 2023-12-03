using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Aluno aluno1 = new Aluno();

            Console.Write("Digite a nota 1 de Lógica: ");
            aluno1.LogicaNota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 1 de Lógica: ");
            aluno1.LogicaNota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 1 de Lógica: ");
            aluno1.LogicaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 1 de Banco de Dados: ");
            aluno1.BancoDadosNota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 2 de Banco de Dados: ");
            aluno1.BancoDadosNota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 3 de Banco de Dados: ");
            aluno1.BancoDadosNota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Média de lógica: " + aluno1.CalcularMediaLogica());
            Console.WriteLine("Média de banco de dados: " + aluno1.CalcularMediaBancoDados());
            Console.WriteLine("Status da matéria de lógica: " + aluno1.ObterStatusLogica());
            Console.WriteLine("Status da matéria de banco de dados: " + aluno1.ObterStatusBancoDados());
            Console.WriteLine("Status: " + aluno1.ObterStatus());
        }
    }
}
// parâmetros de métodos