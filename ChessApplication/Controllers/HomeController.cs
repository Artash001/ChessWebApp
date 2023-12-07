using ChessApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ChessApplication.Chess;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Common;

namespace ChessApplication.Controllers;

public class HomeController : Controller
{
    private static ChessBoard chessBoard = new ChessBoard(new string[8,8]);

    [HttpPost]
    public IActionResult PlacePiece(string selectedPiece, string selectedCoordinate, string selectedColor)
    {
        ViewBag.Chessboard = chessBoard.PlaceFigure(selectedCoordinate, selectedPiece, selectedColor);
        ViewBag.Pieces = GetPieces();
        ViewBag.Color = GetColor();
        return View("Index");
    }

    public IActionResult Index()
    {
        ViewBag.ChessBoard = chessBoard.board;
        ViewBag.Pieces = GetPieces();
        ViewBag.Color = GetColor();
        return View();
    }

    private SelectList GetPieces()
    {
        string[] pieces = ["King", "Knight", "Rook", "Queen", "Bishop"];
        return new SelectList(pieces);
    }

    private SelectList GetColor()
    {
        string[] color = ["Black", "White"];
        return new SelectList(color);
    }
}
