using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string var in args)
            {
                if (var.Length > 3)
                {
                    if (var.Length > 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(var);
                    }
                }
            }
        }
    }
}
