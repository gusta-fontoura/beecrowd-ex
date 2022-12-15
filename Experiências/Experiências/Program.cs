namespace experiencia
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            int N;
            
            int total = 0, coelho = 0, sapo = 0, rato = 0;

            

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string[] arr = Console.ReadLine().Split();

                int q = int.Parse(arr[0]);
               

                total += q;

                if (arr[1] == "C") coelho += q;
                if (arr[1] == "S") sapo += q;
                if (arr[1] == "R") rato += q;
            }

            float x = (float)coelho / total * 100;
            float y = (float)rato / total * 100;
            float z = (float)sapo / total*100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");
            Console.WriteLine($"Percentual de coelhos: {x:F2} %");
            Console.WriteLine($"Percentual de ratos: {y:F2} %" );
            Console.WriteLine($"Percentual de sapos: {z:F2} %" );
            
        }
    }
}
