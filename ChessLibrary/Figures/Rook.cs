namespace ChessLibrary.Figures;



public class Rook : IFigure
{
        public string color{get; set;}

        public Rook(string Color)
        {
            color = Color;        
        }

        public string GetSymbol()
        {
            if (color == "White")
            {
                return "♖";
            }
            else
                return "♜";
        }

        public bool CanMoveToPosition(int[] newPosition, int[] coordinates)
        {
            int dx = Math.Abs(newPosition[0] - coordinates[0]);
            int dy = Math.Abs(newPosition[1] - coordinates[1]);
    
            return (dx == 0 && dy > 0) || (dx > 0 && dy == 0);
        }

        public  void Attack() { }
        public  void Move() { }
}

