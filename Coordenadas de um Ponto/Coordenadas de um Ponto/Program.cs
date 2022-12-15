namespace coordenadasDeUmPonto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eixoX, eixoY;

            string[] eixos = Console.ReadLine().Split(' ');

            eixoX = double.Parse(eixos[0]);
            eixoY = double.Parse(eixos[1]);

            if (eixoX == 0.0 && eixoY == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (eixoX == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (eixoY == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (eixoX > 0.0 && eixoY > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX < 0.0 && eixoY > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (eixoX < 0.0 && eixoY < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (eixoX > 0.0 && eixoY < 0.0)
            {
                Console.WriteLine("Q4");
            }

        }
    }
}