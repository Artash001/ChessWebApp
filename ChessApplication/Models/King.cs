namespace ChessApplication.Models;


    public class King : IFigure
    {
        private char figureSymbol = 'K';
        public ConsoleColor color{get; set;}

        public King(ConsoleColor color)
            {
                this.color = color;
                
            }


        public  char GetSymbol()
        {
            return figureSymbol;
        }

        public  void Attack() { }
        public  void Move() { }
        
        public  bool CanMoveToPosition(int[] newPosition, int[] coordinates)  {return true;}
    }

