using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Weeden_Assignment9
{
    abstract class Player
    {
        BitArray pieces;

        public Player()
        {
            pieces = new BitArray(9, false);
        }

        public BitArray Pieces
        {
            get
            {
                return pieces;
            }
        }

        public abstract int MakeMove(int position, string[] board, Player opponent);


    }
}
