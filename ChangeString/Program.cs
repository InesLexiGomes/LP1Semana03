using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pede uma string ao utilizador
            Console.Write("String: ");
            string input1 = Console.ReadLine();

            // Pede um caráter ao utilizador
            Console.Write("Char: ");
            string input2 = Console.ReadLine();
            // Passa de string a char
            char cara = char.Parse(input2);

            // Define a string final
            string stringFinal = "";

            // Procura todos os carateres
            foreach (char a in input1)
            {
                // Se for igual ao carater do utilizador 
                if (a == cara)
                {
                    // Troca por X
                    stringFinal += "X";
                }
                // Se não
                else
                {
                    // Coloca igual
                    stringFinal += a;
                }
            }

            // Imprime string final
            Console.WriteLine(stringFinal);

        }
    }
}
