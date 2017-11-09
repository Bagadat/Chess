using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    class Game
    {
        static List<ChessFigure> listFigures = new List<ChessFigure>();
        private static Gamer _currentPlayer;

        private static Gamer _blackPlayer;
        private static Gamer _whitePlayer;

        public static void Main(string[] param)
        {
            InitializeFigures();
            InitializePlayers();
            PassStepTo(true);
            Console.ReadKey();
        }

        public Game()
        {
            
        }

        private static void PassStepTo(bool color)
        {
            if (color)
                _currentPlayer = _whitePlayer;
            else
                _currentPlayer = _blackPlayer;
            Console.WriteLine($"Ходит игрок: {_currentPlayer.Name}");
            _currentPlayer.Step();
        }

        private static void InitializePlayers()
        {
            _whitePlayer = new Gamer("Ilya", listFigures.Where(figure => figure.Color), PassStepTo);
            _blackPlayer = new Gamer("Bagadat", listFigures.Where(figure => !figure.Color), PassStepTo);
        }

        
        private static void InitializeFigures()
        {
            // Почитай про фабрику и попробуй реализовать!!!

          //  ChessFigureFactory creator = new PawnCreator();
           // ChessFigure figure = creator.ChessFigureCreator();
            listFigures = new List<ChessFigure>()
            {
                new Elephant(new Coordinates('c', '1'), true),
                new Elephant(new Coordinates('f', '1'), true),
                new Elephant(new Coordinates('c', '8'), false),
                new Elephant(new Coordinates('f', '8'), false),
                new Castle(new Coordinates('a', '1'), true),
                new Castle(new Coordinates('h', '1'), true),
                new Castle(new Coordinates('a', '8'), false),
                new Castle(new Coordinates('h', '8'), false),
                new Horse(new Coordinates('b', '1'), true),
                new Horse(new Coordinates('g', '1'), true),
                new Horse(new Coordinates('b', '8'), false),
                new Horse(new Coordinates('g', '8'), false),
                new King(new Coordinates('e', '1'), true),
                new King(new Coordinates('e', '8'), false),
                new Queen(new Coordinates('d', '1'), true),
                new Queen(new Coordinates('d', '8'), false),
                new Pawn(new Coordinates('a', '2'), true),
                new Pawn(new Coordinates('b', '2'), true),
                new Pawn(new Coordinates('c', '2'), true),
                new Pawn(new Coordinates('d', '2'), true),
                new Pawn(new Coordinates('e', '2'), true),
                new Pawn(new Coordinates('f', '2'), true),
                new Pawn(new Coordinates('g', '2'), true),
                new Pawn(new Coordinates('h', '2'), true),
                new Pawn(new Coordinates('a', '7'), false),
                new Pawn(new Coordinates('b', '7'), false),
                new Pawn(new Coordinates('c', '7'), false),
                new Pawn(new Coordinates('d', '7'), false),
                new Pawn(new Coordinates('e', '7'), false),
                new Pawn(new Coordinates('f', '7'), false),
                new Pawn(new Coordinates('g', '7'), false),
                new Pawn(new Coordinates('h', '7'), false),
            };
        }

    }

}
