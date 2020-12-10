using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand hotel and Casino";
            Console.WriteLine("Welcome to the {0}! What is your name?", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, would you like to play a game of Black Jack right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Documents\Bootcamp\Tech Academy\Basic_C#_Programs\BlackJackLogs\log.txt", true))//true is for 'append'
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            

            Console.ReadKey();
        }
    }
}
