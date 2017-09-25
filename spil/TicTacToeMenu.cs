using System;

namespace spil
{
    public class TicTacToeMenu
    {
        TicTacToe ticTacToe {get; set; } // Property
        public void Show() //Tager user input. Her starter selve menuen.
        {
            bool running = true;      
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default : ShowMenuSelectionErroe(); break; 
                }
            } while (running); //Eksekvere ovenstående kode, når running = true
        }

        private void ShowMenu()
        {
            Console.Clear();
            if (ticTacToe != null) // ? // Udråbstegnligemed betyder: er ikke.
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
            }
            Console.WriteLine("tic tac toe");
            Console.WriteLine();
            Console.WriteLine("1. Oret nyt spil");
            Console.WriteLine("2. Set en brik");
            Console.WriteLine("3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. exit");
        }

        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: "); //Returnerer den værdi man taster ind.
            return Console.ReadLine();
        }

        private void ShowMenuSelectionErroe()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
        }

        private void DoActionFor1() //Skal erstattes. Skal referere til game boarded.
        {
            Console.WriteLine("skriv koden til at opret nyt spil");
            Console.ReadLine();
        }
        private void DoActionFor2()
        {
            Console.WriteLine("skriv koden til at få spillerens input til at sætte en brik");
            Console.ReadLine();
        }
        private void DoActionFor3()
        {
            Console.WriteLine("skriv koden til at få spillerens input til at flytte en brik");
            Console.ReadLine();
        }
    }
}