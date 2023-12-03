using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo03
    {
        public void Executar()
        {
            Paciente paciente1 = new Paciente();

            Console.Write("Nome: ");
            paciente1.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            paciente1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura: ");
            paciente1.Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso: ");
            paciente1.Peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("CPF: ");
            paciente1.Cpf = Console.ReadLine();

            double imcPaciente1 = paciente1.CalcularImc();
            string classificacaoPaciente1 = paciente1.ObterClassificacaoImc();
            string geracaoPaciente1 = paciente1.ObterClassificacaoGeracao();

            Console.WriteLine("IMC do Paciente 1: " + imcPaciente1);
            Console.WriteLine("Classificação do Paciente 1: " + classificacaoPaciente1);
            Console.WriteLine("Geração do Paciente 1: " + geracaoPaciente1);
        }
    }
}
