using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo01
    {
        // Método (Ação): tem como objetivo executar determinada rotina
        public void Executar()
        {
            // camelCase => doguinho
            // PascalCase => Cachorro

            // Instanciando um objeto da classe Cachorro, o nome do nosso objeto é doguinho
            Cachorro doguinho = new Cachorro(); // NomeDaClasse nomeObjeto = new NomeDalasse();

            // Definir as propriedades (caracterísitcas)
            doguinho.Nome = "Tigão";
            doguinho.Idade = 3;
            doguinho.Raca = "Dobermann";
            doguinho.Sexo = "Masculino";
            // Alterado a idade do doguinho, pq ele fez aniversário
            doguinho.Idade = 4;

            // Instanciar um objeto da class Cachorro, o nome do nosso objeto será dogao
            Cachorro dogao = new Cachorro();
            dogao.Idade = 10;
            dogao.Raca = "Vira-lata";
            dogao.Nome = "Dogão";
            dogao.Sexo = "Feminino";


            // Apresentar as propriedades do objeto doguinho
            Console.WriteLine("Nome: " + doguinho.Nome);
            Console.WriteLine("Idade: " + doguinho.Idade);
            Console.WriteLine("Raça: " + doguinho.Raca);
            Console.WriteLine("Sexo: " + doguinho.Sexo);

            // Apresentar as propriedades do objeto dogao
            Console.WriteLine("Nome: " + dogao.Nome);
            Console.WriteLine("Idade: " + dogao.Idade);
            Console.WriteLine("Raça: " + dogao.Raca);
            Console.WriteLine("Sexo: " + dogao.Sexo);

            int soma = doguinho.Idade + dogao.Idade;
            double media = soma / 2.0;
            Console.WriteLine("\n\nA média das idades é: " + media);
        }
    }
}
