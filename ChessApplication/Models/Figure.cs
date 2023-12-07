namespace ChessApplication.Models;

public interface IFigure
{   
    public void Attack();
    public void Move();
    public  bool CanMoveToPosition(int[] newPosition, int[] coordinates);   
}
