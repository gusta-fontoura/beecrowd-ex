namespace maiorEPosicao 
{
    public class Program
    {

       
        public static void Main(string[] args)
        {

            int n, aux = 0, pos = 0;

            for(int i = 0; i < 100; i++)
            {
                n = int.Parse(Console.ReadLine());

                if(n > aux)
                {
                    aux = n;
                    pos = i;
                }
            }

            Console.WriteLine(aux);
            Console.WriteLine(pos + 1);






        }

    }
}



