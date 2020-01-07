using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName="";
            bool gameOver = false;

            Console.WriteLine("Enter Player 1 Name:");
            playerName = Console.ReadLine();
            Tic_Tac_Toe player1 = new Tic_Tac_Toe( 1, playerName);
            Console.WriteLine("Enter Player 2 Name OR Enter \"com\" to play with Computer");
            playerName = Console.ReadLine();
            Tic_Tac_Toe player2 = new Tic_Tac_Toe( 2, playerName);

            while (!gameOver)
            {
                Tic_Tac_Toe.initboard();
                while (!player1.playGame() && !player2.playGame())
                    gameOver = true;

                if(gameOver)
                {
                    Console.WriteLine("Do you Want to Play Another game. Press Esc to Quit");
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Good bye");
                    }
                    else
                        gameOver = false;
                                        
                }
                Console.ReadLine();
            }
            
        }
    }
}
