namespace ChessApplication.Models;



    public class Knight : IFigure
    {
        private char figureSymbol = 'H';
        public ConsoleColor color{get; set;}

        public Knight(ConsoleColor color)
        {
            this.color = color;
        }

        public  char GetSymbol()
        {
            return figureSymbol;
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

        // public int MinStepsRecursive(int[] currentPosition, int[] destination)
        // {
        //     int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
        //     int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

        //     if (currentPosition[0] == destination[0] && currentPosition[1] == destination[1])
        //     {
        //         // Destination reached, return 0 steps.
        //         return 0;
        //     }

        //     int minSteps = int.MaxValue;

        //     // Explore all possible moves from the current position.
        //     for (int move = 0; move < 8; move++)
        //     {
        //         int newRow = currentPosition[0] + dx[move];
        //         int newCol = currentPosition[1] + dy[move];

        //         if (newRow >= 0 && newCol >= 0)
        //         {
        //             int steps = MinStepsRecursive(new int[] { newRow, newCol }, destination);

        //             if (steps != int.MaxValue)
        //             {
        //                 // If a valid path is found, update minSteps.
        //                 minSteps = Math.Min(minSteps, steps + 1);
        //             }
        //         }
        //     }
        //     return minSteps;
        // }

        public  void Attack() { }
        public  void Move() { }    
    }


