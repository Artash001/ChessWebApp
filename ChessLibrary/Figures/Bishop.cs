namespace ChessLibrary.Figures;


public class Bishop : IFigure
{
    private string color;

    public Bishop(string Color)
    {
        color = Color;
    }


    public string GetSymbol()
    {
        if (color == "White")
        {
            return "♗";
        }
        else
            return "♝";
    }


    public void Attack() { }
    public void Move() { }

    public bool CanMoveToPosition(int[] newPosition, int[] coordinates) { return true; }
}

