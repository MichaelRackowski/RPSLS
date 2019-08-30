﻿using System;
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
        public List<string> gestureoptions;
        Player playerOne;
        private int score;
        Player playerTwo;
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
            Displaygestureoptions();
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
                case "rock":
                    if (playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();

                    }
                    else if (playerTwo.gesture == "spock" || playerTwo.gesture == "paper")
                    {
                        Console.WriteLine("playerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "rock")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "scissors":
                    if (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "scissors")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "lizard":
                    if (playerTwo.gesture == "spock" || playerTwo.gesture == "paper")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "scissors" || playerTwo.gesture == "rock")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "lizard")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "spock":
                    if (playerTwo.gesture == "rock" || playerTwo.gesture == "scissors")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "spock")
                    {
                        Console.WriteLine("PlayerOne and PlayerTwo tied");
                        Console.ReadLine();
                    }
                    break;
                case "paper":
                    if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                    {
                        Console.WriteLine("PlayerOne Wins");
                        Console.ReadLine();
                    }

                    else if (playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                    {
                        Console.WriteLine("PlayerTwo Wins");
                        Console.ReadLine();
                    }
                    else if ( playerTwo.gesture == "paper")
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
            string selection = Console.ReadLine().ToLower();
            if (selection == "pvp")
            {
                playerTwo = new human();    
            }
            else if (selection == "pvc")
            {
                playerTwo = new computer();
            }    
        }
        



        public List<string> DisplayRules()
        {
            return rules;
        }

        public List<string> Displaygestureoptions()
        {
            return gestureoptions;
        }




    }

}
