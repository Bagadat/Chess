using System;
using System.Collections.Generic;

namespace Chess
{ 
    class Game
    {
        
        private Gamer _currentPlayer;

        private Gamer _blackPlayer;
        private Gamer _whitePlayer;

        public static void Main(string[] param)
        {
            
        }

        public Game()
        {
        }

        public void PassStepTo(bool color)
        {
            

            if (color)
                _currentPlayer = _whitePlayer;
            else
                _currentPlayer = _blackPlayer;

            _currentPlayer.Step();
            
            
        }


        private void SetFigureStartPosition(ChessFigure figure, bool color)
        {
            if (figure is Elephant)
            {
                Elephant elephantc1 = new Elephant(new Coordinates('c', 1), true);
                Elephant elephantf1 = new Elephant(new Coordinates('f', 1), true);
                Elephant elephantc8 = new Elephant(new Coordinates('c', 8), false);
                Elephant elephantf8 = new Elephant(new Coordinates('f', 1), false);
            }
            else if (figure is Castle)
            {
                Castle castlea1 = new Castle(new Coordinates('a', 1), true);
                Castle castleh1 = new Castle(new Coordinates('h', 1), true);
                Castle castlea8 = new Castle(new Coordinates('a', 8), false);
                Castle castleh8 = new Castle(new Coordinates('h', 8), false);
            }
            else if (figure is Horse)
            {
                Horse horseb1 = new Horse(new Coordinates('b', 1), true);
                Horse horseg1 = new Horse(new Coordinates('g', 1), true);
                Horse horseb8 = new Horse(new Coordinates('b', 8), false);
                Horse horseg8 = new Horse(new Coordinates('g', 8), false);

                
            }
            else if (figure is King)
            {
                King kinge1 = new King(new Coordinates('e', 1), true);
                King kinge8 = new King(new Coordinates('e', 8), false);
            }
            else if (figure is Queen)
            {
                Queen queend1 = new Queen(new Coordinates('d', 1), true);
                Queen queend8 = new Queen(new Coordinates('d', 8), false);
            }
            else if (figure is Pawn)
            {
                Pawn pawna2 = new Pawn(new Coordinates('a', 2), true);
                Pawn pawnb2 = new Pawn(new Coordinates('b', 2), true);
                Pawn pawnc2 = new Pawn(new Coordinates('c', 2), true);
                Pawn pawnd2 = new Pawn(new Coordinates('d', 2), true);
                Pawn pawne2 = new Pawn(new Coordinates('e', 2), true);
                Pawn pawnf2 = new Pawn(new Coordinates('f', 2), true);
                Pawn pawng2 = new Pawn(new Coordinates('g', 2), true);
                Pawn pawnh2 = new Pawn(new Coordinates('h', 2), true);
                Pawn pawna7 = new Pawn(new Coordinates('a', 7), false);
                Pawn pawnb7 = new Pawn(new Coordinates('b', 7), false);
                Pawn pawnc7 = new Pawn(new Coordinates('c', 7), false);
                Pawn pawnd7 = new Pawn(new Coordinates('d', 7), false);
                Pawn pawne7 = new Pawn(new Coordinates('e', 7), false);
                Pawn pawnf7 = new Pawn(new Coordinates('f', 7), false);
                Pawn pawng7 = new Pawn(new Coordinates('g', 7), false);
                Pawn pawnh7 = new Pawn(new Coordinates('h', 7), false);
            }
        }
    }
}
