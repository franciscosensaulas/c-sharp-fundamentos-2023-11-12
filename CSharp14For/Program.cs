// Exemplo de utilização de while, pois não sabe-se quantos pacientes serão atendidos
//string temPaciente = "s";
//while (temPaciente == "s")
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine();


//    Console.Write("Tem paciente para atendimento? ");
//    temPaciente = Console.ReadLine().ToLower();
//}


//// Deve apresentar a mensagem 5 vezes, podendo utilizar while ou for
//int indice = 0;
//while(indice < 5)
//{
//    Console.WriteLine("Hello, World!");
//    indice = indice + 1;
//}
//Console.WriteLine("Fim while\n\n\n");


//// For é utilizado para percorrer de um determinado indice até outro
//// for (declaração variável; condição repetição; incrementar/decrementar)
for (int indice = 0; indice < 5; indice = indice + 1)
{
    Console.WriteLine("Hello, World!");
}

// Solicitar o nome e sobrenome de quatro pessoas
// (de 0 até 3, ou seja, 4 dados solicitados)
for (int i = 0; i <= 3; i = i + 1)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Sobrenome: ");
    string sobrenome = Console.ReadLine();

    string nomeCompleto = nome + " " + sobrenome;
    Console.WriteLine("Nome Completo: " + nomeCompleto);
}

//// Apresentar contagem do número 0 até 100
//// 0 até 100
for (int i = 0; i <= 100; i = i + 1)
{
    Console.WriteLine(i);
}

//// Apresentar contagem regressiva de final de ano
//// 10 9 8 7 6 5 4 3 2 1 0
for (int i = 10; i >= 0; i = i + 1)
{
    Console.WriteLine(i);
}


// Apresentar um relógio
// 00:00:00
// 00:00:01
// .......
// 00:59:59
// 01:00:00
// 23:59:59 // termina
for (int hora = 0; hora <= 23; hora = hora + 1)
{
    for (int minuto = 0; minuto <= 59; minuto = minuto + 1)
    {
        for (int segundo = 0; segundo <= 59; segundo = segundo + 1)
        {
            Console.WriteLine(hora + ":" + minuto + ":" + segundo);
            Thread.Sleep(1000);
        }
    }
}

// Obter o caminho da pasta do Desktop do usuário logado
string caminhoDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string caminho = Path.Combine(caminhoDesktop, "Arquivos");

// Verificar se a pasta não existe
if (Directory.Exists(caminho) == false)
{
    // Criar pasta Arquivos no Desktop do usuário
    Directory.CreateDirectory(caminho);
}

for (int i = 0; i < 10_000; i++)
{
    string nomeArquivo = "Arquivo " + i + ".txt";
    string caminhoArquivo = Path.Combine(caminho, nomeArquivo);
    File.WriteAllText(caminhoArquivo, "Olá mundo");
}
Console.WriteLine("Arquivos criados");