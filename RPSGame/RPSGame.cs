namespace RPSGame
{
    public class RPSGame
    {
        private static int pCount = 0;
        private static int aiCount = 0;

        public static void StartGame()
        {
            pCount = 0;
            aiCount = 0;

            while (true)
            {
                if (pCount == 3 || aiCount == 3)
                {
                    break;
                }
                string playerChoice = Player.Pchoice();
                string aiChoice = Aichoice();
                Console.Clear();
                Console.WriteLine($"You chose: {playerChoice}, AI chose: {aiChoice}");

                string result = Scoring(playerChoice, aiChoice);
                if (result == "Player")
                {
                    pCount++;
                    Console.WriteLine("You win this round!");
                }
                else if (result == "AI")
                {
                    aiCount++;
                    Console.WriteLine("AI wins this round!");
                }
                else
                {
                    Console.WriteLine("This round is a tie!");
                }
                Console.WriteLine($"Score: Player {pCount} - AI {aiCount}");
            }

            Console.WriteLine("Game over!");
            if (pCount == 3)
            {
                Console.WriteLine("Congratulations! You won the game!");
            }
            else
            {
                Console.WriteLine("AI won the game! Better luck next time.");
            }
        }

        public static string Aichoice()
        {
            Random rng = new Random();
            int Ai = rng.Next(1, 4);
            switch (Ai)
            {
                case 1:
                    return "Paper";
                case 2:
                    return "Rock";
                case 3:
                    return "Scissors";
                default:
                    return "Invalid";
            }
        }

        public static string Scoring(string playerChoice, string aiChoice)
        {
            if (playerChoice == aiChoice)
            {
                return "Tie";
            }

            if ((playerChoice == "Paper" && aiChoice == "Rock") ||
                (playerChoice == "Rock" && aiChoice == "Scissors") ||
                (playerChoice == "Scissors" && aiChoice == "Paper"))
            {
                return "Player";
            }

            return "AI";
        }
        public static int PlayerCount { get { return pCount; } }
        public static int AICount { get { return aiCount; } }
    }
}
