namespace crescenteEDecrescente
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                string[] valores = Console.ReadLine().Split();
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (x > y) {

                    Console.WriteLine("Decrescente");
                } else if( x < y) {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    break;
                }

            }
        }
    }
}
