using System;
namespace Media3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');

            double N1, N2, N3, N4, media;

            N1 = double.Parse(notas[0]);
            N2 = double.Parse(notas[1]);
            N3 = double.Parse(notas[2]);
            N4 = double.Parse(notas[3]);

            media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10;
            media = Math.Round(media, 1);
            System.Console.WriteLine($"Media: {media:F1}");

            if (media >= 7)
            {
                System.Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5)
            {
                System.Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                System.Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine());
                System.Console.WriteLine($"Nota do exame: {notaExame:F1}");
                media = (notaExame + media) / 2;
                media = Math.Round(media, 1);
                if (media >= 5) 
                {
                    System.Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    System.Console.WriteLine("Aluno reprovado.");
                }
                System.Console.WriteLine($"Media final: {media:F1}");
            }
        }
    }
}