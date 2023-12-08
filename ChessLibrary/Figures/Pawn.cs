namespace ChessLibrary.Figures;


public class Pawn : IFigure
{
    private string color;

    public Pawn(string Color)
    {
        color = Color;
    }


    public string GetSymbol()
    {
        if (color == "White")
        {
            return "♙";
        }
        else
            return "♟︎";
    }


    public void Attack() { }
    public void Move() { }

    public bool CanMoveToPosition(int[] newPosition, int[] coordinates) { return true; }
}

