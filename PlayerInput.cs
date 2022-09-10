using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class PlayerInput
    {
        public static string[] white = new string[5];
        public static string[] black = new string[5];
        public static void input()
        {

            Console.WriteLine("Input Player1 Character Names one by one");
            for(int i = 0; i < 5; i++)
            {
                string temp = Console.ReadLine();
                white[i] = temp;
                //white.Append(temp);
            }

            Console.WriteLine("Input Player2 Character Names one by one");
            for (int i = 0; i < 5; i++)
            {
                string temp1 = Console.ReadLine();
                black[i] = temp1;
                //black.Append(temp);
            }

        }

        public static void initialarrange(string str)
        {
            if (str == "Black")
            {
                for(int i = 0; i < 5; i++)
                {
                    Program.grid[0,i] = black[i];
                }
            }
            if (str == "White")
            {
                for(int A = 0; A < 5; A++)
                {
                    Program.grid[4, A] = white[A];
                }
            }
        }
    }
}
