using TheisTest;

internal class Program
{
    private static void Main(string[] args)
    {
        // test();
        Game game = new Game();
        game.start();


        void test() {
            Board board = new();
            board.Clear();

            Console.WriteLine(board);
            board.AddToSlot(1, 1);
            board.AddToSlot(1, 2);
            Console.WriteLine(board);
            Console.WriteLine(board.CheckVictory(4, 1));
            board.AddToSlot(1, 3);
            Console.WriteLine(board);
            Console.WriteLine(board.CheckVictory(4, 1));
            board.AddToSlot(1, 4);
            Console.WriteLine(board);
            Console.WriteLine(board.CheckVictory(4, 1));

        }

        // Console.ForegroundColor = ConsoleColor.DarkRed 
    }
}