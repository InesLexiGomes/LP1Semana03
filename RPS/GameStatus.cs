using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStatus
{
        [Flags]
        public enum Status
        {
            Draw = 0,
            Player1Wins = 1,
            Player2Wins = 2
        }

}
