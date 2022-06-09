using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILX_videoGameClub
{
    
    public class Game
     {
        public sbyte gameId { get; set; }
        public string platform { get; set; }
        public string gameName { get; set; }
        public sbyte quantity { get; set; }
        public bool isBorrowed { get; set; }

        public bool BorrowGame(bool game)
        {
            return isBorrowed = true;

        }

     }
    
}
