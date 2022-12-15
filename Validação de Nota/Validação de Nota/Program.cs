using System.Transactions;

namespace validacaoDeNota
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double media = 0;
            double i = 0;
            double soma = 0;
            while (i < 2)
            {
               double nota = double.Parse(Console.ReadLine());
                if(nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma += nota;
                    media = soma / 2;
                    i++;
                }

            }
            
                

                
            
        }
    }
}
