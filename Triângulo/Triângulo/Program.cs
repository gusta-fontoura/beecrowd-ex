using System.ComponentModel.Design;

namespace Triangulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');

            double a, b, c, d, e;

            a = double.Parse(numeros[0]);
            b= double.Parse(numeros[1]);
            c= double.Parse(numeros[2]);

            double um = b - c;
            double dois = a - c;
            double tres = a - b;

            double um2 = b + c;
            double dois2 = a + c;
            double tres2 = a + b;

            if(um < a && a < um2 && dois < b && b < dois2 && tres < c && c < tres2)
            {
               d = a + b + c ;
               Console.WriteLine($"Perimetro = {d:F1}");
            }
            else
            {
                e = (a + b) * c / 2;
                Console.WriteLine($"Area = {e:F1}");
            }
             
            
        }
    }
}