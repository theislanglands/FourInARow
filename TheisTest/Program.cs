using TheisTest;

internal class Program
{
    private static void Main(string[] args)
    {
        Board board = new();
        board.Clear();
        Console.WriteLine(board);
        board.addToSlot(1, 1);
        board.addToSlot(1, 1);
        Console.WriteLine(board);
        board.addToSlot(1, 1);
        board.addToSlot(1, 1);
        Console.WriteLine(board);
        board.addToSlot(1, 1);
        Console.WriteLine(board);
        board.addToSlot(1, 1);
        Console.WriteLine(board);
    }
}