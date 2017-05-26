using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NataliaPostrozny.Figures;

namespace NataliaPostrozny
{
    static class FiguresFactory
    {
        static int whitePawns = 0, blackPawns = 0;
        static int whiteTowers = 0, blackTowers = 0;

        public static Figure createFig(String figType, Colour colour)
        {
            if (figType.Equals("King"))
            {
                return new King(colour);
            }
            else if (figType.Equals("Pawn"))
            {
                if (colour.Equals(Colour.White))
                {
                    whitePawns++;
                    whitePawns %= 8;
                    return new Pawn(colour, whitePawns);
                }
                blackPawns++;
                blackPawns %= 8;
                return new Pawn(colour, blackPawns);
            }
            else if (figType.Equals("Tower"))
            {
                if (colour.Equals(Colour.White))
                {
                    whiteTowers++;
                    whiteTowers %= 2;
                    return new Pawn(colour, whiteTowers);
                }
                blackTowers++;
                blackTowers %= 2;
                return new Pawn(colour, blackTowers);
            }
            else if (figType.Equals("Queen"))
            {
                return new Queen(colour);
            }

            return null;
        }
    }
}
