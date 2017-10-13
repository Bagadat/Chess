using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : ChessFigure
    {
       
        public King(Coordinates stratrPosion,bool color ): base(stratrPosion,color)
        {
        }
        public override bool Move(char x, char y)
        {
            bool result; 

            int X = x - 'a';
            int Y = y - '1';

            result = Math.Abs(X - ChessCoordinates.X) <= 1 && Math.Abs(Y - ChessCoordinates.Y) <= 1 ;
            if (result)  
                ChessCoordinates = new Coordinates(x, y);
            else
                Console.WriteLine("Error");
            return result;
        }
    }
}
