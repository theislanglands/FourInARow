// See https://aka.ms/new-console-template for more information
using TheisTest;

internal class Program
{
    private static void Main(string[] args)
    {
        Board board = new();
        Console.WriteLine(board);
        board.Clear();
        Console.WriteLine(board);
    }
}