// Exceção: é algo que ocorre quando algo inesperado acontece.
// Exemplo: usuário deveria digitar um número porém coloca espaços ou letras
try
{
    int numero1 = Convert.ToInt32("10");
    int numero2 = Convert.ToInt32("12p");

    int soma = numero1 + numero2;

    Console.WriteLine("Número 01: " + numero1);
    Console.WriteLine("Número 02: " + numero2);
    Console.WriteLine("Soma: " + soma);
}
catch(Exception e)
{
    Console.WriteLine("Aconteceu um erro na conversão de número");
}

Console.WriteLine("Programa encerrou corretamente");


// Solicitar o nome, idade, peso para usuário
Console.Write("\n\nDigite o nome");
string nome = Console.ReadLine();
int idade = 0;
try
{
    // Solicitar a idade
    Console.Write("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
}
catch(Exception e)
{
    Console.WriteLine("Idade não é um número inteiro válido");
}

double peso = 0;
try
{
    // Solicitar o peso
    Console.Write("Digite o peso: ");
    peso = Convert.ToDouble(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("Peso não é um valor real válido");
}

Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + "\nPeso: " + peso);