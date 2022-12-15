namespace impostoDeRenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double renda = double.Parse(Console.ReadLine());
            double valor;

            if (renda > 2000 && renda <= 3000)
            {
                valor = (renda - 2000)*0.08;
                Console.WriteLine($"R$ {valor:F2}");
            }else if (renda > 3000 && renda <= 4500)
            {
                valor = (1000 * 0.08) + ((renda - 3000) * 0.18);
                Console.WriteLine($"R$ {valor:F2}");

            }
            else if (renda > 4500)
            {
                valor = 1000 * 0.08 + 1500 * 0.18 + ((renda - 4500) * 0.28);
                Console.WriteLine($"R$ {valor:F2}");
            }
            else
            {
                Console.WriteLine("Isento");
            }

        }
    }
}
