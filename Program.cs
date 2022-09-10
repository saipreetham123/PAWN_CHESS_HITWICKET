using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class Program
    {
        public static string[,] grid = new string[5, 5];
        public static bool gamestat = true;
        public static int p1points = 5;
        public static int p2points = 5;

        static void Main(string[] args)
        {
            
            PlayerInput.input();
            PlayerInput.initialarrange("Black");
            PlayerInput.initialarrange("White");

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(grid[i, j] == null || grid[i,j] == " ")
                    {
                        Console.Write("-"+ "   ");
                    }
                    else
                    {
                        Console.Write(grid[i, j] + "  ");
                    }
                    
                }
                Console.WriteLine();
            }
            startgane();
            Console.ReadKey();
        }


        public static void startgane()
        {
            while(gamestat)
            {
                Console.WriteLine("Player1 Input");
                string inp1 = Console.ReadLine();
                Control.move("Player1", inp1);

                Console.WriteLine("Player2 Input");
                string inp2 = Console.ReadLine();
                Control.move2("Player2",inp2);

                Console.WriteLine();

            }
        }

        public static void printboard()
        {
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (grid[i, j] == null || grid[i, j] == " ")
                    {
                        Console.Write("-" + "   ");
                    }
                    else
                    {
                        Console.Write(grid[i, j] + "  ");
                    }

                }
                
                Console.WriteLine();
            }
            if(p1points <=0)
            {
                Console.WriteLine("Player 2 Won The Game");
                
            }

            if(p2points <= 0)
            {
                Console.WriteLine("Player 1 Won The Game");
            }

        }
        
    }
}
