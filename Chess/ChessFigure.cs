using System;

namespace Chess
{
    abstract class ChessFigure
    {

        /// <summary>
        /// true- white; false- black
        /// </summary>
        public bool Color { get; }

        private Coordinates _chessCoordinates;
        protected Coordinates ChessCoordinates
        {
            get
            {
                return _chessCoordinates;
            }
            set
            {
                _chessCoordinates = value;
            }
        }

        public ChessFigure(Coordinates startPosition, bool color)
        {
            ChessCoordinates = startPosition;
            Color = color;
        }

        public virtual bool Move(char x, char y)
        {
            return true;
        }

        private string GetBoardCoordinates()
        {
            string result = string.Format("{0}{1}", (char)(_chessCoordinates.X + 'a'), (char)(_chessCoordinates.Y + '1'));
            return result;
        }

        public bool CheckCurrentPosition(string currentPosition)
        {
            if (currentPosition.ToUpper() == GetBoardCoordinates().ToUpper())
                return true;
            return false;
        }
    }
}
