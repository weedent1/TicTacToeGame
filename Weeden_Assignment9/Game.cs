using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weeden_Assignment9
{
    class Game
    {
        Player playerH;
        Player playerC;
        Board gameBoard;
        string[] gameArray = new string[9];
        string gamePlayer;

        //keeps game in loop asking if player would like to play again agyer game is over
        public void PlayAgain()
        {
            string response;
           
            DisplayWelcome();
          

            do
            {
                Console.Clear();
                Play();
                Console.Write("\n\nWould you like to play again? (Y / N)");
                response = Console.ReadLine().ToUpper();
                response = response.Substring(0, 1);
            }
            while (response == "Y");
        }

        //prints out the welcome message explainging the game
        public void DisplayWelcome()
        {
            Console.WriteLine("\n\n\nReady to have a rousing game of Tic Tac toe?  The object");
            Console.WriteLine("of the game is to get three of your pieces either across, up and down,");
            Console.WriteLine("or diagonally.  If you do, before your opponent, you win the game!");
            Console.WriteLine("\n\nHit any key when you are ready to begin");
            Console.ReadKey();
            Console.Clear();
        }

        //instructions to play through a game
        public void Play()
        {
            bool result = false;
            bool tieGame = false;
            int selection;

            playerH = new HumanPlayer();
            playerC = new ComputerPlayer();
            gameBoard = new Board();

            for (int index = 0; index < gameArray.Length; index++)
                gameArray[index] = " ";
            gamePlayer = "H";

            DisplayBoardGrid();
           
            do
            {
                selection = IsPlaying(gamePlayer);
                DisplayBoardGrid();
                DisplayGrid(selection);

                if (gamePlayer == "H")
                    result = gameBoard.IsWinner(playerH);
                else
                    result = gameBoard.IsWinner(playerC);

                if (result)
                {
                    DisplayGrid(selection);
                    AnnounceWinner();
                }
                else
                    tieGame = gameBoard.IsFull();

                if (tieGame)
                    IsTie();

                if (gamePlayer == "H")
                    gamePlayer = "C";
                else
                    gamePlayer = "H";
            }
            while (!(tieGame || result));
            
        }

        //displays grid of board showing user what spot corresponds to each number
        public void DisplayBoardGrid()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t 0 | 1 | 2 ");
            Console.WriteLine("\t------------");
            Console.WriteLine("\t 3 | 4 | 5 ");
            Console.WriteLine("\t------------");
            Console.WriteLine("\t 6 | 7 | 8 ");
            Console.WriteLine("\n\n");
        }

        //determines who is playing and then prompts that player types move
        public int IsPlaying(string thePlayer)
        {
            int userselection = 0;

            if (thePlayer == "H")
            {
                Console.Write("Player {0}, choose your location: ", thePlayer);
                while ((int.TryParse(Console.ReadLine(), out userselection) == false) || (userselection > 8) || (gameArray[userselection] != " "))
                {
                    Console.WriteLine("\nPlease enter a free number between 1 and 8 that appears on the grid");
                    Console.Write("\nPlayer {0}, choose your location: ", thePlayer);
                }
                playerH.MakeMove(userselection, gameArray, playerC);
                Console.Clear();
                return userselection;

            }

            else  {
                userselection = playerC.MakeMove(userselection, gameArray, playerC);
                Console.Clear();
                return userselection;
            }
        }

        //displays where moves have been made on the game board
        public void DisplayGrid(int theSelection)
        {
            gameArray[theSelection] = gamePlayer;

            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t {0} | {1} | {2} ", gameArray[0], gameArray[1], gameArray[2]);
            Console.WriteLine("\t------------");
            Console.WriteLine("\t {0} | {1} | {2} ", gameArray[3], gameArray[4], gameArray[5]);
            Console.WriteLine("\t------------");
            Console.WriteLine("\t {0} | {1} | {2} ", gameArray[6], gameArray[7], gameArray[8]);
            Console.WriteLine("\n\n\n");

        }

        //displays who wont the game
        public void AnnounceWinner()
        {

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Player {0} has one the game!\n\n\n", gamePlayer);
        }

        //displays when there is a tie
        public void IsTie()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("The game is a draw. No one won!\n\n\n");
        }
    }
}
