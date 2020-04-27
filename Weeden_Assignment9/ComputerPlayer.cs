using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Weeden_Assignment9
{
    class ComputerPlayer : Player
    {
        int[,] winningCombos = {    {0,1,2},
                                    {3,4,5},
                                    {6,7,8},
                                    {0,3,6},
                                    {1,4,7},
                                    {2,5,8},
                                    {0,4,8},
                                    {2,4,6} };


        //Makes move based on these crieteria:
        //1) If the Computer can win...that is his move
        //2) If other player can win..that is his move
        //3) the first available spot from this list of numbers 4, 0, 2, 6, 8, 1, 3, 5, 7
        public override int MakeMove(int position, string[] board, Player opponent)
        {

            bool moved = false;

            for (int counter = 0;  counter < winningCombos.GetLength(0); counter++)
            {
                if (moved) { break;  }
                    if (this.Pieces[winningCombos[counter, 0]] && this.Pieces[winningCombos[counter, 1]] && board[winningCombos[counter, 2]] == " ")
                    {
                        position = winningCombos[counter, 2];
                        this.Pieces[position] = true;
                        moved = true;
                    }
                    else if (this.Pieces[winningCombos[counter, 0]] && this.Pieces[winningCombos[counter, 2]] && board[winningCombos[counter, 1]] == " ")
                    {
                        position = winningCombos[counter, 1];
                        this.Pieces[position] = true;
                        moved = true;
                    }
                    else if (this.Pieces[winningCombos[counter, 1]] && this.Pieces[winningCombos[counter, 2]] && board[winningCombos[counter, 0]] == " ")
                    {
                        position = winningCombos[counter, 0];
                        this.Pieces[position] = true;
                        moved = true;
                    }

                    else if (opponent.Pieces[winningCombos[counter, 0]] && opponent.Pieces[winningCombos[counter, 1]] && board[winningCombos[counter, 2]] == " ")
                    {
                        position = winningCombos[counter, 2];
                        this.Pieces[position] = true;
                        moved = true;
                    }
                    else if (opponent.Pieces[winningCombos[counter, 0]] && opponent.Pieces[winningCombos[counter, 2]] && board[winningCombos[counter, 1]] == " ")
                    {
                        position = winningCombos[counter, 1];
                        this.Pieces[position] = true;
                        moved = true;;
                    }
                    else if (opponent.Pieces[winningCombos[counter, 1]] && opponent.Pieces[winningCombos[counter, 2]] && board[winningCombos[counter, 0]] == " ")
                    {
                        position = winningCombos[counter, 0];
                        this.Pieces[position] = true;
                        moved = true;
                    }
                    else
                    {
                        int[] MoveList = new int[] { 4, 0, 2, 6, 8, 1, 3, 5, 7 };
                        foreach (int move in MoveList)
                        {
                            if (board[move] == " " && !moved)
                            {
                                position = move;
                                Console.WriteLine("piece moved   " + position);
                                this.Pieces[move] = true;
                                moved = true;
                            }
                        }
                    }
            }
            return position;
        }

        public ComputerPlayer() : base()
        {
        }
    }
}
