namespace dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to my random number generato- I mean my super fun dice game!");
            waitForInput("> press enter to continue");

            int playerOneRollResult = -1;
            int playerTwoRollResult = -1;

            Random rnd = new Random();

            Console.Write("");
            playerOneRoll();

            void playerOneRoll()
            {
                playerOneRollResult = rnd.Next(1, 7);
                Console.WriteLine($"your result is {playerOneRollResult}");
                waitForInput("> ready player two");
            }

            Console.Write("");
            playerTwoRoll();

            void playerTwoRoll()    
            {
                playerTwoRollResult = rnd.Next(1, 7);
                Console.WriteLine($"your result is {playerTwoRollResult}");
                waitForInput("> show the result!");
            }

            if (playerOneRollResult > playerTwoRollResult)
            {
                Console.WriteLine("player one won!");
            }
            else if (playerOneRollResult < playerTwoRollResult)
            {
                Console.WriteLine("player two won!");
            }
            else if (playerOneRollResult == playerTwoRollResult)
            {
                Console.WriteLine("try again...");
            }

            void waitForInput(string message)
            {
                Console.WriteLine(message);
                Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}