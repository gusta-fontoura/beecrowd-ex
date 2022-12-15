using System;

namespace tempoDeJogoComMinutos
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int a, b, c, d;
            string[] valores = Console.ReadLine().Split();

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);
            d = int.Parse(valores[3]);

            //490
            int dif = ((a * 60) + b) - ((c * 60) + d); 
            if(dif>= 0)
            {
               dif += 24 * 60;
            }
               dif = dif * (-1);
                int hora = dif / 60;
                int minuto = dif % 60;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S) e {minuto} MINUTO(S)");
            

        }
    }
}




/*using System; 

class URI {

    static void Main(string[] args) { 

        string[] rawConsole = Console.ReadLine().Split(' ');

        int a = int.Parse(rawConsole[0]);
        int b = int.Parse(rawConsole[1]);
        int c = int.Parse(rawConsole[2]);
        int d = int.Parse(rawConsole[3]);

        int totalM1 = (a * 60) + b;
        int totalM2 = (c * 60) + d;

        if (totalM2 <= totalM1)
            totalM2 += 1440;

        int total = totalM2 - totalM1;
        
        int totalHours = total / 60;
        int totalMinutes = total % 60;

        Console.WriteLine($"O JOGO DUROU {totalHours} HORA(S) E {totalMinutes} MINUTO(S)");
        

    }

}
        }*/