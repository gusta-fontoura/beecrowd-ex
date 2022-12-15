namespace tempoDeJogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;
            string[] valores = Console.ReadLine().Split();

            horaInicial= int.Parse(valores[0]);
            horaFinal= int.Parse(valores[1]);

            if(horaInicial > horaFinal )
            {
                duracao = 24 - horaInicial + horaFinal;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }else if(horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
                
        }



    }
}