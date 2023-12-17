using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp17ListaObjetos
{
    internal class Exemplo00
    {
        public void Executar()
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno paulo = new Aluno();
            paulo.Nome = "Paulo";
            paulo.Nota1 = 9.4;
            paulo.Nota2 = 8;
            paulo.Nota3 = 7.6;

            alunos.Add(paulo);

            Aluno jose = new Aluno();
            jose.Nome = "José";
            jose.Nota1 = 5;
            jose.Nota2 = 4;
            jose.Nota3 = 3;
            alunos.Add(jose);

            // Apresentar o nome do primeiro aluno:
            Console.WriteLine("Nome do 1º aluno: " + alunos[0].Nome);

            Aluno primeiroAluno = alunos[0];
            Console.WriteLine("Nome do 1º aluno: " + primeiroAluno.Nome);

            // Remover o segundo aluno
            alunos.Remove(jose);

            // Alterar a nota do primeiro aluno
            alunos[0].Nota1 = 9.0;

            Console.WriteLine("Nome: " + alunos[0].Nome);
            Console.WriteLine("Nota 1: " + alunos[0].Nota1);
            Console.WriteLine("Nota 2: " + alunos[0].Nota2);
            Console.WriteLine("Nota 3: " + alunos[0].Nota3);

            Aluno maria = new Aluno();
            maria.Nome = "Maria";
            maria.Nota1 = 10;
            maria.Nota2 = 9;
            maria.Nota3 = 4;
            alunos.Add(maria);

            Aluno eduarda = new Aluno();
            eduarda.Nome = "Eduarda";
            eduarda.Nota1 = 1;
            eduarda.Nota2 = 2.5;
            eduarda.Nota3 = 3.4;
            alunos.Add(eduarda);

            // Percorrer a lista para descobrir se o José está cadastrado ou n
            bool joseExiste = false;
            for (int i = 0; i < alunos.Count; i = i + 1)
            {
                Aluno alunoPercorrido = alunos[i];
                if (alunoPercorrido.Nome == "José")
                {
                    joseExiste = true;
                }
            }

            if (joseExiste)
            {
                Console.WriteLine("José existe na escola");
            }
            else
            {
                Console.WriteLine("José foi removido da escola");
            }

            // Percorrer a lista para remover a Maria caso existir
            for (int i = 0; i < alunos.Count; i = i + 1)
            {
                Aluno alunoPercorrido = alunos[i];
                // Verificar se o nome do aluno é maria
                if (alunoPercorrido.Nome == "Maria")
                {
                    // Remover a maria da escola
                    alunos.Remove(alunoPercorrido);
                }
            }
        }
    }
}
