using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSUserStory
{
    class Game
    {
        public string endgame;
        public List<string> rules;
        Player playerOne;
        private int score;
        Player playerTwo;

        // another player object (p2)


        public Game ()
        {
            rules = new List<string>();
            rules.Add("Rock crushes Scissors");
            rules.Add("Scissors cuts Paper");
            rules.Add("Paper covers Rock");
            rules.Add("Rock crushes Lizard");
            rules.Add("Lizard poisons Spock");
            rules.Add("Spock smashes Scissors");
            rules.Add("Scissors decapitates Lizard");
            rules.Add("Lizard eats Paper");
            rules.Add("Paper disproves Spock");
            rules.Add("Spock vaporizes Rock");

             playerOne = new human();

            //endgame = (score > 2 ); 
        }

        public void RunGame()
        {
            DisplayRules();
            PlayerSelection();
            Console.WriteLine(playerOne.gesture);
            playerOne.PlayerGesture();
            Console.WriteLine(playerTwo.gesture);
            playerTwo.PlayerGesture();


        }


        public void PlayerGesture()
        {
            switch (playerOne.gesture)
            {
                case "Rock":
                    if (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Lizard")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();

                    }
                    else if (playerTwo.gesture == "Spock" || playerTwo.gesture == "Paper")
                    {
                        Console.WriteLine("playerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "Rock")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "Scissors":
                    if (playerTwo.gesture == "Paper" || playerTwo.gesture == "Lizard")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "Rock" || playerTwo.gesture == "Spock")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "Scissors")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "Lizard":
                    if (playerTwo.gesture == "Spock" || playerTwo.gesture == "Paper")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Rock")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "Lizard")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "Spock":
                    if (playerTwo.gesture == "Rock" || playerTwo.gesture == "Scissors")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "Paper" || playerTwo.gesture == "Lizard")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "Spock")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "Paper":
                    if (playerTwo.gesture == "Rock" || playerTwo.gesture == "Spock")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }

                    else if (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Lizard")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if ( playerTwo.gesture == "Paper")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a corresponding answer :)");
                    Console.ReadLine();
                    break;
            }
        }
        public void PlayerSelection()
        {
            Console.WriteLine("How would you like to play? [PvP] [PvC]");
            string selection = Console.ReadLine();
            if (selection == "PvP")
            {
                playerTwo = new human();    
            }
            else if (selection == "PvC")
            {
                playerTwo = new computer();
            }    
        }
        



        public List<string> DisplayRules()
        {
            return rules;


        }





    }

}
