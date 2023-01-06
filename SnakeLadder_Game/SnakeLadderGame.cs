using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder_Game
{
    public class SnakeLadderGame
    {
        public static void UC3SnakeLadder()
        {
            int start = 0;
            int position = 0;
            Console.WriteLine("Player at position {0} for to start the game  ", start);


            Random random = new Random();
            int Dice = random.Next(0, 7);

            Console.WriteLine("After rolls the dice ,Player at postion : " + Dice);
            int option = random.Next(3);
            if (option == 0)
            {
                Console.WriteLine("No play ");


            }
            else if (option == 1)
            {
                Console.WriteLine("Ladder");
                position += Dice;
                Console.WriteLine("Player at positon " + position);

            }
            else if (option == 3)
            {
                Console.WriteLine("Snake");
                position -= Dice;
                Console.WriteLine("Player at position " + position);

            }
        }
    }
}    
    
