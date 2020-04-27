using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Weeden_Assignment9
{
    class HumanPlayer : Player
    {

        //changes bitmap to true for move spot
        public override int MakeMove(int position, string[] board, Player opponent)
         {
            this.Pieces[position] = true;
            return position;
         }

        public HumanPlayer() : base()
        {
        }

}
}
