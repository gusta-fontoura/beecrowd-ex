using System.Security.Cryptography.X509Certificates;

namespace senhaFixa
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            while(true)
            {
                int x = int.Parse(Console.ReadLine());

                if (x != 2002) {
                Console.WriteLine("Senha Invalida");

                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
            }
        }
    }
}
