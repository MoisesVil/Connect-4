using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempName
{
    public class Gameboard
    {
        public const int rows = 6;

        public const int columns = 7;

        public int[,] board;

        public int[] highestPeice;

        public bool player1Turn = true;

        // -1 = Game not done
        // 0 = Tie
        // 1 = Player 1 Won
        // 2 = Player 2 Won
        public int Winner = -1;

        public Gameboard()
        {
            board = new int[rows, columns];
            highestPeice = new int[columns];

            resetBoard();
        }

        /// <summary>
        /// Method to reset gameboard and set all values back to initla values
        /// </summary>
        public void resetBoard()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    board[i, j] = 0;
                }
            }

            for (int i = 0; i < columns; i++)
            {
                highestPeice[i] = -1;
            }

            player1Turn = true;
            Winner = -1;
        }

        /// <summary>
        /// Method to place a peice on the board
        /// </summary>
        /// <param name="column">Column to place the peice into</param>
        /// <returns>Whether the peice can be played or not</returns>
        public bool PlacePeice(int column)
        {
            for (int i = 0; i < rows; i++)
            {
                if (board[i, column] == 0)
                {
                    if (player1Turn) board[i, column] = 1;
                    else board[i, column] = 2;

                    highestPeice[column] = i;

                    player1Turn = !player1Turn;
                    CheckForWin();
                    CheckForTie();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method to check if the game has ended in a tie
        /// </summary>
        /// <returns>Whether the game is a tie</returns>
        public void CheckForTie()
        {
            bool tie = true;

            for (int i = 0; i < columns; i++)
            {
                if (highestPeice[i] != 5) tie = false;
            }

            if (tie == true) Winner = 0;
        }

        /// <summary>
        /// Method to check if a player has won yet
        /// </summary>
        /// <returns>Whether a win has been detected or not</returns>
        // Does not entirely work
        public void CheckForWin()
        {
            int num;

            
            // Checks for horizontal line win  ( - )
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < (columns - 3); j++)
                {
                    if (board[i, j] != 0)
                    {
                        num = board[i, j];

                        if (num == board[i, j + 1] && num == board[i, j + 2] && num == board[i, j + 3])
                        {
                            if (num == 1) Winner = 1;
                            else Winner = 2;
                            return;
                        }
                    }
                }
            }


            // Check for vertical line win  ( | )
            for (int i = 0; i < (rows - 3); i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (board[i, j] != 0)
                    {
                        num = board[i, j];

                        if (num == board[i + 1, j] && num == board[i + 2, j] && num == board[i + 3, j])
                        {
                            if (num == 1) Winner = 1;
                            else Winner = 2;
                            return;
                        }
                    }
                }
            }


            // Checks for diagonal win ( / )
            for (int i = 0; i < (rows - 3); i++)
            {
                for (int j = 0; j < (columns - 3); j++)
                {
                    if (board[i, j] != 0)
                    {
                        num = board[i, j];

                        if (num == board[i + 1, j + 1] && num == board[i + 2, j + 2] && num == board[i + 3, j + 3])
                        {
                            if (num == 1) Winner = 1;
                            else Winner = 2;
                            return;
                        }
                    }
                }
            }


            // Checks for diagonal win ( \ )
            for (int i = 0; i < (rows - 3); i++)
            {
                for (int j = (columns - 1); j > 2; j--)
                {
                    if (board[i, j] != 0)
                    {
                        num = board[i, j];

                        if (num == board[i + 1, j - 1] && num == board[i + 2, j - 2] && num == board[i + 3, j - 3])
                        {
                            if (num == 1) Winner = 1;
                            else Winner = 2;
                            return;
                        }
                    }
                }
            }
        }
    }
}
