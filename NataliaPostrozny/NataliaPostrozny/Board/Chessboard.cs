using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaPostrozny.Board
{
    class Chessboard : IEnumerable
    {
        private static readonly Chessboard chessboard = new Chessboard();
        private Figures.Figure[,] board;

        private Chessboard()
        {
            board = new Figures.Figure[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = null;
                }
            }
        }

        public Figures.Figure this[char x, int y]
        {
            get
            {
                return board[(int)x - 65, y-1];
            }

            set
            {
                board[(int)x - 65, y-1] = value;
            }
        }

        public static Chessboard GetBoard()
        {
            return chessboard;
        }

        public void print()
        {
            for(int i = 0; i<8; i++)
            {
                Console.Write((i+1).ToString() + '\t');
                for(int j = 0; j<8; j++)
                {
                    if (board[j,i] == null)
                    {
                        Console.Write("[ ]\t");
                    }
                    else
                    {
                        Console.Write("[" +board[j,i].name + "]\t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\tA\tB\tC\tD\tE\tF\tG\tH");

        }



        public IEnumerator GetEnumerator()
        {
            List<Figures.Figure> fig = new List<Figures.Figure>();

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j<8; j++)
                {
                    if (board[i, j] != null)
                    {
                        fig.Add(board[i, j]);
                    }
                }
            }

            return fig.GetEnumerator();
            
        }
    }

    static class Extension
    {
        public static int counter(this Chessboard chessboard)
        {
            int counter = 0;

            foreach (Figures.Figure f in chessboard)
            {
                counter++;
            }

            return counter;
        }
    }


}
