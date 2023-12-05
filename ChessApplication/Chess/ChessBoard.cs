namespace ChessApplication.Chess;


public class ChessBoard
{
    private ChessSquare[,] board;

    public ChessBoard()
    {
        board = new ChessSquare[8, 8];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                ChessSquare square = CreateChessSquare(row, col);
                board[row, col] = square;
            }
        }
    }

    private ChessSquare CreateChessSquare(int row, int col)
    {
        ConsoleColor bgColor = (row + col) % 2 == 0 ? ConsoleColor.Red : ConsoleColor.Gray;
        ConsoleColor fgColor = bgColor == ConsoleColor.White ? ConsoleColor.Black : ConsoleColor.White;
        char piece = ' '; 

        return new ChessSquare(row, col, piece, bgColor, fgColor);
    }

    public void SetFigureAtPosition(char figure, ConsoleColor color, int row, int col)
    {
        if (row < 0 || row >= 8 || col < 0 || col >= 8)
        {
           
        }
        else
        {
            board[8 - row, col - 1].Piece = figure;
            board[8 - row, col - 1].ForegroundColor = color;
        }        
    }

    public void PrintBoard()
        {
            Console.WriteLine("  A B C D E F G H"); 

            for (int row = 0; row < 8; row++)
            {
                Console.Write(8 - row + " "); 

                for (int col = 0; col < 8; col++)
                {
                    Console.BackgroundColor = board[row, col].BackgroundColor;
                    Console.ForegroundColor = board[row, col].ForegroundColor;

                    Console.Write(board[row, col].Piece + " ");
                }

                Console.ResetColor();
                Console.WriteLine(" " + (8 - row)); 
            }
            Console.WriteLine("  A B C D E F G H");
        }   
    }

