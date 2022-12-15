namespace granais_1131
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int resultadoEmpate = 0;
            int resultadoInter = 0;
            int resultadoGremio = 0;
            int golsGremio;
            int golsInter;
            int grenais = 0;
            int resposta = 1;

            while (resposta == 1)
            {
                string[] times = Console.ReadLine().Split();
                golsInter = int.Parse(times[0]);
                golsGremio = int.Parse(times[1]);

                grenais += 1;

                if (golsInter > golsGremio)
                {
                    resultadoInter += 1;
                }
                else if (golsInter < golsGremio)
                {
                    resultadoGremio += 1;
                }
                else if (golsGremio == golsInter)
                {
                    resultadoEmpate += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");

                resposta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter: {resultadoInter}");
            Console.WriteLine($"Gremio: {resultadoGremio}");
            Console.WriteLine($"Empates: {resultadoEmpate}");

            if (resultadoInter > resultadoGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (resultadoInter < resultadoGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}


