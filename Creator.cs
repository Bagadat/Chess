using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class ChessFigureFactory
    {
        public abstract ChessFigure ChessFigureCreator(Coordinates position, bool color);
        
    }

    class PawnCreator : ChessFigureFactory
    {
        public PawnCreator() { }
        public override ChessFigure ChessFigureCreator(Coordinates position, bool color)
        {
            return new Pawn(position, color);
        }
    }
    class CastleCreator : ChessFigureFactory
    { 
        public CastleCreator()
        { }
        public override ChessFigure ChessFigureCreator(Coordinates position, bool color)
        {
            return new Castle(position, color);
        }
    }
    class HorseCreator : ChessFigureFactory
{
        public HorseCreator()
        { }
        public override ChessFigure ChessFigureCreator(Coordinates position, bool color)
        {
            return new Horse(position, color);
        }
    }
    class KingCreator : ChessFigureFactory
{
        public KingCreator()
        { }
        public override ChessFigure ChessFigureCreator(Coordinates position, bool color)
        {
            return new King(position, color);
        }
    }
    class ElephantCreator : ChessFigureFactory
{
        public ElephantCreator()
        { }
        public override ChessFigure ChessFigureCreator(Coordinates position, bool color)
        {
            return new Elephant(position, color);
        }
    }
    class QueenCreator : ChessFigureFactory
{
        public QueenCreator()
        { }
        public override ChessFigure ChessFigureCreator(Coordinates position, bool color)
        {
            return new Queen(position,color);
        }
    }
   
}
