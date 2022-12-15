using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace multiploDe13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int aux = 0;
            int soma = 0;
            
            if ( n1 > n2 )
            {
                for (int i = n2; i <= n1; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int i = n1; i <= n2; i++)
                {
                    if(i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}
