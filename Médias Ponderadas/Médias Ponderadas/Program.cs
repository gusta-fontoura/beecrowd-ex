namespace mediaPonderadas
{
    public class Program    
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) 
            {
                string[] valores = Console.ReadLine().Split(' ');
                
                double valor1 = double.Parse(valores[0]),
                valor2 = double.Parse(valores[1]),
                valor3 = double.Parse(valores[2]);

                double media = (valor1 * 2 + valor2 * 3 + valor3 * 5)/10;
                Console.WriteLine($"{media:F1}");
            }

        }
    }
}