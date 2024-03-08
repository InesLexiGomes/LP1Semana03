using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerks = Perks.WaterBreathing | Perks.Stealth | Perks.AutoHeal | Perks.DoubleJump;

            myPerks ^= Perks.WaterBreathing;
            myPerks ^= Perks.Stealth;
            myPerks ^= Perks.AutoHeal;
            myPerks ^= Perks.DoubleJump;

            if (args.Length == 0)
            {
                Console.WriteLine("No perks at all!");
                return;
            }

            for (int i = 0; i < args.Length; i++)
            {
                foreach (char character in args[i])
                {
                    if (character == 'w')
                    {
                        myPerks ^= Perks.WaterBreathing;
                    }
                    else if (character == 's')
                    {
                        myPerks ^= Perks.Stealth;
                    }
                    else if (character == 'a')
                    {
                        myPerks ^= Perks.AutoHeal;
                    }
                    else if (character == 'd')
                    {
                        myPerks ^= Perks.DoubleJump;
                    }
                    else
                    {
                        Console.WriteLine("Unknown Perk!");
                        return;
                    }
                }
            }

            Console.WriteLine(myPerks);
            if (( myPerks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
            {
                Console.WriteLine("Silent jumper!");
            }
            if (( myPerks & Perks.AutoHeal ) != Perks.AutoHeal)
            {
                Console.WriteLine("Not Gonna Make It!");
            }
        }
    }
}