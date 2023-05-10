using System;
namespace TicTacToe
{
	public class WinChecker
	{
		public static int Check(Field field)
		{
           // Diagonals

            if (field.PlayingField[0][0] != ' '
                && field.PlayingField[0][0] == field.PlayingField[1][1]
                && field.PlayingField[0][0] == field.PlayingField[2][2])
                return field.PlayingField[0][0] == 'X' ? 0 : 1;

            if (field.PlayingField[0][2] != ' '
                && field.PlayingField[0][2] == field.PlayingField[1][1]
                && field.PlayingField[0][2] == field.PlayingField[2][0])
                return field.PlayingField[0][2] == 'X' ? 0 : 1;

            // ROWS
            if (field.PlayingField[0][0] != ' '
                && field.PlayingField[0][0] == field.PlayingField[0][1]
                && field.PlayingField[0][0] == field.PlayingField[0][2])
                return field.PlayingField[0][0] == 'X' ? 0 : 1;

            if (field.PlayingField[1][0] != ' '
                && field.PlayingField[1][0] == field.PlayingField[1][1]
                && field.PlayingField[1][0] == field.PlayingField[1][2])
                return field.PlayingField[1][0] == 'X' ? 0 : 1;

            if (field.PlayingField[2][0] != ' '
                && field.PlayingField[2][0] == field.PlayingField[2][1]
                && field.PlayingField[2][0] == field.PlayingField[2][2])
                return field.PlayingField[2][0] == 'X' ? 0 : 1;

            // COLUMNS
            if (field.PlayingField[0][0] != ' '
                && field.PlayingField[0][0] == field.PlayingField[1][0]
                && field.PlayingField[0][0] == field.PlayingField[2][0])
                return field.PlayingField[0][0] == 'X' ? 0 : 1;

            if (field.PlayingField[0][1] != ' '
                && field.PlayingField[0][1] == field.PlayingField[1][1]
                && field.PlayingField[0][1] == field.PlayingField[2][1])
                return field.PlayingField[0][1] == 'X' ? 0 : 1;

            if (field.PlayingField[0][2] != ' '
                && field.PlayingField[0][2] == field.PlayingField[1][2]
                && field.PlayingField[0][2] == field.PlayingField[2][2])
                return field.PlayingField[0][2] == 'X' ? 0 : 1;

            return -1;
        }
	}
}

