using System;

namespace Chess
{
    class Elephant : ChessFigure
    {
        public Elephant(Coordinates startPosition, bool color) : base(startPosition, color)
        {
        }

        public override bool Move(char x, char y)
        {
            bool result;
            int X = x - 'a';
            int Y = y - '1';

            result = Math.Abs(X - ChessCoordinates.X) == Math.Abs(Y - ChessCoordinates.Y) ;

            if (result)
                ChessCoordinates = new Coordinates(X, Y);
            else
                Console.WriteLine("Error");

            return result;
        }
    }
}
