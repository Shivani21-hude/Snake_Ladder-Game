using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder_Game
{
    public class SnakeLadderGame
    {
       public static void PlayingTwoPlayers()
            {


                int WinningPosition = 100;
                int count = 0;
                int Player1 = 0, Player2 = 0;


                while (Player1 <= WinningPosition && Player2 <= WinningPosition)
                {

                    Console.WriteLine(" Player 1 => \n");

                    Random random1 = new Random();
                    int Dice1 = random1.Next(1, 7);


                    Console.WriteLine("Player 1 Rolls the dice : " + Dice1);
                    int option1 = random1.Next(3);
                    count++;
                    if (Player1 == WinningPosition)
                    {
                        Console.WriteLine("<=============== Player 1 wins ==================>\n");
                        break;

                    }
                    switch (option1)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;
                        case 1:
                            Console.WriteLine("Ladder");
                            Player1 += Dice1;
                            Console.WriteLine("Current Position is ==>" + Player1);

                            if (Player1 > 100)
                            {
                                Player1 = Player1 - Dice1;
                                Console.WriteLine("Current Position is ==>" + Player1);
                            }

                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            Player1 -= Dice1;
                            Console.WriteLine("Current Position is ==>" + Player1);

                            if (Player1 < 0)
                            {
                                Player1 = 0;
                                Console.WriteLine("Current Position is ==>" + Player1);
                            }
                            break;
                        default:
                            Console.WriteLine("Not Correct");
                            break;

                    }

                    Console.WriteLine("..................................................");

                    Console.WriteLine(" Player 2.=> \n");

                    Random random = new Random();
                    int Dice = random.Next(1, 7);


                    Console.WriteLine("Player 2 Rolls the dice : " + Dice);
                    int option = random.Next(3);
                    if (Player2 == WinningPosition)
                    {
                        Console.WriteLine("<============== Player 2 wins ==============>\n");
                        break;
                    }
                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;
                        case 1:
                            Console.WriteLine("Ladder");
                            Player2 += Dice;
                            Console.WriteLine("Current Position is ==>" + Player2);

                            if (Player2 > 100)
                            {
                                Player2 = Player2 - Dice;
                                Console.WriteLine("Current Position is ==>" + Player2);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            Player2 -= Dice;
                            Console.WriteLine("Current Position is ==>" + Player2);

                            if (Player2 < 0)
                            {
                                Player2 = 0;
                                Console.WriteLine("Current Position is ==>" + Player2);
                            }
                            break;
                        default:
                            Console.WriteLine("Not Correct");
                            break;

                    }
                    Console.WriteLine("..................................................");

                }

                if (Player1 == WinningPosition)
                    Console.WriteLine("***Player 1 Won The Game***");
                else
                    Console.WriteLine("***Player 2 Won The Game***");


                Console.WriteLine("Players rolls dices  \n  " + count + "times");
            
        }
    }
}

       
    
