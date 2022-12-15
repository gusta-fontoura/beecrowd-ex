namespace somaDeImparesConsecutivosI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int soma = 0;
            int min, max;

            if (a < b)
            {
                min = a;
                max = b;
            }
            else
            {
                max = a;
                min = b;
            }

            for (int i = (min + 1); i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);


        }
    }
}
