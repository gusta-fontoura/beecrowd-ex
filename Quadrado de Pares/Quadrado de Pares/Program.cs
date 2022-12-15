using System.Data;

namespace quadradoDePares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            for (int i = 0; i <= N; i++)
            {
                if(i % 2 == 0 && i > 0)
                {
                    int pot = (int)Math.Pow(i, 2);
                    Console.WriteLine($"{i}^2 = {pot}");
                }
                
            }
        }
    }
}