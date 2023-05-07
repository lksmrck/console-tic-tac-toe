

// See https://aka.ms/new-console-template for more information

using TicTacToe;

Player player1 = new Player('X');
Player player2 = new Player('O');

Field field = new Field(3);

int player = 0;


field.PrintField();

while (true)
{
Player currentPlayer = player == 0 ? player1 : player2;

int row, col;

currentPlayer.GetPlayerMove(out col, out row);

field.PlayingField[col][row] = currentPlayer.C;

field.PrintField();

player = player == 0 ? 1 : 0;

}


