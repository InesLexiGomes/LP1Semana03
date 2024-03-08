using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameItem
{
        [Flags]
        public enum Items
        {
            Rock = 1 << 0,
            Paper = 1 << 1,
            Scissors = 1 << 2
        }

}
