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
                ShowMenu(); // Viser menuen, lokal metode
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
            if (ticTacToe != null) // ? // Udråbstegnligemed betyderer ikke ligemed.
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
            //  Console.WriteLine("skriv koden til at opret nyt spil");
            //   Console.ReadLine(); 
            ticTacToe = new TicTacToe();
        }
        private void DoActionFor2()
        {
            //ticTacToe = new TicTacToe();


            //Console.WriteLine("skriv koden til at få spillerens input til at sætte en brik");
            //Console.ReadLine();
            bool running = true;
            string playerone = "";
            string playertwo = "";
            do
            {

                
                for (int i = 0; i < 20; i++)
                {
                    ShowMenu();
                    if (i == 0 || i == 2 || i == 4)
                    {
                         // Viser menuen, lokal metode
                        
                        playerone = GetUserChoise();
                        switch (playerone)
                        {
                            case "1": DoActionFor1(); i = -1; break;
                            case "øverst venstre": ticTacToe.GameBoard[0, 2] = 'x'; break;
                            case "midten venstre": ticTacToe.GameBoard[0, 1] = 'x'; break;
                            case "nederst venstre": ticTacToe.GameBoard[0, 0] = 'x'; break;
                            case "øverst midten": ticTacToe.GameBoard[1, 2] = 'x'; break;
                            case "midten": ticTacToe.GameBoard[1, 1] = 'x'; break;
                            case "nederst midten": ticTacToe.GameBoard[1, 0] = 'x'; break;
                            case "øverst højre": ticTacToe.GameBoard[2, 2] = 'x'; break;
                            case "midten højre": ticTacToe.GameBoard[2, 1] = 'x'; break;
                            case "nederst højre": ticTacToe.GameBoard[2, 0] = 'x'; break;
                            
                            default: ShowMenuSelectionErroe(); break;

                        }
                    }
                    else //(i == 1 || i == 3 || i == 5)
                    {
                        playertwo = GetUserChoise();
                        switch (playertwo)
                        {
                            case "1": DoActionFor1(); i = 0; break;
                            case "nederst venstre": ticTacToe.GameBoard[0, 0] = '0'; break;
                            case "øverst venstre": ticTacToe.GameBoard[0, 2] = '0'; break;
                            case "midten": ticTacToe.GameBoard[1, 1] = '0'; break;
                            case "midten venstre": ticTacToe.GameBoard[0, 1] = '0'; break;
                            case "øverst midten": ticTacToe.GameBoard[1, 2] = '0'; break;
                            case "nederst midten": ticTacToe.GameBoard[1, 0] = '0'; break;
                            case "øverst højre": ticTacToe.GameBoard[2, 2] = '0'; break;
                            case "midten højre": ticTacToe.GameBoard[2, 1] = '0'; break;
                            case "nederst højre": ticTacToe.GameBoard[2, 0] = '0'; break;
                            default: ShowMenuSelectionErroe(); break;

                        }
                    }
                    
                }
            } while (running);
        }
        private void DoActionFor3()
        {
            Console.WriteLine("skriv koden til at få spillerens input til at flytte en brik");
            Console.ReadLine();
        }
    }
}