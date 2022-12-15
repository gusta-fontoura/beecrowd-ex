using System;

class URI
{

    static void Main(string[] args)
    {

        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        for (int i = 1; i <= 5; i++)
        {
            int valores = int.Parse(Console.ReadLine());
            if (valores % 2 == 0)
            {
                pares++;
            }
            if (valores % 2 != 0)
            {
                impares++;
            }
            if (valores > 0)
            {
                positivos++;
            }
            if (valores < 0)
            {
                negativos++;
            }


        }
        Console.WriteLine($"{pares} valor(es) par(es)\n{impares} valor(es) impar(es)\n{positivos} valor(es) positivo(s)\n{negativos} valor(es) negativo(s)");

    }

}