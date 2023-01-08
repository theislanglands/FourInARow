using System;
namespace TheisTest
{
	public class Game
	{
		private int round;
		bool finished;
        Board board;
        string ?input="";
        int playerTurn;

		public Game()
		{
            finished = false;
            board = new Board();
        }

        public void start()
        {
            // game loop
            Console.WriteLine(board);

            while (finished == false)
            {
                round++;
                playerTurn = ((round-1) % 2) + 1;

                
                Console.WriteLine($"player {playerTurn} choose your slot");
                input = Console.ReadLine();
                board.AddToSlot(playerTurn, Int32.Parse(input)-1);
                Console.Clear();
                Console.WriteLine(board);

                if (board.CheckVictory(4, playerTurn))
                {     
                    Console.WriteLine($"Player {playerTurn} has won");
                    finished = true;
                }

                if (!board.hasAvailableSlots())
                {
                    Console.WriteLine("DRAW - no more available slots");
                    finished = true;
                }
            }
            
        }
    }
}

