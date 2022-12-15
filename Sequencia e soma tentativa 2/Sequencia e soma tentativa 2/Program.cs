namespace sequenciaDeNumerosESoma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int aux, soma = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int m = int.Parse(input[0]);
                int n = int.Parse(input[1]);

                if (m <= 0 || n <= 0) { break; }

                if (n > m)
                {
                    aux = m;
                    m = n;
                    n = aux;
                }
                for (int i = n; i <= m; i++)
                {
                    Console.Write($"{i} ");
                    soma += i;
                   
                }
                Console.WriteLine($"Sum={soma}");
                soma= 0;
                
            }
            
        }
    }
}

