// Caminho do arquivo de CSV que será armazenado o nome das pessoas com sua idade
using ConsoleTables;

string caminho = "C:\\Users\\moc\\Desktop\\arquivo.csv";

// Verificar que o arquivo CSV não existe
if (File.Exists(caminho) == false)
{
    // Cria o arquivo com o cabeçalho do CSV
    string cabecalho = "Nome;Idade\n";
    File.WriteAllText(caminho, cabecalho);
}
else
{
    // Ler o conteúdo do arquivo retornando um vetor de linhas
    string[] registros = File.ReadAllLines(caminho);
    // Para obter a quantidade de posições do vetor utilizamos a propriedade .Length
    int quantidadeRegistros = registros.Length;

    Console.WriteLine("Registros do arquivo.csv");

    ConsoleTable tabela = new ConsoleTable("Nome", "Idade");

    int indice = 0;
    // Percorrer cada um dos registros 
    while (indice < quantidadeRegistros)
    {
        // Se for a linha do cabeçalho, não apresentar para o usuário
        if (indice == 0)
        {
            indice = indice + 1;
            // Continue é um comando ignorar a execução do conteúdo abaixo do continue
            continue;
        }

        // Obter a linha (registro)
        string registro = registros[indice];
        // Quebrar o registro "Francisco;20" em um vetor, para poder extrair o nome e a idade
        string[] colunas = registro.Split(";");
        // Obter o nome que está na primeira(0) posição do vetor de colunas
        string nome = colunas[0];
        // Obter a idade que está na segunda(1) posição do vetor de colunas
        int idade = Convert.ToInt32(colunas[1]);
        tabela.AddRow(nome, idade);

        indice = indice + 1;
    }
    // Apresentar a tabela
    tabela.Write();
}

// Questiona para o usuário se ele deseja cadastrar registro
Console.Write("\n\nDeseja cadastrar algum registro? [S/N] ");
string desejaContinuar = Console.ReadLine().Trim().ToLower();

while (desejaContinuar == "s")
{
    // Solicita o nome
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();

    // Solicita a idade
    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    
    // Gerar o registro separando o nome e idade com ';'
    string registro = nome + ";" + idade + "\n";
    // Adicionar o registro no arquivo CSV existente
    File.AppendAllText(caminho, registro);

    // Questiona se o usuário deseja cadastrar mais algum registro
    Console.Write("Deseja cadastrar algum registro? [S/N] ");
    desejaContinuar = Console.ReadLine().Trim().ToLower();
}