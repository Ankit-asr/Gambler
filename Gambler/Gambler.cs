using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    class Gambler
    {
        const int TOTAL_STAKE = 100;
        const int BET_EVERYDAY = 1;

        public void Initials()
        {
            Console.WriteLine("Player Total Stake :" + TOTAL_STAKE);
            Console.WriteLine("Player daily bet :" + BET_EVERYDAY);
        }
        public void Bet()
        {
            int Stake = 0;
            Random random = new Random();
            int player = random.Next(0, 2);
            if (player == 0)
            {
                Console.WriteLine("Player Loss game");
                Stake = Stake - 1;
                //Console.WriteLine("Amount after Losing bet "+Stake);
            }
            else
            {
                Console.WriteLine("Player Wins game");
                Stake = Stake + 1;
                //Console.WriteLine("Amount after Winning bet " + Stake);

            }
            Console.WriteLine("Total Stakes remaining with Player:"+(TOTAL_STAKE+Stake));

        }
    }
}
