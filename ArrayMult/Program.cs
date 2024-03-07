using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            // matriz: args[0] args[1] args[2] args[3] vetor: args[4] args[5]
            
            // Cria matriz A 2x2
            float[,] mA = new float[2,2];

            // arg1 = args[0]
            mA [0,0] = float.Parse(args[0]);
            // arg2 = args[1]
            mA [0,1] = float.Parse(args[1]);
            // arg3 = args[2]
            mA [1,0] = float.Parse(args[2]);
            // arg4 = args[3]
            mA [1,1] = float.Parse(args[3]);

            // Cria vetor B 2x1
            float[,] vB = new float[2,1];

            // arg5 = args[4]
            vB[0,0] = float.Parse(args[4]);
            // arg6 = args[5]
            vB[1,0] = float.Parse(args[5]);

            // Cria o vetor resultado
            float[,] Ab = new float[2,1];

            // Define valor padrão para matriz
            Ab [0,0] = 0;
            Ab [1,0] = 0;

            // Procura na vertical
            for (int i=0; i<mA.GetLength(0); i++)
            {
                // Procura na horizontal
                for (int j=0; j<mA.GetLength(1);j++)
                {
                    // Multiplica ln i, cln j na matriz pela ln j no vetor
                    Ab[i,0] += mA[i,j] * vB[j,0];
                }

                Console.WriteLine(Ab[i,0]);

            }
        }
    }
}
