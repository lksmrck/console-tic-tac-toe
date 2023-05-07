using System;
namespace TicTacToe
{
	public class Player
	{
		public char C { get; private set; }

		public Player(char c)
		{
			C = c;
		}

		public void GetPlayerMove(out int col, out int row)
		{
			Console.WriteLine($"Player {C} move:");
			var playerInput = Console.ReadLine();
			var playerInputSplit = playerInput.Split(" ");

			 col = int.Parse(playerInputSplit[0]) - 1;
             row = int.Parse(playerInputSplit[1]) - 1;
		}

	}
}

