using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Castle : ChessFigure
    {
        public Castle(Coordinates startPosition, bool color) : base(startPosition, color)
        { }

      
        public override bool Move(char x, char y)
        {
            bool result;

            int X = x - 'a';
            int Y = y - '1';

            result = (ChessCoordinates.Y == Y) || (ChessCoordinates.X == X);
            if (result)
                ChessCoordinates = new Coordinates(x, y);
            else
                Console.WriteLine("Error");
            return result;
        }
    }
}
