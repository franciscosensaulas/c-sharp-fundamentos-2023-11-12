Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.Write("Digite a quantidade para compra: ");
// Usuário digita como string e essa string é convertida para int
int quantidade = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o preço unitário: ");
double precoUnitario = Convert.ToDouble(Console.ReadLine());

double precoTotal = quantidade * precoUnitario;

Console.WriteLine("Produto: " + nomeProduto);
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("Preço unitário: " + precoUnitario);
Console.WriteLine("Preço total: " + precoTotal);

// Ctrl + K (solta) + C => Comantar o código
// Ctrl + K (solta) + U => Descomentar o código

// Exercício: Solicitar:
// - salário do usuário
// - valor da conta de internet, energia e água
// - valor da mensalidade da natação
// - quantidade de mensalidades do IPTU e valor mensal (será realizado o pagamento total naquele mês)
// Apresentar no final:
// - Total das contas 
// - Total pago no IPTU
// - Valor restante do pagamento (subtraído as contas)

// Resolução do exercício:
// Inptus
Console.Write("Digite o valor do salário: ");
double valorSalario = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor da conta de internet: ");
double valorContaInternet = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor da conta de energia: ");
double valorContaEnegeria = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor da conta de água: ");
double valorContaAgua = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de parcelas do IPTU: ");
int quantidadeParcelasIptu = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor da parcela do IPTU: ");
double valorParcelaIptu = Convert.ToDouble(Console.ReadLine());

// Processamento
double totalContas = valorContaAgua + valorContaEnegeria + valorContaInternet;
double totalIptu = quantidadeParcelasIptu * valorParcelaIptu;
double totalDespesas = totalContas + totalIptu;
double valorSalarioRestante = valorSalario - totalDespesas;

// Output
Console.Clear();
Console.WriteLine("- Total das contas: " + totalContas);
Console.WriteLine("- Total IPTU: " + totalIptu);
Console.WriteLine("- Salário restante: " + valorSalarioRestante);