﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{ //Hej med jer
  //Virker det?
    class Program
    {
        static void Main(string[] args) // Kører selve programmet
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            TicTacToeMenu ticTacToeMenu = new TicTacToeMenu(); //Når programmet bliver kørt, eksekveres denne kode der starter menuen op
            ticTacToeMenu.Show();
        }
    }
}
