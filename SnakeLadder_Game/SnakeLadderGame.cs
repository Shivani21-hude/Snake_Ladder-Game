using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder_Game
{
    public class SnakeLadderGame
    {
        public static void UC2RollsDice()
        {
            int start = 0;
            int position = 0;
            Random random = new Random();
            int Dice = random.Next(1, 7);
            Console.WriteLine("Player at position {0} for to start the game  ", start);
            Console.WriteLine("After rolls the dice ,Player at postion : " + Dice);
        }
    }
}
