namespace CSharp15ForComVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            string[] nomes = new string[2];
            double[] notas1 = new double[nomes.Length];
            double[] notas2 = new double[nomes.Length];
            double[] notas3 = new double[nomes.Length];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Nota 1: ");
                notas1[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 2: ");
                notas2[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 3: ");
                notas3[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                double media = (notas1[i] + notas2[i] + notas3[i]) / 3;
                Console.WriteLine(nomes[i] + " média: " + media);
            }
        }
    }
}
