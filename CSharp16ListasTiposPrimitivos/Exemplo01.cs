using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp16ListasTiposPrimitivos
{
    internal class Exemplo01
    {
        public void Executar()
        {
            List<string> produtos = new List<string>();

            // CRUD => Create, Read, Update, Delete
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Alterar");
            Console.WriteLine("3 - Listar");
            Console.WriteLine("4 - Apagar");
            Console.WriteLine("10 - Sair");
            Console.Write("Digite o menu desejado: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            while(menu != 10)
            {
                Console.Clear();
                
                // Verificar modo cadastro
                if (menu == 1)
                {
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    produtos.Add(nome);
                }
                else if(menu == 2) // Verificar modo de edição
                {
                    Console.Write("Digite o nome do produto para alterar: ");
                    string nome = Console.ReadLine();
                    // IndexOf: é um método que retorna a posição da lista do elemento buscado
                    int indiceNomeParaAlterar = produtos.IndexOf(nome);

                    Console.Write("Digite o novo nome do produto: ");
                    string novoNome = Console.ReadLine();

                    // Alterar na lista de produtos
                    produtos[indiceNomeParaAlterar] = novoNome;
                }
                else if(menu == 3) // Verificar modo de listagem dos produtos
                {
                    Console.WriteLine("Produtos cadastrados:");
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine(produtos[i]);
                    }
                }
                else if(menu == 4) // Verificar modo de exclusão
                {
                    Console.Write("Digite o nome do produto para apagar: ");
                    string nome = Console.ReadLine();
                    produtos.Remove(nome);
                }

                Console.WriteLine("\n\n1 - Cadastrar");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("4 - Apagar");
                Console.WriteLine("10 - Sair");
                Console.Write("Digite o menu desejado: ");
                menu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
