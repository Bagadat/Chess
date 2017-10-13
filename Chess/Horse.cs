using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Horse : ChessFigure
    {
        public Horse(Coordinates startPosition,bool color) : base(startPosition,color)
        {
        }

        public override bool Move(char x, char y)
        {
            bool result;

            int X = x - 'a';
            int Y = y - '1';

            result = ((Math.Abs(X - ChessCoordinates.X) == 2 && Math.Abs(Y - ChessCoordinates.Y) == 1) 
                || (Math.Abs(X - ChessCoordinates.X) == 1 && Math.Abs(Y - ChessCoordinates.Y) == 2));

            if (result)
                ChessCoordinates = new Coordinates(x, y);
            else
                Console.WriteLine("Error");

            return result;
        }
    }
}
