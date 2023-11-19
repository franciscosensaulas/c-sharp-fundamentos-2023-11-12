Console.Write("Digite o preço do produto: ");
double precoProduto = Convert.ToDouble(Console.ReadLine());

// Temos produtos em estoque no range de R$ 950.75 até R$ 2540.60
if ((precoProduto >= 950.75) && (precoProduto <= 2540.60))
{
    Console.WriteLine("Temos produtos em estoque");
}
else
{
    Console.WriteLine("Não encontramos produtos em estoque neste momento");
}

// Tabela Verdade && (E)
// Verdadeiro e Verdadeiro  => Verdadeiro
// Verdadeiro e Falso       => Falso
// Falso e Verdadeiro       => Falso
// Falso e Falso            => Falso