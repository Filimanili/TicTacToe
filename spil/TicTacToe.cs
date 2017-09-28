using System;
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
        public char Validate()
        {

            char resultat = ' ';

            char BottomRowOne = GameBoard[0, 0];
            char BottomRowTwo = GameBoard[1, 0];
            char BottomRowThree = GameBoard[2, 0];
            char leftRowOneChar = GameBoard[0, 0];
            char leftRowTwoChar = GameBoard[0, 1];
            char leftRowThreeChar = GameBoard[0, 2];

            char midRowTwoChar = GameBoard[1, 1];
            char midRowThreeChar = GameBoard[1, 2];

            char rightRowTwoChar = GameBoard[2, 1];
            char rightRowThreeChar = GameBoard[2, 2];
            if (BottomRowOne == BottomRowTwo && BottomRowTwo == BottomRowThree) //Nederst vandret
            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
            }
            if (leftRowOneChar == leftRowTwoChar && leftRowTwoChar == leftRowThreeChar) //Venstre lodret
            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
            }
            if (BottomRowOne == midRowTwoChar && midRowTwoChar == leftRowThreeChar) //Venstre til højre diagonal

            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
            }
            if (BottomRowThree == midRowTwoChar && midRowTwoChar == leftRowThreeChar) // Højre til venstre diagonal
            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
            }
            if (leftRowTwoChar == midRowTwoChar && midRowTwoChar == rightRowTwoChar) //Vandret midten
            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
            }
            if (leftRowThreeChar == midRowThreeChar && midRowThreeChar == rightRowThreeChar) //Vandret øverst
            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
            }
            if (BottomRowTwo == midRowTwoChar && midRowTwoChar == midRowThreeChar) //midten lodret
            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
            }
            if (BottomRowThree == rightRowTwoChar && rightRowTwoChar == rightRowThreeChar)// Højre lodret
            {
                Console.WriteLine("Du har vundet");
                Console.ReadKey();
                
            }
            // return rowOneChar;

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
