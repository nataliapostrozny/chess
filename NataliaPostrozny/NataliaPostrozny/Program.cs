using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NataliaPostrozny.Figures;
using NataliaPostrozny.Board;

namespace NataliaPostrozny
{
    class Program
    {
        static void Main(string[] args)
        {

            King k = new King(Colour.White);
            King kblack = new King(Colour.Black);

            Pawn p1w = new Pawn(Colour.White, 1);
            Pawn p2w = new Pawn(Colour.White, 2);

            Pawn p1b = new Pawn(Colour.Black, 1);
            Pawn p2b = new Pawn(Colour.Black, 2);

            Figure q = FiguresFactory.createFig("Queen", Colour.White);
            Queen qb = new Queen(Colour.Black);

            Tower t1w = new Tower(Colour.White, 1);
            Tower t2w = new Tower(Colour.White, 2);


            Console.WriteLine(q.toString());

            Figure f = q;

            Console.WriteLine(f.toString());
            



            Chessboard chessboard = Chessboard.GetBoard();
            chessboard['D', 1] = q;
            chessboard.print();
            Console.WriteLine(chessboard.counter());

            
            Console.ReadLine();
        }
    }
}
