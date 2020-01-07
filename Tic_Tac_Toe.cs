using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_1
{
    public class Tic_Tac_Toe
    {
        static int[,] board;
        string _playerName;

        public Tic_Tac_Toe(int player, string playerName)
        {
            PlayerName = playerName;
            Player = player;
            board = new int[3, 3];
        }
         public int Player { get; set; }
         public string PlayerName {

            get { return _playerName;}
            set {
                if (value.Length > 0)
                {
                    _playerName = value;
                }
                else
                {
                    while (value.Length < 1)//Input Cannot be Empty
                    {
                        Console.WriteLine("invalid Input, please enter a Players Name");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        public static void initboard()
        {
            for(int r = 0; r<3; r++)
            {   
                for(int c = 0; c<3; c++)
                {
                    board[r,c] = 0;
                }
            }drawBorad();
        }
        static void drawBorad()
        {
            for (int r = 0; r < 3; r++)
            {
                for(int c=0; c < 3; c++)
                {
                    Console.Write(board[r,c]+" ");//0 0 0
                    //Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public bool playGame()
        {
            int r = 0;
            int c = 0;

            Random rand1 = new Random();
            Random rand2 = new Random();

            if (PlayerName != "com")//Human
            {
                Console.WriteLine("Please Enter your selection {0}", PlayerName);
                int.TryParse(Console.ReadLine().Trim(), out r);
                int.TryParse(Console.ReadLine().Trim(), out c);
            }
            else
            {
                r = rand1.Next(1, 3);
                c = rand2.Next(1, 3);
            }
            while (!chkInput(r, c))
            {
                if (PlayerName != "com")
                {
                    Console.WriteLine("You entered a invalid Co-ordinates, please try again");
                    int.TryParse(Console.ReadLine().Trim(), out r);
                    int.TryParse(Console.ReadLine().Trim(), out c);
                }
                else
                {
                    r = rand1.Next(1,3);
                    c = rand2.Next(1,3);
                }
            }

            board[r-1, c-1] = Player;
            drawBorad();//update new board

            if (win())
            {
                if (PlayerName.Equals("com"))
                    {
                    Console.WriteLine("Computer wins");
                    }
                else
                    Console.WriteLine("Congratulations {0} You win", PlayerName);

                return true;
            }
            else if (draw())
            {
                Console.WriteLine("Its a Draw");
                return true;
            }
            return false;

         }
        private bool win()
        {
            
                //check rows
                if (board[0, 0].Equals(Player) && board[0, 1].Equals(Player) && board[0, 2].Equals(Player))
                    return true;
                if (board[1, 0].Equals(Player) && board[1, 1].Equals(Player) && board[1, 2].Equals(Player))
                    return true;
                if (board[2, 0].Equals(Player) && board[2, 1].Equals(Player) && board[2, 2].Equals(Player))
                    return true;

                //check cols
                if (board[0, 0].Equals(Player) && board[1, 0].Equals(Player) && board[2, 0].Equals(Player))
                    return true;
                if (board[0, 1].Equals(Player) && board[1, 1].Equals(Player) && board[2, 1].Equals(Player))
                    return true;
                if (board[0, 2].Equals(Player) && board[1, 2].Equals(Player) && board[2, 2].Equals(Player))
                    return true;

                //check diagonals
                if (board[0, 0].Equals(Player) && board[1, 1].Equals(Player) && board[2, 2].Equals(Player))
                    return true;
                if (board[0, 2].Equals(Player) && board[1, 1].Equals(Player) && board[2, 0].Equals(Player))
                return true;


            return false;
        }
        
 
        private bool draw()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r,c] != 1 && board[r,c] != 2)
                        return false;//still empty spaces
                }
            }return true;
        }
      
        private bool chkInput(int r, int c)
        {
            bool k = false;
            if (r > 3 || c > 3)//input out_of_bound
                 k= false;

            if (board[r-1, c-1] != 1 && board[r-1, c-1] != 2)//place not taken
                k = true;

            return k;
          
        }

        
    }
}
