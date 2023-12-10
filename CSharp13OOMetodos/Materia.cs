namespace CSharp13OOMetodos
{
    internal class Materia
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalcularMedia()
        {
            double soma = Nota1 + Nota2 + Nota3;
            double media = soma / 3;

            return media;
        }

        public string ObterStatus()
        {
            double media = CalcularMedia();

            string status = "";
            if (media < 5)
            {
                status = "Reprovado";
            }
            else if (media < 7)
            {
                status = "Em exame";
            }
            else
            {
                status = "Aprovado";
            }

            return status;
        }
    }
}
