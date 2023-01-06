using System.Drawing;
using System.Numerics;

namespace TheisTest

{
    public class Board
    {
        int width = 7;
        int height = 6;
        int[,] grid;


        public Board()
        {
            // empty = 0, player1 = 1, player2 = 2
            grid = new int[height, width];
            FillWithNumber(1);
        }

        
        public void FillWithNumber(int value)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    grid[i, j] = value;
                }
            }
        }

        public void Clear()
        {
            Array.Clear(grid, 0, grid.Length);
        }


        public int CheckXInARow(int x, int playerId)
        {

            Point[] directionVectors = new Point[]
            {
                new Point(0, -1), // up
                new Point(1, -1), // right-up
                new Point(1, 0), // right
                new Point(1, 1), // right-down
                new Point(0, 1), // down
                new Point(-1, 1), // down left
                new Point(-1, 0), // left
                new Point(-1, -1), // left up
            };
            
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    int basevalue = grid[row, col];
                    if (basevalue == 0 || basevalue != playerId) continue;

                    foreach (Point vector in directionVectors)
                    {
                        int noInARow = 1;
                        for (int i = 1; i < x; i++) // chceking x away from basevalue
                        {
                            
                            int dx = col + vector.X * i;
                            int dy = row + vector.Y * i;
                            if (dx < 0 || dy < 0 || dx == width || dy == height) break; // outside grid
                            int checkValue = grid[dy, dx];
                            if (checkValue != basevalue) break; // wrong value
                    
                           
                                noInARow++;
                                //Console.WriteLine($"now {noInARow} IN A ROW");
                           
                            

                            if (noInARow == x)
                            {
                                return 5;
                            }
                        }
                    }
                }
            }

            return 3;
        }

        public void AddToSlot(int playerNumber, int col) {

            // initial value = empty column
            int index = height - 1;

            // finding correct index
            for (int row = 0; row < height; row++)
            {
                if (grid[row, col] != 0)
                {
                    index = row - 1;
                    break;
                }
            }

            // if found index less than zero, col is full
            if (index < 0) return;
            
            grid[index, col] = playerNumber;
        }

        public override string ToString()
        {
			string playingBoard = "";
            playingBoard += GetGritString();
            playingBoard += GetColNumberString();
            return playingBoard;
        }

		private string GetGritString()
		{
			string gritString = "";

            for (int row = 0; row < height; row++)
            {
                gritString += " | ";

                for (int col = 0; col < width; col++)
                {
                    if (grid[row, col] != 0)
                    {
                        gritString += $"{grid[row, col]} | ";
                    }
                    else
                    {
                        gritString += "  | ";
                    }

                }

                gritString += "\n";
            }

            return gritString;
		}

        private string GetColNumberString() {
            // drawing seperator
            string colNumberString = " ";
            for (int col = 0; col < width; col++)
            {
                colNumberString += "====";
            }
            colNumberString += "=\n";

            // drawing col numbers
            colNumberString += " ";
            for (int col = 0; col < width; col++)
            {
                colNumberString += $"  {col + 1} ";
            }

            return colNumberString;
        }
    }
}