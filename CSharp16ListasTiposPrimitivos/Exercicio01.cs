using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp16ListasTiposPrimitivos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            List<string> nomes = new List<string>();
            List<double> notas1 = new List<double>();
            List<double> notas2 = new List<double>();
            List<double> notas3 = new List<double>();

            Console.WriteLine("----------------- MENU -----------------");
            Console.WriteLine(" 1 - Cadastrar");
            Console.WriteLine(" 2 - Editar");
            Console.WriteLine(" 3 - Apagar");
            Console.WriteLine(" 4 - Listar");
            Console.WriteLine(" 5 - Sair");
            Console.Write("Digite o menu desejado: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            while (menu != 5)
            {
                Console.Clear();
                if (menu == 1)
                {
                    Console.Write("Digite o nome do aluno: ");
                    string nome = Console.ReadLine().Trim();
                    Console.Write("Digite a nota 1 do aluno: ");
                    double nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a nota 2 do aluno: ");
                    double nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a nota 3 do aluno: ");
                    double nota3 = Convert.ToDouble(Console.ReadLine());

                    nomes.Add(nome);
                    notas1.Add(nota1);
                    notas2.Add(nota2);
                    notas3.Add(nota3);

                    Console.WriteLine("Aluno " + nome + " cadastrado com sucesso!");
                }
                else if (menu == 2)
                {
                    Console.Write("Digite o nome do aluno para editar: ");
                    string nomeParaEditar = Console.ReadLine().Trim();

                    // Verificar que o aluno está cadastrado
                    if (nomes.Contains(nomeParaEditar))
                    {
                        Console.Write("Digite o novo nome: ");
                        string novoNome = Console.ReadLine().Trim();
                        Console.Write("Digite a nota 1 do aluno: ");
                        double nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a nota 2 do aluno: ");
                        double nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a nota 3 do aluno: ");
                        double nota3 = Convert.ToDouble(Console.ReadLine());

                        // Obter o indice da posição do registro do aluno
                        int indiceParaEditar = nomes.IndexOf(nomeParaEditar);
                        nomes[indiceParaEditar] = novoNome;
                        notas1[indiceParaEditar] = nota1;
                        notas2[indiceParaEditar] = nota2;
                        notas3[indiceParaEditar] = nota3;
                        Console.WriteLine("Aluno " + novoNome + " alterado com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Aluno " + nomeParaEditar + " não está cadastrado.");
                    }
                }
                else if (menu == 3)
                {
                    Console.Write("Digite o nome do aluno para apagar: ");
                    string nome = Console.ReadLine().Trim();

                    // Verificar que o aluno está cadastrado
                    if (nomes.Contains(nome))
                    {
                        int indiceDoAluno = nomes.IndexOf(nome);
                        // Remove: recebe o dado que será removido
                        // RemoveAt: recebe a posição que será removida
                        nomes.RemoveAt(indiceDoAluno);
                        notas1.RemoveAt(indiceDoAluno);
                        notas2.RemoveAt(indiceDoAluno);
                        notas3.RemoveAt(indiceDoAluno);
                        Console.WriteLine("Aluno " + nome + " removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não está cadastrado.");
                    }
                }
                else if (menu == 4)
                {
                    for (int i = 0; i < nomes.Count; i = i + 1)
                    {
                        double media = (notas1[i] + notas2[i] + notas3[i]) / 3;
                        Console.WriteLine("\nAluno: " + nomes[i] +
                            "\nN1: " + string.Format("{0:N2}", notas1[i]) +
                            "\nN2: " + string.Format("{0:N2}", notas2[i]) +
                            "\nN3: " + string.Format("{0:N2}", notas3[i]) +
                            "\nmédia: " + string.Format("{0:N2}", media));
                    }
                }

                Console.WriteLine("----------------- MENU -----------------");
                Console.WriteLine(" 1 - Cadastrar");
                Console.WriteLine(" 2 - Editar");
                Console.WriteLine(" 3 - Apagar");
                Console.WriteLine(" 4 - Listar");
                Console.WriteLine(" 5 - Sair");
                Console.Write("Digite o menu desejado: ");
                menu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
