namespace ChessApplication.Models;



    public class Rook : IFigure
    {
        private char figureSymbol = 'R';
        public ConsoleColor color{get; set;}

        public Rook(ConsoleColor color)
        {
            this.color = color;        
        }

        public  char GetSymbol()
        {
            return figureSymbol;
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

