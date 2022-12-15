namespace tabuada{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) 
            {
                int multiplicar = i * N;
                Console.WriteLine($"{i} x {N} = {multiplicar}");
            }
        }
    }
}
