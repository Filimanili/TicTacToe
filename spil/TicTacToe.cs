﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe
    {
        public char[,] GameBoard { get; set; } //Property
        public TicTacToe()
        {
            GameBoard = new char[3, 3] { {' ', ' ', ' '}, // Her skabes tabellen/brættet
                {' ', ' ', ' '}, 
                { ' ', ' ', ' '} };
        }

        public string GetGameBoardView() //
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }

       // public char Validate() //Antages at validere om der er nogle der har vundet.
            private static char CheckForThree(char[,] GameBoard)
        {
            //  char resultat = ' ';
            //   return GameWinner.ToCharArray;
            char rowOneChar = GameBoard[0, 0];
            char rowTwoChar = GameBoard[1, 0];
            char rowThreeChar = GameBoard[2, 0];
            if (rowOneChar == rowTwoChar &&
                rowTwoChar == rowThreeChar);
            {
                return rowOneChar;
            }
            return ' ';
        }
       // string GameWinner = "Du har vundet";
            //{
            //    var columnOneChar = GameBoard[0, 0];
            //    var columnTwoChar = GameBoard[0, 1];
            //    var columnThreeChar = GameBoard[0, 2];
            //    if (columnOneChar == columnTwoChar &&
            //        columnTwoChar == columnThreeChar)
            //    {
            //        return columnOneChar;
            //    }
            //    return ' ';
            //}
          
            //string winnerState = "Du har vundet";
            //const char expected = 'x';
            //GameBoard = new char[3, 3] { {expected, expected, expected},
            //  {' ', ' ', ' '},
            //{ ' ', ' ', ' '} };

            //return winnerState[0];
        

        // her kan implementeres metoder til at sætte og flytte en brik

    }
}
