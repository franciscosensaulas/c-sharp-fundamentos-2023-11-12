using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp15ForComVetor
{
    internal class Exemplo01
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de produtos: ");
            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

            string[] nomes = new string[quantidadeProdutos];
            double[] precosUnitarios = new double[quantidadeProdutos];
            int[] quantidades = new int[quantidadeProdutos];

            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.Write("\nDigite o nome do produto: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite a quantidade para '" + nomes[i] + "': ");
                quantidades[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o preço unitário para '" + nomes[i] + "': ");
                precosUnitarios[i] = Convert.ToDouble(Console.ReadLine());
            }

            double totalCompra = 0;
            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                double totalProduto = quantidades[i] * precosUnitarios[i];
                Console.WriteLine(nomes[i] + string.Format("{0:C}", totalProduto));

                totalCompra = totalCompra + totalProduto;
            }

            Console.WriteLine("Total: " + string.Format("{0:C}", totalCompra));
        }
    }
}
// Solocitar para 4 alunos(obrigatório utilização for)
// nome
// nota 1 
// nota 2
// nota 3
// apresenta média dos alunos