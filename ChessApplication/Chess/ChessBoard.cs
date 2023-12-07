using ChessApplication.Models;
using System.Net.Http.Headers;

namespace ChessApplication.Chess;


public class ChessBoard
{
    public string[,] board = new string[8, 8];

    public ChessBoard(string[,] size)
    {
        board = size;
    }

    public string[,] PlaceFigure(string Coordinate,  string Figure, string Color)
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
        }
        board[row - 1, column] = Figure;
        return board;

        //Cher kareli sa anel aranc string veradarcnelu ?
        //Kveradardzni object
        //GetSymbol funciayi kariq cher lini

    }
}
    

