using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp17ListaObjetos
{
    internal class Exemplo01
    {
        public void Executar()
        {
            List<Aluno> alunos = new List<Aluno>();

            Console.WriteLine("----------------- MENU -----------------");
            Console.WriteLine(" 1 - Cadastrar");
            Console.WriteLine(" 2 - Editar");
            Console.WriteLine(" 3 - Apagar");
            Console.WriteLine(" 4 - Listar");
            Console.WriteLine(" 6 - Listar aprovados");
            Console.WriteLine(" 5 - Sair");
            Console.Write("Digite o menu desejado: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            while (menu != 5)
            {
                Console.Clear();
                if (menu == 1)
                {
                    Aluno aluno = new Aluno();

                    Console.Write("Digite o nome do aluno: ");
                    aluno.Nome = Console.ReadLine().Trim();
                    Console.Write("Digite a nota 1 do aluno: ");
                    aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a nota 2 do aluno: ");
                    aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a nota 3 do aluno: ");
                    aluno.Nota3 = Convert.ToDouble(Console.ReadLine());

                    alunos.Add(aluno);

                    Console.WriteLine("Aluno " + aluno.Nome + " cadastrado com sucesso!");
                }
                else if (menu == 2)
                {
                    Console.Write("Digite o nome do aluno para editar: ");
                    string nomeParaEditar = Console.ReadLine().Trim();

                    int indiceParaEditar = -1;
                    for (int i = 0; i < alunos.Count; i = i + 1)
                    {
                        Aluno aluno = alunos[i];
                        // Verificar que o aluno é o aluno que deve ser editado
                        if (aluno.Nome == nomeParaEditar)
                        {
                            indiceParaEditar = i;
                            break;
                        }
                    }

                    // Verificar que o aluno está cadastrado
                    if (indiceParaEditar != -1)
                    {
                        Console.Write("Digite o novo nome: ");
                        alunos[indiceParaEditar].Nome = Console.ReadLine().Trim();
                        Console.Write("Digite a nota 1 do aluno: ");
                        alunos[indiceParaEditar].Nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a nota 2 do aluno: ");
                        alunos[indiceParaEditar].Nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a nota 3 do aluno: ");
                        alunos[indiceParaEditar].Nota3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Aluno " + alunos[indiceParaEditar].Nome + " alterado com sucesso");
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

                    // -1 é a forma de saber que o aluno não está cadastrado
                    int indiceParaApagar = -1;
                    for (int i = 0; i < alunos.Count; i = i + 1)
                    {
                        Aluno aluno = alunos[i];
                        if (aluno.Nome == nome)
                        {
                            // Armazenar o indice do aluno para depois poder apagar
                            indiceParaApagar = i;
                            // Encerrar a execução do for, pq já achamos o aluno que será apagado
                            break;
                        }
                    }

                    // Verificar que o aluno está cadastrado
                    if (indiceParaApagar != -1)
                    {
                        alunos.RemoveAt(indiceParaApagar);
                        Console.WriteLine("Aluno " + nome + " removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não está cadastrado.");
                    }
                }
                else if (menu == 4)
                {
                    for (int i = 0; i < alunos.Count; i = i + 1)
                    {
                        // Obter o aluno que está sendo percorrido para apresentar a média do mesmo
                        Aluno aluno = alunos[i];

                        Console.WriteLine("\nAluno: " + aluno.Nome +
                            "\nN1: " + string.Format("{0:N2}", aluno.Nota1) +
                            "\nN2: " + string.Format("{0:N2}", aluno.Nota2) +
                            "\nN3: " + string.Format("{0:N2}", aluno.Nota3) +
                            "\nMédia: " + string.Format("{0:N2}", aluno.CalcularMedia()));
                    }
                }
                else if (menu == 6)
                {
                    // Apresentar os alunos aprovados
                    for (int i = 0; i < alunos.Count; i = i + 1)
                    {
                        // Obter o aluno que está sendo percorrido para apresentar a média do mesmo
                        Aluno aluno = alunos[i];

                        if (aluno.CalcularMedia() >= 7)
                        {
                            Console.WriteLine("\nAluno: " + aluno.Nome +
                                "\nN1: " + string.Format("{0:N2}", aluno.Nota1) +
                                "\nN2: " + string.Format("{0:N2}", aluno.Nota2) +
                                "\nN3: " + string.Format("{0:N2}", aluno.Nota3) +
                                "\nMédia: " + string.Format("{0:N2}", aluno.CalcularMedia()));
                        }
                    }
                }

                Console.WriteLine("----------------- MENU -----------------");
                Console.WriteLine(" 1 - Cadastrar");
                Console.WriteLine(" 2 - Editar");
                Console.WriteLine(" 3 - Apagar");
                Console.WriteLine(" 4 - Listar");
                Console.WriteLine(" 6 - Listar aprovados");
                Console.WriteLine(" 5 - Sair");
                Console.Write("Digite o menu desejado: ");
                menu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
