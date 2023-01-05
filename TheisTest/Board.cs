using System;
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

		public int GetValue()
		{
			return grid[0,1];
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