namespace coordenadaDeUmPonto{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] coord = Console.ReadLine().Split(' ');

            double x, y;

            x = double.Parse(coord[0]);
            y = double.Parse(coord[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}

//Q4
//Q4
