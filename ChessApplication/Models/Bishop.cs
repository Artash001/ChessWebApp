namespace ChessApplication.Models;



    public class Bishop : IFigure
    {
        private char figureSymbol = 'B';
        public ConsoleColor color{get; set;}

        public Bishop(ConsoleColor color)
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
    
            return dx == dy;
        }

        public  void Attack() { }
        public  void Move() { }
    }

