using System;
class URI
{

    static void Main(string[] args)
    {

        int total = 0;
        for (int i = 0; i < 6; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > 0)
            {
                total++;

            }

        }
        Console.WriteLine($"{total} valores positivos");
    }
}
