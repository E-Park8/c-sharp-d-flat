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
                            Console.WriteLine("Computer shoots Rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player Wins");
                                playerScore++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Computer Wins");
                                CPUScore++;
                            }
                            break;
                        case 2:
                            inputCPU = "Paper";
                            Console.WriteLine("Computer shoots Paper");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Computer Wins");
                                CPUScore++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Player Wins");
                                playerScore++;
                            }
                            break;
                        case 3:
                            inputCPU = "Scissors";
                            Console.WriteLine("Computer shoots Scissors");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Player Wins");
                                playerScore++;
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Computer Wins");
                                CPUScore++;
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Draw");
                            }
                            break;
                        default:
                            break;
                    }

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