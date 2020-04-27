using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeden_Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("#9 Tic Tac Toe Game");

            Game newGame = new Game();
            newGame.PlayAgain();




        }
    }
}
