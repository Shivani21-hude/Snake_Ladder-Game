﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder_Game
{
    public class SnakeLadderGame
    {
        public static void U54WinningPosition()
        {
                int position = 0;
                int WinningPosition = 100;

                while (position <= WinningPosition)
                {

                    Random random = new Random();
                    int Dice = random.Next(1, 7);

                    Console.WriteLine("Rolls the dice : " + Dice);

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
                    else if (option == 2)
                    {
                        Console.WriteLine("Snake");
                        position -= Dice;
                        Console.WriteLine("Player at position " + position);

                        if (option < 0)
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

                }
            
        }

    }
} 

       
    
