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


//int indice = 0;
//int quantidadePessoasAdultas = 0;
//int quantidadePessoasIdosas = 0;
//int somaIdades = 0;
//while (indice <= 2)
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine().Trim();

//    Console.Write("Idade: ");
//    int idade = Convert.ToInt32(Console.ReadLine());

//    somaIdades = somaIdades + idade;

//    if ((idade >= 18) && (idade < 60))
//    {
//        quantidadePessoasAdultas = quantidadePessoasAdultas + 1;
//    }
//    else if(idade >= 60)
//    {
//        quantidadePessoasIdosas = quantidadePessoasIdosas + 1;
//    }

//    indice = indice + 1;
//}

//// int + int => int
//// int * int => int
//// int / int => int
//// int / double => int ou double / int => double
//double mediaIdades = somaIdades / 3.0;

//Console.WriteLine(
//    "Média das idades: " + mediaIdades+
//    "\nQuantidade de pessoas adultas: " + quantidadePessoasAdultas + 
//    "\nQuantidade de pessoas idosas: " + quantidadePessoasIdosas);

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


//int indice = 0;
//int quantidadeAbaixoPeso = 0, quantidadePesoNormal = 0, quantidadeExcessoPeso = 0;
//int quantidadeObesidade1 = 0, quantidadeObesidade2 = 0, quantidadeObesidade3 = 0;

//while (indice < 5)
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine().Trim();

//    Console.Write("Idade: ");
//    int idade = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Peso: ");
//    double peso = Convert.ToDouble(Console.ReadLine());

//    Console.Write("Altura: ");
//    double altura = Convert.ToDouble(Console.ReadLine());

//    double imc = peso / Math.Pow(altura, 2); // Altura ao quadrado

//    indice = indice + 1;

//    if (imc > 0)
//    {
//        if (imc < 18.5)
//        {
//            quantidadeAbaixoPeso = quantidadeAbaixoPeso + 1;
//        }
//        else if (imc < 25)
//        {
//            quantidadePesoNormal = quantidadePesoNormal + 1;
//        }
//        else if (imc < 30)
//        {
//            quantidadeExcessoPeso = quantidadeExcessoPeso + 1;
//        }
//        else if (imc < 35)
//        {
//            quantidadeObesidade1 = quantidadeObesidade1 + 1;
//        }
//        else if (imc < 40)
//        {
//            quantidadeObesidade2 = quantidadeObesidade2 + 1;
//        }
//        else
//        {
//            quantidadeObesidade3 = quantidadeObesidade3 + 1;
//        }


//    }
//}

//Console.WriteLine(
//    "\nQuantidade Abaixo Peso: " + quantidadeAbaixoPeso +
//    "\nQuantidade Peso Normal: " + quantidadePesoNormal +
//    "\nQuantidade Excesso Peso: " + quantidadeExcessoPeso +
//    "\nQuantidade Obesidade 1: " + quantidadeObesidade1 +
//    "\nQuantidade Obesidade 2: " + quantidadeObesidade2 +
//    "\nQuantidade Obesidade 3: " + quantidadeObesidade3);

int indice = 0;
double menorKmPorLitro = 9999999999999;
int maiorQuantidadeKm = 0;
string modeloMenorKmPorLitro = "", modeloMaiorQuantidadeKm = "";

Console.Write("Informe a quantidade de carros que deseja validar: ");
int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

while(indice < quantidadeDesejada)
{
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine().Trim();

    Console.Write("Quilometros rodados: ");
    int quantidadeKm = Convert.ToInt32(Console.ReadLine());

    Console.Write("Quilometros por litro: ");
    double kmPorLitro = Convert.ToDouble(Console.ReadLine());

    // Descobrir a maior quilometragem rodada
    if (quantidadeKm > maiorQuantidadeKm)
    {
        maiorQuantidadeKm = quantidadeKm;
        modeloMaiorQuantidadeKm = modelo;
    }

    // Descobrir o menor consumo por litro
    if (kmPorLitro < menorKmPorLitro)
    {
        menorKmPorLitro = kmPorLitro;
        modeloMenorKmPorLitro = modelo;
    }

    Console.WriteLine("\n\n");
    indice = indice + 1;
}

Console.WriteLine(
     modeloMenorKmPorLitro  + " possui o menor consumo por Litro: " + menorKmPorLitro + 
    "\n" + modeloMaiorQuantidadeKm + " possui a maior quilometragem rodados: " + maiorQuantidadeKm);