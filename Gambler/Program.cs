using System;

namespace Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Problem");
            Gambler gambler = new Gambler();
            gambler.Initials();
            gambler.Bet();
        }
    }
}
