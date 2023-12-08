using ChessLibrary.Figures;
using System.Net.Http.Headers;

namespace ChessLibrary.Chess;


public class ChessBoard
{
    public string[,] board = new string[8, 8];

    public ChessBoard(string[,] size)
    {
        board = size;
    }

    public string[,] PlaceFigure(string Coordinate, string Figure, string Color)
    {
        int.TryParse(Coordinate.Substring(1), out int row);
        int column = Coordinate[0] - 'A';
        switch (Figure)
        {
            case "King":
                King king = new King(Color);
                Figure = king.GetSymbol();
                break;
            case "Knight":
                Knight knight = new Knight(Color);
                Figure = knight.GetSymbol();
                break;
            case "Rook":
                Rook rook = new Rook(Color);
                Figure = rook.GetSymbol();
                break;
            case "Queen":
                Queen queen = new Queen(Color);
                Figure = queen.GetSymbol();
                break;
            case "Bishop":
                Bishop bishop = new Bishop(Color);
                Figure = bishop.GetSymbol();
                break;
            case "Pawn":
                Pawn pawn = new Pawn(Color);
                Figure = pawn.GetSymbol();
                break;
        }
        board[row - 1, column] = Figure;
        return board;
    }

    public void RemoveFigure(string Coordinate)
    {
        int.TryParse(Coordinate.Substring(1), out int row);
        int column = Coordinate[0] - 'A';

        board[row - 1, column] = null;
    }
}


