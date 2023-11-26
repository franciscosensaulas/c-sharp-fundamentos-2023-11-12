// Caminho do arquivo de CSV que será armazenado o nome das pessoas com sua idade
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
    string registrosTexto = File.ReadAllText(caminho);
    // Quebrar a string em um vetor de strings
    string[] registros = registrosTexto.Split("\n");

    Console.WriteLine(registros[0]);
    Console.WriteLine(registros[1]);
    Console.WriteLine("\n\n\n");
    //[0] = "Nome;Idade"
    //[1] = "Francisco;20"
    //[2] = "Julio;40"


}

// Questiona para o usuário se ele deseja cadastrar registro
Console.Write("Deseja cadastrar algum registro? [S/N] ");
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