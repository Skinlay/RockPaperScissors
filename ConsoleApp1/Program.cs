using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //call Functions
            while (won == false)
            {
                AI();
                user_trun();
                check();
                wins();
            }
            
        }

        public static bool first_round { get; set; } = true;
        public static string user_input { get; set; } = "";
        public static string AI_chois { get; set; } = "";
        public static int AI_wins { get; set; } = 0;
        public static int user_wins { get; set; } = 0;
        public static bool won { get; set; } = false;

        static void AI()
        {
            var random = new Random();
            //maakt lijst
            var RPS = new List<string> { "rock", "paper", "scissors" };
            //telt de lengte van de lijst om hier vervolgens een random int terug
            int countRPS = random.Next(RPS.Count);
            //met het eerder rondom getal gaat hij nu kijken in de lijst welke dit is
            AI_chois = RPS[countRPS];
        }
        static void user_trun()
        {
            //anders kan ik Init niet aanroepen
           
            //controleerd of het de eerste ronden is
            if (first_round == true)
            {
                //set de eerste ronden naar Fals zodat deze maar 1 keer word aangeroepen
                first_round = false;
                Console.WriteLine("Hallo welcome to a game of rock paper scissors");
                Console.WriteLine("Choose between rock paper or scissors");
            }
            user_input = Console.ReadLine();
        }

        static void check()
        {
            if (user_input == AI_chois)
            {
                Console.WriteLine("same");
            }

            else if (user_input == "rock")
            {
                if (AI_chois == "paper")
                {
                    //AI wins
                    AI_wins += 1;
                }
                else if (AI_chois == "scissors")
                {
                    //AI lost
                    user_wins += 1;
                }
            }

            else if (user_input == "paper")
            {
                if (AI_chois == "scissors")
                {
                    //AI wins
                    AI_wins += 1;
                }
                else if (AI_chois == "rock")
                {
                    //AI lost
                    user_wins += 1;
                }
            }

            else if (user_input == "scissors")
            {
                if (AI_chois == "rock")
                {
                    //AI wins
                    AI_wins += 1;
                }
                else if (AI_chois == "paper")
                {
                    //AI lost
                    user_wins += 1;
                }
            }
            else
            {
                Console.WriteLine("I said rock paper or scissors not that shit");
            }

            Console.WriteLine("AI wins = " + AI_wins + " user wins = " + user_wins);
            } 

        static void wins()
        {
            if (user_wins == 3)
            {
                Console.WriteLine("user wins");
                won = true;
            }
            else if (AI_wins == 3)
            {
                Console.WriteLine("AI wins");
                won = true;
            }
        }
    }
}

