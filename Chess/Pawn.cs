﻿using System;

namespace Chess
{
    class Pawn : ChessFigure
    {
        private Coordinates _startPosition { get; set; }

        public override int Weight => 1;

        public Pawn(Coordinates startPosition, bool color) : base(startPosition, color)
        {
            _startPosition = startPosition;
        }

        public override bool Move(char x, char y, bool kick)
        {
            bool result;

            int X = x - 'a';
            int Y = y - '1';

            if (_startPosition == ChessCoordinates)
                result = (Y - ChessCoordinates.Y == 2 || Y - ChessCoordinates.Y == 1);
            else
                result = Y - ChessCoordinates.Y == 1;

            if (result)
                ChessCoordinates = new Coordinates(x, y);
            else
                Console.WriteLine("Error");
            return result;
        }

    }
}
