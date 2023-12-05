namespace ChessApplication.Chess;

struct ChessSquare
{
    public int Row { get; }
    public int Col { get; }
    public char Piece { get; set; }
    public ConsoleColor BackgroundColor { get; set; }
    public ConsoleColor ForegroundColor { get; set; }

    public ChessSquare(int row, int col, char piece, ConsoleColor bgColor, ConsoleColor fgColor)
    {
        Row = row;
        Col = col;
        Piece = piece;
        BackgroundColor = bgColor;
        ForegroundColor = fgColor;
    }
}