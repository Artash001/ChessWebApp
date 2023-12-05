using ChessApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ChessApplication.Chess;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ChessApplication.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        ChessBoard chessBoard = new ChessBoard();
        ViewBag.Chessboard = chessBoard;
        ViewBag.Pieces = GetPieces();
        return View();
    }

    private SelectList GetPieces()
    {
        string[] pieces = new string[] { "King", "Knight", "Rook", "Queen", "Bishop" };
        return new SelectList(pieces);
    }
}
