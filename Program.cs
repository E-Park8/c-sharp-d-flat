using System;

namespace c_sharp_d_flat
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int playerScore = 0;
                int CPUScore = 0;



                while (playerScore < 3 && CPUScore < 3)
                {


                    Console.Write("Choose between Rock, Paper, or Scissors:  ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Rock";
                            Console.WriteLine("\nComputer shoots Rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("\nDraw");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("\nPlayer Wins");
                                playerScore++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("\nComputer Wins");
                                CPUScore++;
                            }
                            break;
                        case 2:
                            inputCPU = "Paper";
                            Console.WriteLine("\nComputer shoots Paper");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("\nComputer Wins");
                                CPUScore++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("\nDraw");
                            }
                            else if (inputPlayer == "\nScissors")
                            {
                                Console.WriteLine("\nPlayer Wins");
                                playerScore++;
                            }
                            break;
                        case 3:
                            inputCPU = "Scissors";
                            Console.WriteLine("\nComputer shoots Scissors");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("\nPlayer Wins");
                                playerScore++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("\nComputer Wins");
                                CPUScore++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("\nDraw");
                            }
                            break;
                        default:
                            Console.WriteLine("\nInvalid entry");
                            break;
                    }
                    Console.WriteLine("\n\nScores: \tPLAYER:\t{0}\tCPU\t{1}", playerScore, CPUScore);

                }
                if (playerScore == 3)
                {
                    Console.WriteLine("Player Won");
                }
                else if (CPUScore == 3)
                {
                    Console.WriteLine("Computer Won");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play again?(yes/no)");
                string loop = Console.ReadLine();
                if (loop == "yes")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "no")
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