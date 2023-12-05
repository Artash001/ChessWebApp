using ChessApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ChessApplication.Chess;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Common;

namespace ChessApplication.Controllers;

public class HomeController : Controller
{
    private static string[,] chessboard = new string[8, 8];

    [HttpPost]
    public IActionResult PlacePiece(string selectedPiece,string selectedCoordinate, string selectedColor)
    {
        int.TryParse(selectedCoordinate.Substring(1), out int row);
        int column = selectedCoordinate[0] - 'A';
        chessboard[row - 1, column] = selectedPiece;
        ViewBag.Chessboard = chessboard;
        ViewBag.Pieces = GetPieces();
        ViewBag.Color = selectedColor;
        return View("Index");
    }

    public IActionResult Index()
    {
        ViewBag.ChessBoard = chessboard;
        ViewBag.Pieces = GetPieces();
        return View();
    }

    private SelectList GetPieces()
    {
        string[] pieces = new string[] { "King", "Knight", "Rook", "Queen", "Bishop" };
        return new SelectList(pieces);
    }
}
