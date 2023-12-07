namespace ChessApplication.Models;



public class Knight : IFigure
{
        public string color{get; set;}

        public Knight(string Color)
        {
            color = Color;
        }

        public string GetSymbol()
        {
            if (color == "White")
            {
                return "♘";
            }
            else
                return "♞";
        }
         
        public  bool CanMoveToPosition(int[] newPosition, int[] coordinates)
        {
            int dx = Math.Abs(newPosition[0] - coordinates[0]);
            int dy = Math.Abs(newPosition[1] - coordinates[1]);
            return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
        }

        public int MinimalStepsForKnight(int[] destination, int[] currentPosition)
        {
            int dx = Math.Abs(destination[0] - currentPosition[0]);
            int dy = Math.Abs(destination[1] - currentPosition[1]);
            if((dx == 1 && dy == 0) || (dx == 0 && dy == 1))
            {
                return 3;
            }
            else if((dx == 1 && dy == 1) || (dx == 2 && dy == 0) || (dx == 0 && dy == 2))
            {
                return 2;
            }
            else if((dx == 2 && dy == 1) || (dx == 1 && dy == 2))
            {
                return 1;
            }
            else if(dx == 2 && dy == 2)
            {
                return 4;
            }
            return 0;
        }

        public  void Attack() { }
        public  void Move() { }    
}


