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

            int resultatx = 'x';
            int resultat0 = '0';
            
           

            int BottomRowOne = GameBoard[0, 0];
            int BottomRowTwo = GameBoard[1, 0];
            int BottomRowThree = GameBoard[2, 0];
            int leftRowOneChar = GameBoard[0, 0];
            int leftRowTwoChar = GameBoard[0, 1];
            int leftRowThreeChar = GameBoard[0, 2];
            int midRowTwoChar = GameBoard[1, 1];
            int midRowThreeChar = GameBoard[1, 2];
            int rightRowTwoChar = GameBoard[2, 1];
            int rightRowThreeChar = GameBoard[2, 2];

            if (BottomRowOne == resultat0 && BottomRowTwo == resultat0 && BottomRowThree == resultat0 || 
                leftRowTwoChar == resultat0 && midRowTwoChar == resultat0 && midRowThreeChar == resultat0 ||
                leftRowThreeChar == resultat0 && midRowThreeChar == resultat0 &&  rightRowThreeChar == resultat0) //Bolle vandret
            {
                Console.WriteLine("BOLLE har vundet");
                Console.ReadKey();
            }
            if (leftRowOneChar == resultat0 && leftRowTwoChar == resultat0 && leftRowThreeChar == resultat0 ||
                BottomRowTwo == resultat0 && midRowTwoChar == resultat0 && midRowThreeChar == resultat0 ||
                BottomRowThree == resultat0 && rightRowTwoChar == resultat0 && rightRowThreeChar == resultat0) // lodret bolle
            {
                Console.WriteLine("BOLLE har vundet");
                Console.ReadKey();
            }
            if (BottomRowOne == resultat0 && midRowTwoChar == resultat0 && rightRowThreeChar == resultat0 ||
                BottomRowThree == resultat0 && midRowTwoChar == resultat0 && leftRowThreeChar == resultat0 ) //Bolle diagonaler
            {
                Console.WriteLine("BOLLE har vundet");
                Console.ReadKey();
            }
            if (BottomRowOne == resultatx && BottomRowTwo == resultatx && BottomRowThree == resultatx ||
                 leftRowTwoChar == resultatx && midRowTwoChar == resultatx && midRowThreeChar == resultatx ||
                 leftRowThreeChar == resultatx && midRowThreeChar == resultatx && rightRowThreeChar == resultatx) //Kryds vandret
            {
                Console.WriteLine("KRYDS har vundet");

                Console.ReadKey();

            }
            if (leftRowOneChar == resultatx && leftRowTwoChar == resultatx && leftRowThreeChar == resultatx ||
                BottomRowTwo == resultatx && midRowTwoChar == resultatx && midRowThreeChar == resultatx ||
                BottomRowThree == resultatx && rightRowTwoChar == resultatx && rightRowThreeChar == resultatx) // lodret kryds
            {
                Console.WriteLine("KRYDS har vundet");
                Console.ReadKey();
            }
            if (BottomRowOne == resultatx && midRowTwoChar == resultatx && rightRowThreeChar == resultatx ||
                BottomRowThree == resultatx && midRowTwoChar == resultatx && leftRowThreeChar == resultatx) // diagonaler kryds
            {
                Console.WriteLine("KRYDS har vundet");
                Console.ReadKey();
            }

            return ' ';
        }

    }
}
