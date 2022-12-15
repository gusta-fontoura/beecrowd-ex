namespace dividndoXporY
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            double divisao = 0;
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split();
                
                double x = double.Parse(valores[0]);
                double y = double.Parse(valores[1]);
                

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = x / y;
                    Console.WriteLine($"{divisao:F1}");
                }

            }

        }
    }
}
