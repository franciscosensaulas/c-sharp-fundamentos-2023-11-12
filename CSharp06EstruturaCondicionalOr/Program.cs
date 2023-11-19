// Por indicação ou tem o score bom (score > 700)

Console.Write("Pessoa tem indicação (S/N): ");
string temIndicacaoTexto = Console.ReadLine().ToLower(); 
// ToLower converte o que usuário digitou para caixa baixa 
bool temIndicacao = false;

// Verificando se o usuário informou "s" ou "sim"
if ((temIndicacaoTexto == "s") || (temIndicacaoTexto == "sim"))
{
    temIndicacao = true;
}

Console.Write("Digite o score da pessoa: ");
int score = Convert.ToInt32(Console.ReadLine());

if ((temIndicacao == true) || (score > 700))
{
    Console.WriteLine("Abertura da conta realizada com sucesso");
}
else
{
    Console.WriteLine("Não é possível abrir a conta");
}
// Tabela Verdade do OU
// Verdadeiro ou Verdadeiro     => Verdadeiro
// Falso ou Verdadeiro          => Verdadeiro
// Verdadeiro ou Falso          => Verdadeiro
// Falso ou Falso               => Falso