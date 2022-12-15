namespace sequeciaIJ4
{
    public class Program 
    { 
        public static void Main(string[] args)
        {
            double i = 0;
            double j = 1;

            while(i <= 2.1)
            {

                Console.WriteLine($"I={i} J={j + i}");
                Console.WriteLine($"I={i} J={j + 1 + i}");
                Console.WriteLine($"I={i} J={j +2 + i}");
                i += 0.2;
            }
        }    
    }

}


