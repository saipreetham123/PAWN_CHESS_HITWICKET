using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class Control
    {
        public static string controlcom;

        public static int move(string player,string inp)
        {
            string[] temp = inp.Split(':');

            if(player == "Player1")
            {
                for(int i = 0; i<5; i++)
                {
                    for(int j = 0;j<5;j++)
                    {
                        if(Program.grid[i,j] == temp[0])
                        {
                            switch(temp[1])
                            {
                                case "L":
                                    Program.grid[i, j - 1] = Program.grid[i, j];
                                    Program.grid[i,j] = " ";
                                    if (PlayerInput.white.Contains(Program.grid[i, j - 1]))
                                    {
                                        Program.p2points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "R":
                                    Program.grid[i,j + 1] = Program.grid[i, j];
                                    Program.grid[i,j] = " ";
                                    if (PlayerInput.white.Contains(Program.grid[i, j + 1]))
                                    {
                                        Program.p2points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "F":
                                    Program.grid[i - 1, j] = Program.grid[i, j];
                                    Program.grid[i,j] = " ";
                                    if (PlayerInput.white.Contains(Program.grid[i - 1, j]))
                                    {
                                        Program.p2points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "B":
                                    Program.grid[i + 1, j] = Program.grid[i, j];
                                    Program.grid[i,j] = " ";
                                    if (PlayerInput.white.Contains(Program.grid[i + 1, j]))
                                    {
                                        Program.p2points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                
                            }
                            return 0;
                            //switch case
                            //move coin
                        }

                    }

                }

            }
            return 0;
        }

        public static int move2(string player, string inp)
        {
            string[] temp1 = inp.Split(':');

            if (player == "Player2")
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        //Console.WriteLine(k);
                        //Console.WriteLine(l);
                        //Console.WriteLine(Program.grid[k, l]);
                        //Console.WriteLine(temp1[0]);
                        //Console.ReadKey();
                        if(Program.grid[k, l] == temp1[0])
                        {
                            //switch case
                            switch (temp1[1])
                            {
                                case "L":
                                    Program.grid[k, l - 1] = Program.grid[k, l];
                                    Program.grid[k, l] = " ";
                                    if (PlayerInput.black.Contains(Program.grid[k, l - 1]))
                                    {
                                        Program.p1points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "R":
                                    Program.grid[k, l + 1] = Program.grid[k, l];
                                    Program.grid[k, l] = " ";
                                    if (PlayerInput.black.Contains(Program.grid[k, l + 1]))
                                    {
                                        Program.p1points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "F":
                                    Program.grid[k + 1, l] = Program.grid[k, l];
                                    Program.grid[k, l] = " ";
                                    if (PlayerInput.black.Contains(Program.grid[k + 1, l]))
                                    {
                                        Program.p1points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "B":
                                    Program.grid[k - 1, l] = Program.grid[k, l];
                                    Program.grid[k, l] = " ";
                                    if (PlayerInput.black.Contains(Program.grid[k - 1, l]))
                                    {
                                        Program.p1points = Program.p2points - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                            }

                        }
                    }
                }
            }
            return 0;
        }
    }
}
