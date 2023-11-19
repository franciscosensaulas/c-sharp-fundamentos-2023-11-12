Console.WriteLine("Olá mundo");
Console.WriteLine("Opa aula de C#");  // Irá imprimir e deslocar o cursor para a próxima linha
// Console.Write("Olá mundo"); Irá imprimir e manter o cursor na mesma linha

Console.WriteLine("2 + 2"); // "2 + 2" é considerado string(texto)
Console.WriteLine(2 + 2); // Soma de o número inteiro 2 + o número inteiro 2 => apresentando 4
Console.WriteLine("Soma: " + 2 + 2);
// "Soma: " + 2 => string + número inteiro => string => "Soma: 2"
// "Soma: 2" + 2 => string  + número inteiro => string => "Soma: 22"
// + => concatenação: unir duas coisas "Francisco" + " Lucas Sens" => "Francisco Lucas Sens"
// + => operação de soma: 2 + 2 => 4

Console.WriteLine("Soma: " + (2 + 2)); // string + (int + int) => string + int => string => "Soma: 4"
Console.WriteLine("Subtração: " + (2 - 2));
Console.WriteLine("Multiplicação: " + (2 * 2));
Console.WriteLine("Divisão: " + (2 / 2));
Console.WriteLine("Resto da divisão: " + (2 % 2));



Console.WriteLine("        *");
Console.WriteLine("       ***");
Console.WriteLine("      *****");
Console.WriteLine("     *******");
Console.WriteLine("    *********");
Console.WriteLine("   ***********");
Console.WriteLine("  *************");

// Declaração e atribuição de valor para as variáveis
string nomeAluno = "Pedro"; // string é utilizado para armazenar texto
string sobrenomeAluno = "Silva";
string nomeCompletoAluno = nomeAluno + " " + sobrenomeAluno;
int idadeAluno = 36; // int é utilizado para armazenar número inteiro
double salarioAluno = 8500.30; // double é utilizado para armazenar número real
bool ehMatriculadoAluno = true; // bool é utilizado para armazenar true(verdadeiro) ou false(falso)
char letraFavoritaAluno = 'G'; // char é utilizado para armazenar um caracter

int quantidadeHorasTrabalhadasAluno = 200;
double valorHoraAluno = salarioAluno / quantidadeHorasTrabalhadasAluno;

Console.WriteLine("Nome completo do aluno: " + nomeCompletoAluno);
Console.WriteLine("Idade do aluno: " + idadeAluno);
Console.WriteLine("Salário do aluno: " + salarioAluno);
Console.WriteLine("Valor hora do aluno: " + valorHoraAluno);
Console.WriteLine("Aluno matriculado: " + ehMatriculadoAluno);
Console.WriteLine("Letra Favorita aluno: " + letraFavoritaAluno);

// Armazenar os dados do nome do aluno, nota 1, nota2 e nota 3.
// Escolher um nome, nota 1, nota 2 e nota 3.
// Calcular a média do aluno e apresentar a média.

Console.WriteLine("\n\n\nAperte qualquer tecla para continuar..."); // \n é utilizado para quebrar a linha 
Console.ReadKey(); // Aguarda o usuário apertar qualquer tecla.
Console.Clear(); // Limpeza do console

// Input(Entrada) de dados 
Console.WriteLine("Digite o nome do produto");
string nomeProduto = Console.ReadLine(); // Permitir o usuário digitar

// int, double, bool, char


// Output(Saída) de dados
Console.WriteLine("Nome escolhido: " + nomeProduto);