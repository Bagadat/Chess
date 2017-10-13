using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : ChessFigure
    {
        public Queen(Coordinates startPosition, bool color) : base(startPosition,color)
        {

        }
        public override bool Move(char x, char y)
        {
            bool result;

            int X = x - 'a';
            int Y = y - '1';

            result = Math.Abs(X - ChessCoordinates.X) == Math.Abs(Y - ChessCoordinates.Y)
                || (ChessCoordinates.Y == Y) || (ChessCoordinates.X == X);

            if (result)
                ChessCoordinates = new Coordinates(X, Y);
            else
                Console.WriteLine("Error");

            return result;
        }
    }
}
