namespace seisNumerosImpares
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            int valor = int.Parse(Console.ReadLine());
            int control = 0;

           if (valor % 2 == 0) 
           {
                control = valor+1;
           }
            else 
            {
               control= valor;
            }
        
            for(int i = control; i<= valor + 11; i++)
            {
                if( i % 2 != 0) 
                {
                    Console.WriteLine($"{i}");                
                }
            }
        }


    }
}
