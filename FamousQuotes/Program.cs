using System;

namespace FamousQuotes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Taxi driver
            Console.WriteLine("You talking to me?");
            MyPrecious();
            
            // Matrix
            Console.WriteLine("Dodge this");
            Hasta();
        }

        private static void Hasta()
        {
            TheMoney();

            // Terminator
            Console.WriteLine("Hasta la vista, baby.");
            MyPrecious();
        }

        private static void TheMoney()
        {
            // Jerry Maguire
            Console.WriteLine("Show me the money!");
        }

        private static void MyPrecious()
        {
            TheMoney();

            // Lord of the rings
            Console.WriteLine("My precious.");
        }
    }
}
