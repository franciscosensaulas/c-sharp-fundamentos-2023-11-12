// Exemplo 00:
//Forma antiga sem conhecer vetores
int idade1 = 21;
int idade2 = 14;
int idade3 = 30;
int idade4 = 5;
int idade5 = 18;

// Criar um vetor com 5 posições
int[] idades = new int[5];
// tipo[] nomeVetor = new tipo[quantidadePosicoes];

// Armazenar as idades no vetor, lembrando que a primeira posição do vetor é 0.
idades[0] = 21;
idades[1] = 14;
idades[2] = 30;
idades[3] = 5;
idades[4] = 18;

// Somar todas as idades, obtendo o valor armazenado nas posições do vetor para somar
int soma = idades[0] + idades[1] + idades[2] + idades[3] + idades[4];

// Apresentar as idades
Console.WriteLine("1ª Posição: " + idades[0]);
Console.WriteLine("2ª Posição: " + idades[1]);
Console.WriteLine("3ª Posição: " + idades[2]);
Console.WriteLine("4ª Posição: " + idades[3]);
Console.WriteLine("5ª Posição: " + idades[4]);
Console.WriteLine("Soma: " + soma);


// Exemplo 01:
// Armazenar os nomes dos produtos
string[] produtos = new string[3]; // Vetor de 3 posições, temos disponivel é 0,1,2.
int[] quantidades = new int[3];
double[] precosUnitarios = new double[3];

// Solicitar para o usuário nome, quantidade e preço unitário dos 3 produtos
Console.Write("Nome: ");
produtos[0] = Console.ReadLine().Trim();
Console.Write("Quantidade: ");
quantidades[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Preço Unitário: ");
precosUnitarios[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n");

Console.Write("Nome: ");
produtos[1] = Console.ReadLine().Trim();
Console.Write("Quantidade: ");
quantidades[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Preço Unitário: ");
precosUnitarios[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n");

Console.Write("Nome: ");
produtos[2] = Console.ReadLine().Trim();
Console.Write("Quantidade: ");
quantidades[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Preço Unitário: ");
precosUnitarios[2] = Convert.ToDouble(Console.ReadLine());

// Calcular o valor pago por cada produto
double[] precoProdutos = new double[3];
precoProdutos[0] = quantidades[0] * precosUnitarios[0]; // Multiplicar a quantidade do 1º produto com preço unitário do 1º produto
precoProdutos[1] = quantidades[1] * precosUnitarios[1]; // Multiplicar a quantidade do 2º produto com preço unitário do 2º produto
precoProdutos[2] = quantidades[2] * precosUnitarios[2]; // Multiplicar a quantidade do 3º produto com preço unitário do 3º produto

// Somar o total dos produtos
double total = precoProdutos[0] + precoProdutos[1] + precoProdutos[2];

Console.WriteLine("\n\nProduto 1: " + precoProdutos[0]);
Console.WriteLine("Produto 2: " + precoProdutos[1]);
Console.WriteLine("Produto 3: " + precoProdutos[2]);
Console.WriteLine("Total: " + total);

// Exercício:
// nome, quantidade horas, valor hora, desconto da unimed e uniodonto
// Solicitar os dados de 2 pessoas
// Apresentar salário bruto, salário líquido, soma dos descontos

string[] funcionarios = new string[2];
int[] quantidadeHoras = new int[2];
double[] valorHoras = new double[2];
double[] descontosUnimed = new double[2];
double[] descontosUniodonto = new double[2];

Console.Write("Nome: ");
funcionarios[0] = Console.ReadLine().Trim();
Console.Write("Quantidade de horas trabalhadas: ");
quantidadeHoras[0] = Convert.ToInt32(Console.ReadLine().Trim());
Console.Write("Valor hora: ");
valorHoras[0] = Convert.ToDouble(Console.ReadLine().Trim());
Console.Write("Valor do desconto da Unimed: ");
descontosUnimed[0] = Convert.ToDouble(Console.ReadLine().Trim());
Console.Write("Valor do desconto da Uniodonto: ");
descontosUniodonto[0] = Convert.ToDouble(Console.ReadLine().Trim());

Console.Write("Nome: ");
funcionarios[1] = Console.ReadLine().Trim();
Console.Write("Quantidade de horas trabalhadas: ");
quantidadeHoras[1] = Convert.ToInt32(Console.ReadLine().Trim());
Console.Write("Valor hora: ");
valorHoras[1] = Convert.ToDouble(Console.ReadLine().Trim());
Console.Write("Valor do desconto da Unimed: ");
descontosUnimed[1] = Convert.ToDouble(Console.ReadLine().Trim());
Console.Write("Valor do desconto da Uniodonto: ");
descontosUniodonto[1] = Convert.ToDouble(Console.ReadLine().Trim());

double[] salariosBruto = new double[2];
double[] salariosLiquido = new double[2];
double[] descontos = new double[2];

salariosBruto[0] = quantidadeHoras[0] * valorHoras[0];
descontos[0] = descontosUnimed[0] + descontosUniodonto[0];
salariosLiquido[0] = salariosBruto[0] - descontos[0]; 

salariosBruto[1] = quantidadeHoras[1] * valorHoras[1];
descontos[1] = descontosUnimed[1] + descontosUniodonto[1];
salariosLiquido[1] = salariosBruto[1] - descontos[1];

Console.WriteLine(
    "Funcionário: " + funcionarios[0] +
    "\nSalário Bruto: " + salariosBruto[0] +
    "\nSoma dos Descontos: " + descontos[0] +
    "\nSalário Líquido: " + salariosLiquido[0] + 

    "\n\nFuncionário: " + funcionarios[1] +
    "\nSalário Bruto: " + salariosBruto[1] +
    "\nSoma dos Descontos: " + descontos[1] +
    "\nSalário Líquido: " + salariosLiquido[1]
    );