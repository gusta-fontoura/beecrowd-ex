using System.Runtime.Serialization.Formatters;

namespace SequenciaIJ2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1; int j = 7; int aux = i;

            
            for(i=1; i<=9; i+=2)
            {
                for (j = 6+i;j>3+i;j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
           
            
                
           
                

                
            


        }

    }
}


