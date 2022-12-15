namespace parOuImpar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int valor = int.Parse(Console.ReadLine());


                if (valor > 0)
                {
                    if (valor % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else if (valor < 0)
                {
                    if (valor % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
                else
                {
                    Console.WriteLine("NULL");
                }

            }


        }
    }
}
