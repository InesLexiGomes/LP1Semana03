using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string var in args)
            {
                // determina se palavra > 3 caráteres
                if (var.Length > 3)
                {
                    // determina se palavra > 6 caráteres
                    if (var.Length > 6)
                    {
                        // termina o programa
                        break;
                    }
                    else
                    {
                        // imprime as palavras com mais de 3 caráteres
                        Console.WriteLine(var);
                    }
                }
            }
        }
    }
}
