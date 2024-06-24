using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    public class Player
    {
        public static string Pchoice()
        {
            while (true)
            {
                Console.WriteLine("Choose your Move:\n1:Paper\n2:Rock\n3:Sissors");
                string player = Console.ReadLine();

                switch (player)
                {
                    case "1":
                        return "Paper";
                    case "2":
                        return "Rock";
                    case "3":
                        return "Sissors";
                    default:
                        Console.WriteLine("Invalid option.");
                        continue;
                }
            }
        }
    }
}
