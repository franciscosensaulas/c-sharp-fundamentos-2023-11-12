//int indice = 0;
//while (indice < 10)
//{
//    Console.WriteLine("...");

//    // Incremenetar em 1 a variável indice
//    indice = indice + 1;
//}

//int indice = 0;
//int soma = 0;
//while (indice < 5) // 0 até 4, ou seja, 5 números
//{
//    Console.Write("Digite um número: ");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    soma = soma + numero;

//    indice = indice + 1;
//}

//Console.WriteLine("Soma: " + soma);


int indice = 0;
int quantidadePessoasAdultas = 0;
int quantidadePessoasIdosas = 0;
int somaIdades = 0;
while (indice <= 2)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();

    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    somaIdades = somaIdades + idade;

    if ((idade >= 18) && (idade < 60))
    {
        quantidadePessoasAdultas = quantidadePessoasAdultas + 1;
    }
    else if(idade >= 60)
    {
        quantidadePessoasIdosas = quantidadePessoasIdosas + 1;
    }

    indice = indice + 1;
}

// int + int => int
// int * int => int
// int / int => int
// int / double => int ou double / int => double
double mediaIdades = somaIdades / 3.0;

Console.WriteLine(
    "Média das idades: " + mediaIdades+
    "\nQuantidade de pessoas adultas: " + quantidadePessoasAdultas + 
    "\nQuantidade de pessoas idosas: " + quantidadePessoasIdosas);

// TODO: Next episode: Ensinar sobre:
// - maiorIdade
// - menorIdade
// - nomePessoaMaiorIdade
// - nomePessoaMenorIdade


/*
 *  Exercício: Solicitar os seguintes dados de 5 pessoas
 *  - Nome
 *  - Idade
 *  - Peso
 *  - Altura
 *  Calcular o imc: peso / altura²
 * 
 *  Apresentar no final a quantidade de pessoas de acordo com o imc:
 *  - Quantidade de pessoas abaixo do peso
 *  - Quantidade de pessoas peso normal
 *  - Quantidade de pessoas excesso de peso
 *  - Quantidade de pessoas Obesidade I
 *  - Quantidade de pessoas Obesidade II
 *  - Quantidade de pessoas Obesidade III
 */
