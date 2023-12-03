int idade = 0;
bool idadeValida = false;

// Enquanto a idade for inválida irá repetir
while (idadeValida == false)
{
    try
    {
        // Solicitar a idade convertendo para int
        Console.Write("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 0)
        {
            Console.WriteLine("Idade não pode ser negativa");
            continue;
        }
        if (idade > 120)
        {
            Console.WriteLine("Idade máxima é 120");
            continue;
        }

        // Definir a variável de controle de repetição para true, que irá encerrar o while
        idadeValida = true;
    }
    catch (Exception e)
    {
        // Apresentar mensagem que o valor informado não é um valor válido.
        Console.WriteLine("Idade não é um número inteiro válido");
    }
}

double peso = 0;
bool pesoValido = false;

while (pesoValido == false)
{
    try
    {
        Console.Write("Digite o peso: ");
        peso = Convert.ToDouble(Console.ReadLine().ToUpper().Replace("KG", ""));
        // de 1 kg até 400 kg
        if (peso <= 0.99)
        {
            Console.WriteLine("Peso o mínimo é 1kg");
            continue;
        }

        if (peso > 400)
        {
            Console.WriteLine("Peso máximo é 400kg");
            continue;
        }

        pesoValido = true;
    }
    catch (Exception e)
    {
        Console.WriteLine("Valor informado não é um número real válido");
    }
}