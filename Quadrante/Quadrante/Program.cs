﻿namespace quadrante
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string[] valores = Console.ReadLine().Split();

                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }else if(x>0 && y< 0)
                {
                    Console.WriteLine("quarto");
                }else if(x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }else if(x<0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else
                {
                    break;
                }

            }
        }
    }
}
