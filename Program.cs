using System;

namespace c_sharp_d_flat
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int playerScore = 0;
            int CPUScore = 0;

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
    }
}
