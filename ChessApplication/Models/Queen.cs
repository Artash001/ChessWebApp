namespace ChessApplication.Models;



    public class Queen : IFigure
    {
        private char figureSymbol = 'Q';
        public ConsoleColor color{get; set;}

        public Queen(ConsoleColor color)
            {
                this.color = color;

            }
                   
        public  char GetSymbol()
        {
            return figureSymbol;
        }

        public  void Attack() { }
        public  void Move() { }
        public  bool CanMoveToPosition(int[] newPosition, int[] coordinates) {return true;}

    }

