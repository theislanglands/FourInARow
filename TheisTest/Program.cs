using TheisTest;

internal class Program
{
    private static void Main(string[] args)
    {
        Board board = new();
        board.Clear();
        
        Console.WriteLine(board);
        board.AddToSlot(1, 1);
        board.AddToSlot(1, 1);
        Console.WriteLine(board);
        Console.WriteLine(board.CheckXInARow(4,1));
        board.AddToSlot(1, 1);
        Console.WriteLine(board);
        Console.WriteLine(board.CheckXInARow(4,1));
        board.AddToSlot(1, 1);
        Console.WriteLine(board);
        Console.WriteLine(board.CheckXInARow(4,1));

        // Console.ForegroundColor = ConsoleColor.DarkRed;
      
    }
}