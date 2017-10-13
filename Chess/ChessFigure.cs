using System;

namespace Chess
{
    abstract class ChessFigure
    {
        protected Coordinates StartPosition { get; }

        /// <summary>
        /// true- white; false- black
        /// </summary>
        protected bool Color { get; }

        private Coordinates _chessCoordinates;
        protected Coordinates ChessCoordinates
        {
            get
            {
                Console.Write((char)(_chessCoordinates.X + 'a'));
                Console.WriteLine((char)(_chessCoordinates.Y + '1'));
                return _chessCoordinates;
            }
            set
            {
                _chessCoordinates = value;
            }
        }

        public ChessFigure(Coordinates startPosition, bool color)
        {
            StartPosition = startPosition;
            Color = color;
        }

        public abstract bool Move(char x, char y);
    }
}
