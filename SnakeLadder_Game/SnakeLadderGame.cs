using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder_Game
{
    public class SnakeLadderGame
    {
        public static void CountNoOfRolls()
        {


            int position = 0;
            int WinningPosition = 100;
            int count = 0;
            while (position <= WinningPosition)
            {

                Random random = new Random();
                int Dice = random.Next(1, 7);

                Console.WriteLine("Rolls the dice : " + Dice);

                int option = random.Next(3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        position += Dice;
                        Console.WriteLine("Current Position is ==>" + position);

                        if (position > 100)
                        {
                            position = position - Dice;
                            Console.WriteLine("Current Position is ==>" + position);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        position -= Dice;
                        Console.WriteLine("Current Position is ==>" + position);

                        if (position < 0)
                        {
                            position = 0;
                            Console.WriteLine("Current Position is ==>" + position);
                        }
                        break;
                    default:
                        Console.WriteLine("Not Correct");
                        break;
                }
                        position = position + Dice;
                        Console.WriteLine("Player at position " + position);

                        if (position == WinningPosition)
                        {
                            Console.WriteLine("<========= Player wins ============>");
                            break;
                        }
                else if (position < 0)
                {
                    position = 0;
                    Console.WriteLine("Current Position is ==>" + position);
                }



                count++;



            }
            Console.WriteLine("No of dice rolls" + count);

        }
    }
}

       
    
