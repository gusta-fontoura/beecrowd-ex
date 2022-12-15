namespace Bhaskara
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split();
            double A, B, C, x1, x2, delta;


            A = double.Parse(arr[0]);
            B = double.Parse(arr[1]);
            C = double.Parse(arr[2]);

            delta = (B * B) - (4 * A * C);
            x1 = ((-B) + Math.Sqrt(delta)) / (2 * A);
            x2 = ((-B) - Math.Sqrt(delta)) / (2 * A);

            if (delta > 0 && A != 0)
            {
                
                Console.WriteLine($"R1 = {x1:F5}");
                Console.WriteLine($"R2 = {x2:F5}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}