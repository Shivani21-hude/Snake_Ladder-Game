using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder_Game
{
    public class SnakeLadderGame
    {
        public static void UC6Countrolls()
        {

            int position = 0;
            int WinningPosition = 100;
            int count = 0;
            while (position <= WinningPosition)
            {

                Random random = new Random();
                int Dice = random.Next(0, 7);


                Console.WriteLine("Rolls the dice : " + Dice);

                if (Dice == 0)
                {
                    Console.WriteLine("No play ");

                }
                else if (Dice == 5)
                {
                    Console.WriteLine("Ladder");
                    position += Dice;
                    Console.WriteLine("Player at positon " + position);

                }
                else if (Dice == 3)
                {
                    Console.WriteLine("Snake");
                    position -= Dice;
                    Console.WriteLine("Player at position " + position);

                    if (Dice < 0)
                    {
                        position = 0;
                        Console.WriteLine("Current position is :  " + position);
                    }

                }

                position = position + Dice;
                Console.WriteLine("Player at position " + position);

                if (position == WinningPosition)
                {
                    Console.WriteLine("Player wins");
                    break;
                }
                else if (position > WinningPosition)
                {
                    Console.WriteLine("Player position is greater than winning position");
                    position = position - Dice;

                }
                count++;

            }

            Console.WriteLine("No of dice rolls" + count);

        }

    }
} 

       
    
