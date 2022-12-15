

namespace variasNotasComValidacao
{
    public class Program
    {

        public static void Main(string[] args)
        {
            double x = -1,y = -1;
            int value = 1;
            

            while(value == 1)
            {
                do
                {
                    x = double.Parse(Console.ReadLine());
                    if (x < 0 || x > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                } while (x < 0 || x > 10);

                do
                {
                    y = double.Parse(Console.ReadLine());
                    if (y < 0 || y > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }

                } while (y < 0 || y > 10);
                double media = (x + y) / 2;

                Console.WriteLine($"media = {media:f2}");

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    value = int.Parse(Console.ReadLine());
                } while (value != 1 && value != 2);
            }
        }

    }

}

        
    

