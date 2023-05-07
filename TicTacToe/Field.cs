using System;
namespace TicTacToe
{
	public class Field
	{

		public char[][] PlayingField { get; private set; }
		public int FieldResolution { get; private set; }


		// Constructor
		public Field(int fieldResolution)
		{
            PlayingField = CreateField(fieldResolution);
			FieldResolution = fieldResolution;
        }

		// Methods

		public char[][] CreateField(int fieldResolution)
		{

			var field = new char[fieldResolution][];

			for (int i = 0; i < fieldResolution; i++)
			{
				field[i] = new char[fieldResolution];

				for (int j = 0; j < fieldResolution; j++)
				{
					field[i][j] = 'X';
				}

			}

			return field;

		}

		public void PrintField()
		{
			Console.WriteLine(" |1|2|3|");
			for (int i = 0;  i < FieldResolution;  i++)
			{
				Console.Write($"{ i + 1 }|");
				for (int j = 0; j < FieldResolution; j++)
				{
					Console.Write($"{PlayingField[i][j]}|");
				}

				Console.WriteLine();

			}

		}


	}
}

