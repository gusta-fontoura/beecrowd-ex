namespace Animal
{
    public class Program
    {
        public static void Main(string[] args)

        {
            string palavra0 = Console.ReadLine();
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string[] entry = {palavra0,palavra1,palavra2};

            if (entry[0] == "vertebrado")
            {

                if (entry[1] == "ave")
                {
                    if (entry[2] == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (entry[2] == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }

                    
                }
            }
            else
            {
                if (entry[1] == "inseto")
                {
                    if (entry[2] == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (entry[2] == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

            
        }
    }
}
