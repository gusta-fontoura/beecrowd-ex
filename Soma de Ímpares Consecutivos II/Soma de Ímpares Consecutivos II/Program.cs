namespace somaDeImparesConsecutivosII
{
    public class Program

    {
        
        public static void Main(string[] args)
        {
            int soma = 0;
            
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                
                string[] teste = Console.ReadLine().Split();

                int x = int.Parse(teste[0]);
                int y = int.Parse(teste[1]);

                if (x > y)
                {
                    int aux;
                    aux = y;
                    y = x; x = aux;
                }

                for (int j = x + 1; j < y; j++)
                {
                    
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}

            
