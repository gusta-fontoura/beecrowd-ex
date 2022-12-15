namespace intervalo2 {
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int x = 0, y = 0;

            for (int i = 0; i < N; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                if (valores >= 10 && valores <= 20)
                {
                    x++;
                }
                else
                {
                    y++;
                }
            }

            Console.WriteLine($"{x} in");
            Console.WriteLine($"{y} out");
        }

    }
}
