using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit22
{
    class Program
    {

        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU = null;
            int randomint;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose ROCK, PAPER or SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                    //random gen to choose from cases below
                    Random rnd = new Random();
                    randomint = rnd.Next(1, 4);

                    switch (randomint)
                    {
                        // these cases allow for the computer to decide what option to choose from when playing the game.
                        // also shows the result of the match that was played between the player and computer.
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer has ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("You drew, better luck next time!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("You Win!! Good game!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Computer Wins!! Good game!!");
                                scoreCPU++;
                            }

                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer has PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("You drew, better luck next time!!\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Computer Wins!! Good game!");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("You Win!! Good game!!");
                                scorePlayer++;
                            }

                            break;

                        case 3:
                            inputCPU = "SCOSSORS";
                            Console.WriteLine("Computer has SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("You drew, better luck next time!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("You Win!! Good game!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Computer Wins!! Good game!!");
                                scoreCPU++;
                            }

                            break;

                        default:
                            Console.WriteLine("invalid entry, choose from the 3 options\n ROCK, PAPER or SCISSORS!");
                            break;
                    }
                        Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine(":::       ::: ::::::::::: ::::    ::: ::::    ::: :::::::::: :::::::::  ");
                    Console.WriteLine(":+:       :+:     :+:     :+:+:   :+: :+:+:   :+: :+:        :+:    :+: ");
                    Console.WriteLine("+:+       +:+     +:+     :+:+:+  +:+ :+:+:+  +:+ +:+        +:+    +:+ ");
                    Console.WriteLine("+#+  +:+  +#+     +#+     +#+ +:+ +#+ +#+ +:+ +#+ +#++:++#   +#++:++#:  ");
                    Console.WriteLine("+#+ +#+#+ +#+     +#+     +#+  +#+#+# +#+  +#+#+# +#+        +#+    +#+ ");
                    Console.WriteLine(" #+#+# #+#+#      #+#     #+#   #+#+# #+#   #+#+# #+#        #+#    #+# ");
                    Console.WriteLine("  ###   ###   ########### ###    #### ###    #### ########## ###    ### ");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine(" ::::::::  :::::::::  :::    :::      :::       :::  ::::::::  ::::    ::: ");
                    Console.WriteLine(":+:    :+: :+:    :+: :+:    :+:      :+:       :+: :+:    :+: :+:+:   :+: ");
                    Console.WriteLine("+:+        +:+    +:+ +:+    +:+      +:+       +:+ +:+    +:+ :+:+:+  +:+ ");
                    Console.WriteLine("+#+        +#++:++#+  +#+    +:+      +#+  +:+  +#+ +#+    +:+ +#+ +:+ +#+ ");
                    Console.WriteLine("+#+        +#+        +#+    +#+      +#+ +#+#+ +#+ +#+    +#+ +#+  +#+#+# ");
                    Console.WriteLine("#+#    #+# #+#        #+#    #+#       #+#+# #+#+#  #+#    #+# #+#   #+#+# ");
                    Console.WriteLine(" ########  ###         ########         ###   ###    ########  ###    #### ");
                }
                else
                {
                    
                }
                Console.WriteLine("Would you like to play again? y/n");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if(loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    
                }
            }
        }
    }
}