namespace aumentoDeSalario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string valor = Console.ReadLine();

            double salario = double.Parse(valor);

            if (salario <= 400)
            {
                double novoSalario = salario * 1.15;
                double reajuste = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}" + $"\nReajuste ganho: {reajuste:F2}" + $"\nEm percentual: 15 %");
            }
            else if (salario > 400 && salario <= 800)
            {
                double novoSalario = salario * 1.12;
                double reajuste = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}" + $"\nReajuste ganho: {reajuste:F2}" + $"\nEm percentual: 12 %");
            }
            else if (salario > 800 && salario <= 1200)
            {
                double novoSalario = salario * 1.10;
                double reajuste = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}" + $"\nReajuste ganho: {reajuste:F2}" + $"\nEm percentual: 10 %");

            } else if(salario > 1200 && salario <= 2000){
                double novoSalario = salario * 1.07;
                double reajuste = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}" + $"\nReajuste ganho: {reajuste:F2}" + $"\nEm percentual: 7 %");
            }
            else
            {
                double novoSalario = salario * 1.04;
                double reajuste = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}" + $"\nReajuste ganho: {reajuste:F2}" + $"\nEm percentual: 4 %");
            }
        }
    }
}
