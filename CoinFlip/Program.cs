﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();


            Console.Write("Enter your guess Head or Tail (H or T)");
            userGuess = Console.ReadLine();

            coin = rng.Next(0, 2);

            if (coin == 0 && userGuess == "T")
            {
                Console.WriteLine("The coin Flip was Tails you win");

            }
            else if (coin == 1 && userGuess == "H")
            {
                Console.WriteLine("The coin flip was Heads, you win");

            }

            else
            {
                if (coin == 0)
                {

                    Console.WriteLine("The coin flip was Tails, you lose");

                }

                else
                {
                    Console.WriteLine("The coin flip was Heads, you lose");
                }


            }
            Console.ReadLine();

        }

    }

}
