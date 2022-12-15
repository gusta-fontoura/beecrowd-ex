namespace sequenciaDeNumerosESoma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split();

            int M = int.Parse(valor[0]), N = int.Parse(valor[1]);

            int soma = 0;

            while(true)
            {
                if (M < 0 || N < 0)
                {
                    break;
                }
                else if(M > N)
                {
                    for(int i = N; i <= M; i++)
                    {
                        soma += i;
                        Console.Write($"{i}");
                    }
                }else if(M < N)
                {
                    for (int i = M; i <= N ; i++)
                    {
                        soma += i;
                        Console.Write($"{i}");
                    }
                }
                else
                {
                    soma = M;
                    Console.Write($"{M}");
                }
                Console.Write($" Sum={soma}");
                Console.WriteLine();
                valor = Console.ReadLine().Split();
                M = int.Parse(valor[0]);
                N= int.Parse(valor[1]);
                soma= 0;
                

                







            }
        }
    }
}