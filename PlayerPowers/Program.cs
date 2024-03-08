using System;
using Powers;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many players? ");
            string input1 = Console.ReadLine();
            int numPlayers = int.Parse(input1);

            PowerEnum [] playerPowersA = new PowerEnum [numPlayers];

            for (int i = 0; i < playerPowersA.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Player {i+1} tell me your powers: ");
                    string pwr = Console.ReadLine();

                    if(pwr == "Fly")
                    {
                        playerPowersA[i] ^= PowerEnum.Fly;
                    }
                    else if (pwr == "XRayVision")
                    {
                        playerPowersA[i] ^= PowerEnum.XRayVision;
                    }
                    else if(pwr == "SuperStrength")
                    {
                        playerPowersA[i] ^= PowerEnum.SuperStrength;
                    }
                    else
                        continue;
                }
            }
            for (int i = 0; i < playerPowersA.Length; i++)
            {
                Console.Write($"Player {i+1} your powers are ");
                Console.WriteLine(playerPowersA[i].ToString());
                if ((playerPowersA[i] & PowerEnum.Fly) == PowerEnum.Fly && 
                ((playerPowersA[i] & 
                PowerEnum.SuperStrength) == PowerEnum.SuperStrength))
                    {
                        Console.WriteLine("Flying Radiation!");
                    }
            }
            
            

        }
    }
}
