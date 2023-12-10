namespace CSharp13OOMetodos.Exemplos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Aluno aluno1 = new Aluno();

            aluno1.Logica = new Materia();
            Console.Write("Digite a nota 1 de Lógica: ");
            aluno1.Logica.Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 1 de Lógica: ");
            aluno1.Logica.Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 1 de Lógica: ");
            aluno1.Logica.Nota3 = Convert.ToDouble(Console.ReadLine());

            aluno1.BancoDados = new Materia();
            Console.Write("Digite a nota 1 de Banco de Dados: ");
            aluno1.BancoDados.Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 2 de Banco de Dados: ");
            aluno1.BancoDados.Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 3 de Banco de Dados: ");
            aluno1.BancoDados.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Média de lógica: " + aluno1.Logica.CalcularMedia());
            Console.WriteLine("Média de banco de dados: " + aluno1.BancoDados.CalcularMedia());
            Console.WriteLine("Status da matéria de lógica: " + aluno1.Logica.ObterStatus());
            Console.WriteLine("Status da matéria de banco de dados: " + aluno1.BancoDados.ObterStatus());
            Console.WriteLine("Status: " + aluno1.ObterStatus());
        }
    }
}
// parâmetros de métodos